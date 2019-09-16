using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public delegate void del1(string str);
        public event del1 upgrade;
        public event del1 work;
        public int version;
        public void upver()
        {
            version++;
            if(upgrade!=null)
            {
                upgrade("Версия поднялась до " + version);
            }
        }
        public void Work()
        {
            if(work!=null)
            {
                work("Все работает");
            }
        }
    }
}
