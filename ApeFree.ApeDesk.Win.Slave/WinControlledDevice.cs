using ApeFree.ApeDesk.Core;
using ApeFree.ApeRpc;
using ApeFree.ApeRpc.Attributes;
using STTech.CodePlus.Components;
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

namespace ApeFree.ApeDesk.Win.Slave
{
    public partial class WinControlledDevice : IControlledDevice, IDisposable
    {
        public TerminalInfo TerminalInfo { get; set; }

        public string ServiceName { get; }

        public string[] Dependencies { get; set; }

        public WinControlledDevice(string serviceName)
        {
            ServiceName = serviceName;

            screenTimer = new Timer();
            screenTimer.Interval = 50;
            screenTimer.Elapsed += ScreenTimer_Tick;
            screenTimer.Enabled = true;

            screenUpdateQueue = new FloaterTaskQueue<byte[]>(x =>
            {
                ScreenUpdated.Invoke(null, new ScreenUpdatedEventArgs(x));
            });
        }

        public void Dispose()
        {
        }

        public ServiceInitializeResult ServiceInitialize(ServiceInitializeArgument args)
        {
            return new ServiceInitializeResult();
        }
    }

    public partial class WinControlledDevice
    {
        private Timer screenTimer;
        private int screenCaptureCount = 0;
        TaskQueue<byte[]> screenUpdateQueue;
        private Bitmap _lastScreenImage;

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

        public float ScaleFactor { get; set; } = 0.2f;

        public int ContinuousActiveFrame { get; } = 5;

        //[RpcEvent]
        public event EventHandler<ScreenUpdatedEventArgs> ScreenUpdated;

        public void ScreenKeepAlive()
        {
            screenCaptureCount = ContinuousActiveFrame;
            screenTimer.Enabled = true;
        }

        public byte[] GetScreenCapture(float scaleFactor = 1)
        {
            using (var bmp = ScreenImageUtils.CaptureScreenFast())
            {
                return bmp.ToBytes(ImageFormat.Png);
            }
        }

        private void ScreenTimer_Tick(object sender, EventArgs e)
        {
            screenTimer.Enabled = false;

            if (ScreenUpdated == null)
            {
                return;
            }

            var screenImage = ScreenImageUtils.CaptureScreenFast();

            if (ScreenImageUtils.AreBitmapsEqual(_lastScreenImage, screenImage, 10))
            {
                screenImage.Dispose();
            }
            else
            {
                _lastScreenImage?.Dispose();
                _lastScreenImage = screenImage;

                // 是否压缩图像
                if (ScaleFactor != 1)
                {
                    var miniBmp = ScreenImageUtils.ScaleBitmap(screenImage, ScaleFactor);
                    var bytes = miniBmp.ToBytes(ImageFormat.Png);
                    screenUpdateQueue.Join(bytes);
                    miniBmp.Dispose();
                }
                else
                {
                    var bytes = screenImage.ToBytes(ImageFormat.Png);
                    screenUpdateQueue.Join(bytes);
                }
                screenCaptureCount--;
                Console.WriteLine($"frame {screenCaptureCount}/{ContinuousActiveFrame}");
            }

            screenTimer.Enabled = screenCaptureCount > 0;
        }
    }

    public partial class WinControlledDevice
    {
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

        public void CloseProcessById(int id)
        {
            var p = Process.GetProcessById(id);
            p?.Kill();
        }

        public ProcessInfo[] GetProcesses()
        {
            var ps = Process.GetProcesses().Select(x => new ProcessInfo(x)).ToArray();
            return ps;
        }

        public ProcessInfo GetProcessById(int id)
        {
            var p = Process.GetProcessById(id);
            if (p == null)
            {
                return null;
            }
            else
            {
                var pi = new ProcessInfo(p);
                return pi;
            }
        }
    }

    public partial class WinControlledDevice
    {
        public void SaveFile(string path, byte[] bytes)
        {
            File.WriteAllBytes(path, bytes);
        }

        public byte[] ReadFile(string targetPath, int startIndex = 0, int readLength = -1)
        {
            if (startIndex == 0 && readLength == -1)
            {
                return File.ReadAllBytes(targetPath);
            }

            using (var stream = File.OpenRead(targetPath))
            {
                var buffer = new byte[readLength];
                stream.Position = startIndex;
                var actLen = stream.Read(buffer, 0, buffer.Length);

                if (actLen == readLength)
                {
                    return buffer;
                }
                else
                {
                    var actData = new byte[actLen];
                    Array.Copy(buffer, actData, actData.Length);

                    return actData;
                }
            }
        }

        public DriveItem[] GetDrives()
        {
            var items = new List<DriveItem>();
            foreach (var x in DriveInfo.GetDrives())
            {
                try
                {
                    var di = new DriveItem()
                    {
                        Name = x.Name,
                        AvailableFreeSpace = x.AvailableFreeSpace,
                        DriveFormat = x.DriveFormat,
                        DriveType = x.DriveType,
                        IsReady = x.IsReady,
                        RootDirectory = x.RootDirectory.FullName,
                        TotalFreeSpace = x.TotalFreeSpace,
                        VolumeLabel = x.VolumeLabel,
                    };
                    items.Add(di);
                }
                catch (Exception) { }
            }

            return items.ToArray();
        }

        public FileCatalogItem[] GetFileCatalog(string folderPath)
        {
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            var dirItems = directory.GetDirectories().Select(x => new FileCatalogItem() { Name = x.Name, IsDirectory = true }).ToList();
            var fileItems = directory.GetFiles().Select(x => new FileCatalogItem() { CreationTime = x.CreationTime, FileSize = x.Length, IsDirectory = false, Name = x.Name });

            dirItems.AddRange(fileItems);
            return dirItems.ToArray();
        }

        public void FileDelete(string path)
        {
            File.Delete(path);
        }

        public void FileCopy(string srcPath, string dstPath, bool overwrite)
        {
            File.Copy(srcPath, dstPath, overwrite);
        }

        public void FileMove(string srcPath, string dstPath, bool overwrite)
        {
            File.Copy(srcPath, dstPath, overwrite);
        }

        public byte[] GetFileMD5(string path)
        {
            return new FileInfo(path).GetMD5();
        }

        public Core.FileVersionInfo GetVersionInfo(string path)
        {
            var source = System.Diagnostics.FileVersionInfo.GetVersionInfo(path);
            Core.FileVersionInfo destination = new Core.FileVersionInfo();
            destination.IsPreRelease = source.IsPreRelease;
            destination.ProductPrivatePart = source.ProductPrivatePart;
            destination.ProductName = source.ProductName;
            destination.ProductMinorPart = source.ProductMinorPart;
            destination.ProductMajorPart = source.ProductMajorPart;
            destination.ProductBuildPart = source.ProductBuildPart;
            destination.PrivateBuild = source.PrivateBuild;
            destination.OriginalFilename = source.OriginalFilename;
            destination.LegalTrademarks = source.LegalTrademarks;
            destination.LegalCopyright = source.LegalCopyright;
            destination.Language = source.Language;
            destination.IsSpecialBuild = source.IsSpecialBuild;
            destination.IsPrivateBuild = source.IsPrivateBuild;
            destination.ProductVersion = source.ProductVersion;
            destination.SpecialBuild = source.SpecialBuild;
            destination.IsDebug = source.IsDebug;
            destination.InternalName = source.InternalName;
            destination.FileVersion = source.FileVersion;
            destination.FilePrivatePart = source.FilePrivatePart;
            destination.FileName = source.FileName;
            destination.FileMinorPart = source.FileMinorPart;
            destination.FileMajorPart = source.FileMajorPart;
            destination.FileDescription = source.FileDescription;
            destination.FileBuildPart = source.FileBuildPart;
            destination.CompanyName = source.CompanyName;
            destination.Comments = source.Comments;
            destination.IsPatched = source.IsPatched;

            return destination;
        }
    }

    public partial class WinControlledDevice
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);

        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0010;
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020;
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040;
        private const int MOUSEEVENTF_WHEEL = 0x0800;

        public void SetCursorPosition(Point point)
        {
            SetCursorPos(point.X, point.Y);
        }

        public void MouseLeftDown(Point point)
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN, point.X, point.Y, 0, 0);
        }

        public void MouseLeftUp(Point point)
        {
            mouse_event(MOUSEEVENTF_LEFTUP, point.X, point.Y, 0, 0);
        }

        public void MouseRightDown(Point point)
        {
            mouse_event(MOUSEEVENTF_RIGHTDOWN, point.X, point.Y, 0, 0);
        }

        public void MouseRightUp(Point point)
        {
            mouse_event(MOUSEEVENTF_RIGHTUP, point.X, point.Y, 0, 0);
        }

        public void MouseMiddleDown(Point point)
        {
            mouse_event(MOUSEEVENTF_MIDDLEDOWN, point.X, point.Y, 0, 0);
        }

        public void MouseMiddleUp(Point point)
        {
            mouse_event(MOUSEEVENTF_MIDDLEUP, point.X, point.Y, 0, 0);
        }

        public void ScrollWheel(Point point, int value)
        {
            mouse_event(MOUSEEVENTF_WHEEL, point.X, point.Y, value, 0);
        }
    }

    public class ScreenImageUtils
    {
        [DllImport("gdi32.dll")]
        static extern bool BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);

        [DllImport("user32.dll")]
        static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll")]
        static extern IntPtr GetWindowDC(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern int ReleaseDC(IntPtr hWnd, IntPtr hDc);

        public static Bitmap CaptureScreenFast(PixelFormat pixelFormat = PixelFormat.Format24bppRgb)
        {
            IntPtr desktopWnd = GetDesktopWindow();
            IntPtr desktopDC = GetWindowDC(desktopWnd);

            Rectangle bounds = System.Windows.Forms.Screen.PrimaryScreen.Bounds;

            var bmp = new Bitmap(bounds.Width, bounds.Height, pixelFormat);

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

            Bitmap scaledBitmap = new Bitmap(newWidth, newHeight, originalBitmap.PixelFormat);

            using (Graphics g = Graphics.FromImage(scaledBitmap))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(originalBitmap, 0, 0, newWidth, newHeight);
            }

            return scaledBitmap;
        }

        /// <summary>
        /// 判断两个Bitmap是否相同
        /// </summary>
        /// <param name="bmp1"></param>
        /// <param name="bmp2"></param>
        /// <param name="skipPixels">采样间隔</param>
        /// <returns></returns>
        public static bool AreBitmapsEqual(Bitmap bmp1, Bitmap bmp2, int skipPixels = 1)
        {
            if (bmp1 == bmp2)
            {
                return true;
            }

            if (bmp1 == null || bmp2 == null)
            {
                return false;
            }

            if (bmp1.Width != bmp2.Width || bmp1.Height != bmp2.Height)
            {
                return false;
            }

            BitmapData data1 = bmp1.LockBits(new Rectangle(0, 0, bmp1.Width, bmp1.Height), ImageLockMode.ReadOnly, bmp1.PixelFormat);
            BitmapData data2 = bmp2.LockBits(new Rectangle(0, 0, bmp2.Width, bmp2.Height), ImageLockMode.ReadOnly, bmp2.PixelFormat);

            int bytesPerPixel1 = Image.GetPixelFormatSize(bmp1.PixelFormat) / 8;
            int bytesPerPixel2 = Image.GetPixelFormatSize(bmp2.PixelFormat) / 8;

            if (bytesPerPixel1 != bytesPerPixel2)
            {
                bmp1.UnlockBits(data1);
                bmp2.UnlockBits(data2);
                return false;
            }

            int stride1 = data1.Stride;
            int stride2 = data2.Stride;

            unsafe
            {
                byte* ptr1 = (byte*)data1.Scan0;
                byte* ptr2 = (byte*)data2.Scan0;

                for (int y = 0; y < bmp1.Height; y += skipPixels)
                {
                    for (int x = 0; x < bmp1.Width * bytesPerPixel1; x += skipPixels * bytesPerPixel1)
                    {
                        if (ptr1[x] != ptr2[x])
                        {
                            bmp1.UnlockBits(data1);
                            bmp2.UnlockBits(data2);
                            return false;
                        }
                    }
                    ptr1 += stride1 * skipPixels;
                    ptr2 += stride2 * skipPixels;
                }
            }

            bmp1.UnlockBits(data1);
            bmp2.UnlockBits(data2);

            return true;
        }
    }

    public static class BitmapExtensions
    {
        public static byte[] ToBytes(this Bitmap bmp, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, format);
                var bytes = ms.ToArray();
                return bytes;
            }
        }
    }
}
