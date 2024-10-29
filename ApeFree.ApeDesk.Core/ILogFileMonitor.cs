using System;

namespace ApeFree.ApeDesk.Core
{
    public interface ILogFileMonitor : ApeRpc.IService
    {
        void AddFile(string filename);
        void RemoveFile(string filename);

        event EventHandler<LogUpdatedEventArgs> LogUpdated;
    }


    public class LogUpdatedEventArgs : EventArgs
    {
        public string FileName { get; set; }
        public string[] Messages { get; set; }

        public LogUpdatedEventArgs()
        {
        }

        public LogUpdatedEventArgs(string fileName, string[] messages)
        {
            FileName = fileName;
            Messages = messages;
        }
    }
}
