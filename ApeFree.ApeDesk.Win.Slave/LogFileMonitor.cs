using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using System.Timers;

namespace ApeFree.ApeDesk.Win.Slave
{
    /// <summary>
    /// 日志文件监视器
    /// </summary>
    public class LogFileMonitor : IDisposable
    {
        private string filePath;
        private long _lastFileSize = 0;
        private FileSystemWatcher fileSystemWatcher;
        private Timer timerReadDelay;

        public event EventHandler<LogUpdatedEventArgs> LogUpdated;

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool Enable { get => fileSystemWatcher.EnableRaisingEvents; set => fileSystemWatcher.EnableRaisingEvents = timerReadDelay.Enabled = value; }

        /// <summary>
        /// 缓存队列
        /// </summary>

        public BindingList<string> CacheLines { get; }

        /// <summary>
        /// 显示最大行数
        /// </summary>
        public int MaxLines { get; set; } = 200;

        /// <summary>
        /// 从文件尾部读取的最大缓存长度
        /// </summary>
        public uint ReadBufferSize { get; set; } = 4096;

        /// <summary>
        /// 监视文件的路径
        /// </summary>
        public string FilePath
        {
            get => filePath;
            set
            {
                if (filePath == null)
                {

                }

                if (filePath == string.Empty)
                {
                    throw new ArgumentNullException(nameof(FilePath));
                }

                if (File.Exists(filePath))
                {
                    throw new FileNotFoundException("File does not exist.", filePath);
                }

                filePath = value;
                fileSystemWatcher.EnableRaisingEvents = false;
                fileSystemWatcher.Path = Path.GetDirectoryName(filePath);
                fileSystemWatcher.Filter = Path.GetFileName(filePath);

                LoadFile();
            }
        }

        public LogFileMonitor()
        {
            CacheLines = new BindingList<string>();

            timerReadDelay = new System.Timers.Timer();
            timerReadDelay.Interval = 100;
            timerReadDelay.AutoReset = false;
            timerReadDelay.Elapsed += timerReadDelay_Tick;

            fileSystemWatcher = new FileSystemWatcher();
            fileSystemWatcher.EnableRaisingEvents = false;
            fileSystemWatcher.NotifyFilter = NotifyFilters.LastWrite;
            fileSystemWatcher.Changed += new FileSystemEventHandler(this.fileSystemWatcher_Changed);
        }

        private void fileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            lock (CacheLines)
            {
                // 使用Timer充当缓冲，在一定事件间隔内的更新统一读取，减少读取频次
                timerReadDelay.Enabled = true;
            }
        }

        private void ReadNewLines(string filePath)
        {
            CacheLines.RaiseListChangedEvents = false;

            List<string> lines = new List<string>();

            using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                var fileSize = fileStream.Length;
                fileStream.Position = Math.Max(fileSize - ReadBufferSize, _lastFileSize);
                _lastFileSize = fileSize;

                // 读取新增的内容
                using (var reader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
            }

            foreach (var line in lines)
            {
                CacheLines.Add(line);
            }

            while (CacheLines.Count > MaxLines)
            {
                CacheLines.RemoveAt(0);
            }

            CacheLines.RaiseListChangedEvents = true;
            CacheLines.ResetBindings();

            LogUpdated?.Invoke(this, new LogUpdatedEventArgs(lines.ToArray()));
        }

        public void LoadFile()
        {
            if (string.IsNullOrEmpty(FilePath))
            {
                return;
            }

            long currentFileSize = new FileInfo(FilePath).Length;

            // 如果是首次读取（_lastFileSize为0），则读取最后N行
            if (_lastFileSize == 0)
            {
                ReadNewLines(FilePath);
                return;
            }

            // 文件没有变化，则直接返回
            if (currentFileSize == _lastFileSize)
            {
                return;
            }

            // 如果文件变小了（可能文件被覆盖了），则重置_lastFileSize
            if (currentFileSize < _lastFileSize)
            {
                _lastFileSize = 0;
                CacheLines.Clear();
                ReadNewLines(FilePath);
                return;
            }

            ReadNewLines(FilePath);
        }

        private void timerReadDelay_Tick(object sender, ElapsedEventArgs e)
        {
            lock (CacheLines)
            {
                timerReadDelay.Enabled = false;
                LoadFile();
            }
        }

        public void Dispose()
        {
            Enable = false;
            fileSystemWatcher.Dispose();

            timerReadDelay.Elapsed -= timerReadDelay_Tick;
            timerReadDelay?.Dispose();

            CacheLines.RaiseListChangedEvents = false;
            CacheLines.Clear();

            LogUpdated = null;
        }

        public class LogUpdatedEventArgs : EventArgs
        {
            public string[] Messages { get; set; }

            public LogUpdatedEventArgs()
            {
            }

            public LogUpdatedEventArgs(string[] messages)
            {
                Messages = messages;
            }
        }
    }

}
