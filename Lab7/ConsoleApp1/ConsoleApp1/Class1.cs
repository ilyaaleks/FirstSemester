using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    using System;
    public partial class Name
    {
        string secondname;
        public void output()
        {
            Console.WriteLine("Имя " + name + " Фамилия " + secondname);
        }
        public Name(string name, string secondname)
        {
            this.name = name;
            this.secondname = name;
        }
    }
}
