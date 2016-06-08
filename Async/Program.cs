using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        private static CalculateFolderSizeDelegate folderSizeFunc = CalculateFolderSize;
        public delegate Int64 CalculateFolderSizeDelegate(String folderName);
        private static Stopwatch sw = new Stopwatch();
        static void Main(string[] args)
        {
            //同步
            Stopwatch watch1 = new Stopwatch();
            watch1.Start();
            Int64 size1 = CalculateFolderSize(@"D:\Program Files (x86)");
            watch1.Stop();
            Console.WriteLine("size:{0},millsecond:{1}\r\n", size1.ToString(), watch1.Elapsed);


            //异步轮询
            Stopwatch watch = new Stopwatch();
            watch.Start();
            CalculateFolderSizeDelegate d = CalculateFolderSize;
            IAsyncResult asyncResult = d.BeginInvoke(@"D:\Program Files (x86)", null, null);
        
            Console.WriteLine("正在计算...");
            //当EndInvoke方法知道异步调用完成时，会取出结果作为返回值。由于EndInvoke方法有一个不断轮询的过程，所以主线程程序直到EndInvoke方法时会暂停等待异步方法调用完成，取回结果后再继续执行。
            Int64 size = d.EndInvoke(asyncResult);
            watch.Stop();

            Console.WriteLine("size:{0},millsecond:{1}\r\n", size.ToString(), watch.Elapsed);


            //异步回调
            sw.Start();
            folderSizeFunc.BeginInvoke(@"D:\Program Files (x86)", ShowFolderSizeCallBack, null);
            Console.WriteLine("正在计算...");


            Console.Read();
        }


        private static void ShowFolderSizeCallBack(IAsyncResult result)
        {

            Int64 size = folderSizeFunc.EndInvoke(result);
            sw.Stop();
            Console.WriteLine("size:{0},millsecond:{1}", size.ToString(), sw.Elapsed);

        }

        private static void ThreadSleep()
        {
            Thread.Sleep(2000);
        }


        private static Int64 CalculateFolderSize(string FolderName)
        {
            if (Directory.Exists(FolderName) == false)
            {
                throw new DirectoryNotFoundException("文件不存在");
            }
            DirectoryInfo rootDir = new DirectoryInfo(FolderName);
            //Get all subfolders
            DirectoryInfo[] childDirs = rootDir.GetDirectories();
            //Get all files of current folder
            FileInfo[] files = rootDir.GetFiles();
            Int64 totalSize = 0;
            //sum every file size
            foreach (FileInfo file in files)
            {
                totalSize += file.Length;

            }
            //sum every folder
            foreach (DirectoryInfo dir in childDirs)
            {
                totalSize += CalculateFolderSize(dir.FullName);
            }
            return totalSize;

        }
    }
}
