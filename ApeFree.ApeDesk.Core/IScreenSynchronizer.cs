using ApeFree.ApeRpc.Attributes;
using System;
using System.Drawing;
using System.IO;

namespace ApeFree.ApeDesk.Core
{
    /// <summary>
    /// 共享屏幕
    /// </summary>
    public interface IScreenSynchronizer
    {
        /// <summary>
        /// 屏幕更新事件
        /// </summary>
        event EventHandler<ScreenUpdatedEventArgs> ScreenUpdated;

        /// <summary>
        /// 屏幕更新间隔（ms）
        /// </summary>
        int ScreenUpdateInterval { get; set; }

        /// <summary>
        /// 画面拉伸比例
        /// </summary>
        float ScaleFactor { get; set; }

        /// <summary>
        /// 连续活跃帧数
        /// </summary>
        [InvariableProperty]
        int ContinuousActiveFrame { get; }

        /// <summary>
        /// 保持屏幕刷新活跃
        /// </summary>
        void ScreenKeepAlive();

        /// <summary>
        /// 获取屏幕截图
        /// </summary>
        /// <param name="scaleFactor"></param>
        /// <returns></returns>
        byte[] GetScreenCapture(float scaleFactor = 1);
    }

    /// <summary>
    /// 屏幕更新事件参数
    /// </summary>
    public class ScreenUpdatedEventArgs : EventArgs
    {
        public byte[] ImageData { get; }

        public ScreenUpdatedEventArgs(byte[] imageData)
        {
            ImageData = imageData;
        }
    }
}
