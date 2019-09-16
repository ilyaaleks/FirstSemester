using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    static class AIAFileInfo
    {
        public static void FullPath(string path)
        {
            FileInfo file = new FileInfo(path);
            if (file.Exists)
            {

                file.Create();
                
            }
            Console.WriteLine("Полный путь: " + file.DirectoryName);
            Console.WriteLine($"Размер: {file.Length} байт; Расширение: {file.Extension}; Имя {file.Name}");
            Console.WriteLine($"Время создания файла: {file.CreationTimeUtc.ToString()}");
        }
    }
}
