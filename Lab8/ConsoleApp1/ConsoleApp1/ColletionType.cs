using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ColletionType<T>:Interface1<T> where T:class,IComparable<T>
    {
        public List<T> a=new List<T>();
        public void Add(T a1)
        {
            a.Add(a1);
        }
        public void Delete(T a1)
        {
            a.Remove(a1);
        }
        public void content()
        {
            foreach(T elem in a)
            {
                Console.WriteLine(elem);
            }
        }
    }
}
