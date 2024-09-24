using ApeFree.ApeRpc;

namespace ApeFree.ApeDesk.Core
{
    /// <summary>
    /// 受控设备接口
    /// </summary>
    public interface IControlledDevice : IService, IScreenController, IScreenSynchronizer, IDriveBrowser, IProcessManager
    {

    }
}
