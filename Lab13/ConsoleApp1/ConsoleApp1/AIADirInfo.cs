using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    static class AIADirInfo
    {
        public static void CountFiles(string path)
        {
           if(Directory.Exists(path))
            {
                var allfiles = Directory.GetFiles(path);
                Console.WriteLine("В данном каталоге "+allfiles.Length+" файлов");
                
            }
        }
        public static void DateOfCreation(string path)
        {
            if (Directory.Exists(path))
            {
                var date = Directory.GetCreationTime(path);
                Console.WriteLine("Данный каталог создан "+date.ToString());

            }
        }
        public static void CountOfUndercatalog(string path)
        {
            if (Directory.Exists(path))
            {
                int date = Directory.GetDirectories(path).Length;
                Console.WriteLine("Количество подкаталогов в каталоге: "+date);

            }
        }
        public static void ListofParentDir(string path)
        {
            if (Directory.Exists(path))
            {
                Console.WriteLine(Directory.GetParent(path));
            }
        }
    }
}
