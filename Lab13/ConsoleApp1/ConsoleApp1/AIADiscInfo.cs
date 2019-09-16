using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    static class AIADiscInfo
    {
        public static void FreeSpace()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                if(drive.IsReady)
                Console.WriteLine($"Свободное место на диске {drive.Name} {drive.AvailableFreeSpace}");
            }
        }
        public static void DriveForm()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var drive in drives)
            {
                if (drive.IsReady)
                    Console.WriteLine($"Файловая система в {drive.Name} {drive.DriveFormat}");
            }
        }
        public static void InfoAboutAllDiscs()
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach(DriveInfo drive in drives )
            {
                if (drive.IsReady)
                    Console.WriteLine($"Информация о каждом диске {drive.Name} {drive.AvailableFreeSpace} {drive.TotalSize} {drive.VolumeLabel}");
            }
        }
    }
}
