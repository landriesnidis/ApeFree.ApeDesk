using System.Diagnostics;
using System;

namespace ApeFree.ApeDesk.Core
{
    public interface IProcessManager : ApeRpc.IService
    {
        void StartProcess(string path);

        bool CheckProcessRunningStatus(string path);

        void CloseProcess(string path);

        void CloseProcessById(int id);

        ProcessInfo GetProcessById(int id);

        ProcessInfo[] GetProcesses();
    }


    public class ProcessInfo
    {
        public ProcessInfo() { }

        public ProcessInfo(Process process)
        {
            Id = process.Id;
            ProcessName = process.ProcessName;
            UserName = process.StartInfo.UserName;
            MainWindowTitle = process.MainWindowTitle;
            WorkingDirectory = process.StartInfo.WorkingDirectory;
            MachineName = process.MachineName;
            WorkingSet64 = process.WorkingSet64;

            //try
            //{
            //    FileName = process.MainModule.FileName;
            //    StartTime = process.StartTime;
            //}
            //catch (Exception) { }
        }

        public int Id { get; set; }
        public string ProcessName { get; set; }
        public string UserName { get; set; }
        public string FileName { get; set; }
        public string MainWindowTitle { get; set; }
        public string WorkingDirectory { get; set; }
        public string MachineName { get; set; }
        public long WorkingSet64 { get; set; }
        public DateTime StartTime { get; set; }
    }
}
