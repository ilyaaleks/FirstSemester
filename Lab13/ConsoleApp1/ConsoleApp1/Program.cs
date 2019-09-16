using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AIADiscInfo.FreeSpace();
            AIADirInfo.CountFiles("D:\\torrent");
            AIADirInfo.DateOfCreation("D:\\torrent");
            AIADirInfo.CountOfUndercatalog("D:\\torrent");
            AIADirInfo.ListofParentDir("D:\\torrent\\Revo Uninstaller Pro 4.0.0 RePack (& Portable) by KpoJIuK");
            AIAFileInfo.FullPath("D:\\torrent\\Laba13.txt");
        }
    }
}
