using ApeFree.ApeRpc;

namespace ApeFree.ApeDesk.Core
{
    /// <summary>
    /// 受控设备接口
    /// </summary>
    public interface IControlledDevice : IDeskModule, IScreenController, IScreenSynchronizer, IDriveBrowser, IProcessManager, ILogFileMonitor
    {

    }

}
