using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Computer
    {
        int num;
        public int Num
        {
            get
            {
                return num;
            }
            set
            {
                num = value;
            }
        }
        Developer[] obj;
        public Computer(int i)
        {
            obj = new Developer[i];
            num = i;
        }
        public Developer this[int i]
        {
            get
            {
                return obj[i];
            }
            set
            {
                if (value is Developer)
                {
                    obj[i] = value;
                }
               
            }

        }
        public void Add(Developer a)
        {
            int count = 0;
            for(int i=0;i<obj.Length;i++,count++)
            {
                if(obj[i]==null)
                {
                    break;
                }
            }
            obj[count] = a;
        }
        public void Del(int num)
        {
            obj[num] = null;
        }
        public void output()
        {
            for(int i=0;i<obj.Length;i++)
            {
                if (obj[i] != null)
                {

                    Console.Write(obj[i].Namedev + " ");
                    obj[i].infodev();
                }


            }
            Console.WriteLine();
        }
    }
    class Controller 
    {
        public Computer SortGame(Computer a)
        {
            int count=0;
            string parametr;
            Console.WriteLine("Введите разработчика: ");
            parametr = Console.ReadLine();
            for (int i=0;i<a.Num;i++)
            {
                if(a[i] is saper && a[i].Namedev.ToUpper() == parametr.ToUpper())
                {
                    count++;

                }
            }
            Computer allofsaper = new Computer(count);
            count = 0;
 
           
            for (int i = 0; i < a.Num; i++)
            {
                if (a[i] is saper && a[i].Namedev.ToUpper()==parametr.ToUpper())
                {
                    allofsaper[count] = a[i];
                    count++;


                }
            }
            return allofsaper;
        }
        public Computer SortProc(Computer a)
        {
            int count = 0;
            string param;
            Console.WriteLine("Введите содержимое текстового процессора ");
            param = Console.ReadLine();
            TextProc check=null;
            for(int i=0;i<a.Num;i++)
            {
                if(a[i]is TextProc)
                check = (TextProc)a[i];
                if(check.Content.ToUpper()==param.ToUpper())
                {
                    count++;
                }
            }
            Computer res = new Computer(count);
            count = 0;
            for(int i=0;i<a.Num;i++)
            {
                if (a[i] is TextProc)
                    check = (TextProc)a[i];
                if (check.Content.ToUpper() == param.ToUpper())
                {
                    res[count] = a[i];
                    count++;
                }
            }
            return res;
        }
        public void allInOrder(Computer a)
        {
            int count = 0;
            PO check = null;
            for(int i=0;i<a.Num;i++)
            {
                if(a[i] is PO)
                {
                    
                    count++;
                }
            }
            PO[] mas = new PO[count];
            count = 0;
            for (int i = 0; i < a.Num; i++)
            {
                if (a[i] is PO)
                {
                    mas[count] = a[i] as PO;
                    count++;
                }
            }
            string word = null;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i].Name.CompareTo(mas[j].Name)<0)
                    {
                        word = mas[i].Name;
                        mas[i] = mas[j];
                        mas[j].Name = word;
                    }
                }
            }
        }
    }
}
