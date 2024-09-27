using ApeFree.ApeDesk.Core;
using ApeFree.ApeRpc;
using STTech.CodePlus.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApeFree.ApeDesk.Win.Master
{
    public class RemoteScreenView : PictureBox
    {
        public Point MouseLocation { get; private set; }
        public IScreenController ScreenController { get; private set; }
        public IScreenSynchronizer ScreenSynchronizer { get; private set; }
        public float ScreenScaleFactor { get; private set; }

        /// <summary>
        /// 屏幕同步使能
        /// </summary>
        [Description("屏幕同步使能")]
        public bool EnableScreenSyncing { get; set; } = true;

        int frameIndex = 0;
        TaskQueue<Bitmap> screenUpdateQueue;
        private static Point EmptyMousePoint = new Point(-1, -1);

        public RemoteScreenView()
        {
            SizeMode = PictureBoxSizeMode.Zoom;
            screenUpdateQueue = new FloaterTaskQueue<Bitmap>(x =>
            {
                this.Invoke(new Action(() =>
                {
                    this.Image?.Dispose();
                    this.Image = x;
                }));
            });
        }

        public void Bind(IService service)
        {
            if (service is IScreenController screenController)
            {
                ScreenController = screenController;
            }

            if (service is IScreenSynchronizer screenSynchronizer)
            {
                ScreenSynchronizer = screenSynchronizer;
                ScreenSynchronizer.ScreenUpdated += ScreenSynchronizer_ScreenUpdated;
                _ = ScreenSynchronizer.ContinuousActiveFrame;
                ScreenScaleFactor = ScreenSynchronizer.ScaleFactor;
            }
        }

        private void ScreenSynchronizer_ScreenUpdated(object sender, ScreenUpdatedEventArgs e)
        {
            frameIndex++;

            using (MemoryStream ms = new MemoryStream(e.ImageData))
            {
                var image = (Bitmap)Image.FromStream(ms);
                screenUpdateQueue.Join(image);
            }

            if (frameIndex > ScreenSynchronizer.ContinuousActiveFrame * 0.8)
            {
                RemoteScreenCaptrueRefresh();
                frameIndex = 0;
            }
        }

        private void RemoteScreenCaptrueRefresh()
        {
            if (!EnableScreenSyncing)
            {
                return;
            }

            if (!Visible)
            {
                return;
            }

            if (ScreenSynchronizer != null)
            {
                Task.Run(ScreenSynchronizer.ScreenKeepAlive);
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            MouseLocation = GetImageCoordinates(e.Location);

            if (MouseLocation == EmptyMousePoint)
            {
                return;
            }

            if (MouseButtons == MouseButtons.Left)
            {
                ScreenController.SetCursorPosition(MouseLocation);
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (MouseLocation == EmptyMousePoint)
            {
                return;
            }

            switch (e.Button)
            {
                case MouseButtons.Left:
                    ScreenController.MouseLeftDown(MouseLocation);
                    break;
                case MouseButtons.Right:
                    ScreenController.MouseRightDown(MouseLocation);
                    break;
                case MouseButtons.Middle:
                    ScreenController.MouseMiddleDown(MouseLocation);
                    break;
                default: break;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (MouseLocation == EmptyMousePoint)
            {
                return;
            }

            switch (e.Button)
            {
                case MouseButtons.Left:
                    ScreenController.MouseLeftUp(MouseLocation);
                    break;
                case MouseButtons.Right:
                    ScreenController.MouseRightUp(MouseLocation);
                    break;
                case MouseButtons.Middle:
                    ScreenController.MouseMiddleUp(MouseLocation);
                    break;
                default: break;
            }
        }

        private Point GetImageCoordinates(Point mousePoint)
        {
            Image image = this.Image;
            if (image == null)
            {
                return EmptyMousePoint;
            }

            // 获取 PictureBox 的大小
            Size boxSize = this.Size;

            // 计算图像的显示比例
            float scaleX = (float)boxSize.Width / image.Width;
            float scaleY = (float)boxSize.Height / image.Height;

            float scale = Math.Min(scaleX, scaleY);

            // 计算图像在 PictureBox 中的偏移量
            int offsetX = (boxSize.Width - (int)(image.Width * scale)) / 2;
            int offsetY = (boxSize.Height - (int)(image.Height * scale)) / 2;

            if (mousePoint.X < offsetX || mousePoint.X > offsetX + image.Width * scale ||
                mousePoint.Y < offsetY || mousePoint.Y > offsetY + image.Height * scale)
            {
                return EmptyMousePoint;
            }

            // 计算鼠标在真实图像上的坐标
            int imageX = (int)((mousePoint.X - offsetX) / scale / ScreenScaleFactor);
            int imageY = (int)((mousePoint.Y - offsetY) / scale / ScreenScaleFactor);

            return new Point(imageX, imageY);
        }
    }
}
