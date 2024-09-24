using ApeFree.ApeDesk.Core;
using ApeFree.ApeRpc;
using ApeFree.ApeRpc.Attributes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ApeFree.ApeDesk.Win
{
    public class WinControlledDevice : IControlledDevice, IDisposable
    {
        private System.Timers.Timer screenTimer;
        private Bitmap screenImage;

        public int ScreenUpdateInterval
        {
            get => (int)screenTimer.Interval;
            set
            {
                screenTimer.Stop();
                screenTimer.Interval = value;
                screenTimer.Start();
            }
        }

        public TerminalInfo TerminalInfo { get; set; }
        public string ServiceName { get; }
        public string[] Dependencies { get; set; }
        public float ScaleFactor { get; set; } = 0.2f;

        [RpcEvent]
        public event EventHandler<ScreenUpdatedEventArgs> ScreenUpdated;

        public WinControlledDevice(string serviceName)
        {
            ServiceName = serviceName;

            screenTimer = new();
            screenTimer.Interval = 50;
            screenTimer.Elapsed += ScreenTimer_Tick;
            screenTimer.Enabled = true;
        }

        private void ScreenTimer_Tick(object sender, EventArgs e)
        {
            screenTimer.Enabled = false;

            if (ScreenUpdated == null)
            {
                return;
            }

            screenImage = ScreenCapture.CaptureScreenFast(screenImage);

            var bmp = screenImage;
            if (ScaleFactor != 1)
            {
                bmp = ScreenCapture.ScaleBitmap(bmp, ScaleFactor);
            }

            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Png); // 可以根据需要选择图像格式，如 Jpeg、Bmp 等
                var bytes = ms.ToArray();
                ScreenUpdated.Invoke(null, new ScreenUpdatedEventArgs(bytes));

                Console.WriteLine($"{DateTime.Now.ToString("hh:mm;ss.ffff")} 已截图，数据大小 {bytes.Length / 1024f / 1024f} MB");
            }

            if (bmp != screenImage)
            {
                bmp.Dispose();
            }

            ScreenCaptureCount--;
            screenTimer.Enabled = ScreenCaptureCount > 0;
        }

        public void Dispose()
        {
            screenImage?.Dispose();
        }

        public ServiceInitializeResult ServiceInitialize(ServiceInitializeArgument args)
        {
            return new ServiceInitializeResult();
        }

        int ScreenCaptureCount = 0;

        public void ScreenKeepAlive()
        {
            ScreenCaptureCount = 3;
            screenTimer.Enabled = true;
        }

        public void StartProcess(string path)
        {
            Process.Start(path);
        }

        public bool CheckProcessRunningStatus(string path)
        {
            var processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(path));
            return processes.Length > 0;
        }

        public void CloseProcess(string path)
        {
            var processes = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(path));
            foreach (var process in processes)
            {
                process.Kill();
            }
        }
    }

    public class ScreenCapture
    {
        [DllImport("gdi32.dll")]
        static extern bool BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

        [DllImport("user32.dll")]
        static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDc);

        public static Bitmap CaptureScreenFast(Bitmap bmp, PixelFormat pixelFormat = PixelFormat.Format24bppRgb)
        {
            IntPtr desktopWnd = GetDesktopWindow();
            IntPtr desktopDC = GetWindowDC(desktopWnd);

            Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;

            if (bmp == null)
            {
                bmp = new Bitmap(bounds.Width, bounds.Height, pixelFormat);
            }

            if (bmp.Size != bounds.Size)
            {
                bmp.Dispose();
            }

            using (Graphics g = Graphics.FromImage(bmp))
            {
                IntPtr graphicsDC = g.GetHdc();
                BitBlt(graphicsDC, 0, 0, bounds.Width, bounds.Height, desktopDC, 0, 0, 13369376);
                g.ReleaseHdc(graphicsDC);
            }

            ReleaseDC(desktopWnd, desktopDC);

            return bmp;
        }

        public static Bitmap ScaleBitmap(Bitmap originalBitmap, double scaleFactor)
        {
            int newWidth = (int)(originalBitmap.Width * scaleFactor);
            int newHeight = (int)(originalBitmap.Height * scaleFactor);

            Bitmap scaledBitmap = new Bitmap(newWidth, newHeight);

            using (Graphics g = Graphics.FromImage(scaledBitmap))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(originalBitmap, 0, 0, newWidth, newHeight);
            }

            return scaledBitmap;
        }
    }
}
