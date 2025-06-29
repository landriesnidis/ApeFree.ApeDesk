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

        public void Bind(object service)
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

            // 解压图像数据
            var decBytes = e.ImageData.Decompress(CompressionFormat.Deflate);

            using (MemoryStream ms = new MemoryStream(decBytes))
            {
                var image = (Bitmap)Image.FromStream(ms);
                screenUpdateQueue.Join(image);
            }

            if (frameIndex > ScreenSynchronizer.ContinuousActiveFrame * 0.5)
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
            MouseLocation = this.GetImageCoordinate(e.Location);

            if (MouseLocation == EmptyMousePoint)
            {
                return;
            }

            if (MouseButtons != MouseButtons.None)
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

            ScreenController.SetCursorPosition(MouseLocation);

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

            ScreenController.SetCursorPosition(MouseLocation);

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

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);

            ScreenController.SetCursorPosition(MouseLocation);
            ScreenController.ScrollWheel(MouseLocation, e.Delta);
        }
    }
}
