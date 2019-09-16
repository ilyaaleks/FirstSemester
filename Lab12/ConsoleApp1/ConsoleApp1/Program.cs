using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vect1 = new Vector(new int[] { 2, 3, 4, 14, 45, 2, 12, });
            reflector refl = new reflector();
            refl.GetInfo("ConsoleApp1.Vector");
            refl.PublicMethods("ConsoleApp1.Vector");
            refl.PropertyInfo("ConsoleApp1.Vector");
            refl.Interfaces("ConsoleApp1.Vector");
            refl.GetMethodsByParamets("ConsoleApp1.Vector", typeof(int));
            refl.CallMethods("D:\\Laba12call.txt");
        }
    }
}
