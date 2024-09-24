using System.IO;
using System;
using System.Diagnostics;

namespace ApeFree.ApeDesk.Core
{
    /// <summary>
    /// 驱动浏览器
    /// </summary>
    public interface IDriveBrowser : ApeRpc.IService
    {
        /// <summary>
        /// 保存文件
        /// </summary>
        /// <param name="savePath"></param>
        /// <param name="bytes"></param>
        void SaveFile(string savePath, byte[] bytes);

        /// <summary>
        /// 读取文件
        /// </summary>
        /// <param name="targetPath"></param>
        /// <param name="startIndex"></param>
        /// <param name="readLength"></param>
        /// <returns></returns>
        byte[] ReadFile(string targetPath, int startIndex = 0, int readLength = -1);

        /// <summary>
        /// 获取驱动器集合
        /// </summary>
        /// <returns></returns>
        DriveItem[] GetDrives();

        /// <summary>
        /// 获取文件目录
        /// </summary>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        FileCatalogItem[] GetFileCatalog(string folderPath);

        /// <summary>
        /// 文件删除
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        void FileDelete(string path);

        /// <summary>
        /// 文件拷贝
        /// </summary>
        /// <param name="srcPath"></param>
        /// <param name="dstPath"></param>
        /// <returns></returns>
        void FileCopy(string srcPath, string dstPath, bool overwrite);

        /// <summary>
        /// 文件移动
        /// </summary>
        /// <param name="srcPath"></param>
        /// <param name="dstPath"></param>
        /// <returns></returns>
        void FileMove(string srcPath, string dstPath, bool overwrite);

        /// <summary>
        /// 获取文件的MD5值
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        byte[] GetFileMD5(string path);

        /// <summary>
        ///  获取文件版本信息
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        FileVersionInfo GetVersionInfo(string path);
    }
    /// <summary>
    /// 表示文件目录项的类
    /// </summary>
    public class FileCatalogItem
    {
        /// <summary>
        /// 文件或目录的名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 指示是否为目录
        /// </summary>
        public bool IsDirectory { get; set; }
        /// <summary>
        /// 文件的大小（如果不是目录）
        /// </summary>
        public long FileSize { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreationTime { get; set; }
    }

    /// <summary>
    /// 表示驱动器项的类
    /// </summary>
    public class DriveItem
    {
        /// <summary>
        /// 可用的空闲空间大小
        /// </summary>
        public long AvailableFreeSpace { get; set; }
        /// <summary>
        /// 驱动器的格式
        /// </summary>
        public string DriveFormat { get; set; }
        /// <summary>
        /// 驱动器的类型
        /// </summary>
        public DriveType DriveType { get; set; }
        /// <summary>
        /// 指示驱动器是否准备好
        /// </summary>
        public bool IsReady { get; set; }
        /// <summary>
        /// 驱动器的名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 根目录
        /// </summary>
        public string RootDirectory { get; set; }
        /// <summary>
        /// 总的空闲空间大小
        /// </summary>
        public long TotalFreeSpace { get; set; }
        /// <summary>
        /// 驱动器的总大小
        /// </summary>
        public long TotalSize { get; set; }
        /// <summary>
        /// 卷标
        /// </summary>
        public string VolumeLabel { get; set; }
    }

    /// <summary>
    /// 文件版本信息
    /// </summary>
    public sealed class FileVersionInfo
    {
        /// <summary>
        /// 获取一个值，该值指示此版本是否为预发布版本
        /// </summary>
        public bool IsPreRelease { get; set; }

        /// <summary>
        /// 获取产品的私有部分
        /// </summary>
        public int ProductPrivatePart { get; set; }

        /// <summary>
        /// 获取产品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 获取产品的次要版本号
        /// </summary>
        public int ProductMinorPart { get; set; }

        /// <summary>
        /// 获取产品的主要版本号
        /// </summary>
        public int ProductMajorPart { get; set; }

        /// <summary>
        /// 获取产品的构建版本号
        /// </summary>
        public int ProductBuildPart { get; set; }

        /// <summary>
        /// 获取私有构建字符串
        /// </summary>
        public string PrivateBuild { get; set; }

        /// <summary>
        /// 获取原始文件名
        /// </summary>
        public string OriginalFilename { get; set; }

        /// <summary>
        /// 获取合法商标
        /// </summary>
        public string LegalTrademarks { get; set; }

        /// <summary>
        /// 获取合法版权信息
        /// </summary>
        public string LegalCopyright { get; set; }

        /// <summary>
        /// 获取语言信息
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// 获取一个值，该值指示此版本是否为特殊构建
        /// </summary>
        public bool IsSpecialBuild { get; set; }

        /// <summary>
        /// 获取一个值，该值指示此版本是否为私有构建
        /// </summary>
        public bool IsPrivateBuild { get; set; }

        /// <summary>
        /// 获取产品版本字符串
        /// </summary>
        public string ProductVersion { get; set; }

        /// <summary>
        /// 获取特殊构建字符串
        /// </summary>
        public string SpecialBuild { get; set; }

        /// <summary>
        /// 获取一个值，该值指示此文件是否为调试版本
        /// </summary>
        public bool IsDebug { get; set; }

        /// <summary>
        /// 获取内部名称
        /// </summary>
        public string InternalName { get; set; }

        /// <summary>
        /// 获取文件版本字符串
        /// </summary>
        public string FileVersion { get; set; }

        /// <summary>
        /// 获取文件的私有部分
        /// </summary>
        public int FilePrivatePart { get; set; }

        /// <summary>
        /// 获取文件名
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 获取文件的次要版本号
        /// </summary>
        public int FileMinorPart { get; set; }

        /// <summary>
        /// 获取文件的主要版本号
        /// </summary>
        public int FileMajorPart { get; set; }

        /// <summary>
        /// 获取文件描述
        /// </summary>
        public string FileDescription { get; set; }

        /// <summary>
        /// 获取文件的构建版本号
        /// </summary>
        public int FileBuildPart { get; set; }

        /// <summary>
        /// 获取公司名称
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// 获取注释
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// 获取一个值，该值指示此文件是否已打补丁
        /// </summary>
        public bool IsPatched { get; set; }
    }
}
