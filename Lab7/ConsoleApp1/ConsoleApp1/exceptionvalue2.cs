using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class exceptionValue2:exceptionValue1
    {
        
        public exceptionValue2(string err,int value):base(err,Convert.ToString(value))
        {
        }
    }
}
