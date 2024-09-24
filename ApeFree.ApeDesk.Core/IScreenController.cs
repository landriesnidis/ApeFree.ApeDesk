using System.Drawing;
using System.Runtime.InteropServices;

namespace ApeFree.ApeDesk.Core
{
    /// <summary>
    /// 屏幕控制器
    /// </summary>
    public interface IScreenController : IScreenSynchronizer
    {
        /// <summary>
        /// 鼠标移动
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        void SetCursorPosition(Point point);

        /// <summary>
        /// 鼠标左键按下
        /// </summary>
        void MouseLeftDown(Point point);

        /// <summary>
        /// 鼠标左键抬起
        /// </summary>
        void MouseLeftUp(Point point);

        /// <summary>
        /// 鼠标右键按下
        /// </summary>
        void MouseRightDown(Point point);

        /// <summary>
        /// 鼠标右键抬起
        /// </summary>
        void MouseRightUp(Point point);

        /// <summary>
        /// 鼠标中键按下
        /// </summary>
        void MouseMiddleDown(Point point);

        /// <summary>
        /// 鼠标中键抬起
        /// </summary>
        void MouseMiddleUp(Point point);

        /// <summary>
        /// 鼠标滚轮滚动
        /// </summary>
        /// <param name="value"></param>
        void ScrollWheel(Point point, int value);
    }
}
