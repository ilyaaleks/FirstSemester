using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            User ilya = new User();
            ilya.version = 10;
            ilya.upgrade += (str) => Console.WriteLine(str);
            ilya.upver();
            ilya.work += (str) => Console.WriteLine(str);
            User German = new User();
            German.version = 5;
            German.upgrade += (str) => Console.WriteLine(str);
            German.work+=(str)=>Console.WriteLine(str);
            German.upver();
            string ilya1 = "ilya alekseev. Просто карсавчек";
            Action<String> op;
            op = (str1) => Console.WriteLine(str1.ToUpper());
            op += (str1) => Console.WriteLine("a" + str1);
            op += (str1) => Console.WriteLine(str1.ToLower());
            op += checkzn;
            op(ilya1);
        }
        static void checkzn(string str)
        {
            for(int i=0;i<str.Length;i++)
            {
                if(str[i]=='!'||str[i]==','||str[i]=='.')
                {
                    str=str.Substring(0,i-1)+str.Substring(i+1,str.Length);
                }
            }
            Console.WriteLine(str);
        }
    }
   
}
