using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class exceptionValue1:Exception
    {
        public readonly string value;
        public exceptionValue1(string err,string value) : base(err) { this.value = value; }
    }
 
}
