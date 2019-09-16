using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class  MathOperation
    {
        public static int Max(Massive a)//максимальный элемент
        {
            int length = (int)a;
            int max =a[0];
            for (int i = 0; i < length; i++)
            {
                if(a[i]>max)
                {
                    max = a[i];
                }
            }
            return max;
        }
        public static int Min(Massive a)//минимальный элемент
        {
            int length = (int)a;
            int min = a[0];
            for (int i = 0; i < length; i++)
            {
                if (min > a[i])
                {
                    min = a[i];
                }
            }
            return min;
        }
        public static int num(Massive a)//количество 
        {
            
            return (int)a;
        }
        public static bool isletter(this string a, char b)
        {
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==b)
                {
                    return true;
                }
            }
            return false;
        }
        public static void Del(this Massive a)//либо полностью перезаписывать массив
        {
            for(int i=0;i<(int)a;i++)
            {
                if(a[i]<0)
                {
                    a[i]=0;
                }
            }
        }
    }
    class Owner
    {
        private int ID;
        private string name;
        private string organization;
        public Owner(int Id, string name, string organization){ this.ID = Id;this.name = name;this.organization = organization; }
    }
    class Massive
    {
        private int[] mas;
        private static int count = 0;
        public static Massive operator *(Massive a1, Massive a2)
        {
            Massive a3 = new Massive(a1.mas.Length);
            if (a1.mas.Length == a2.mas.Length)
            {

                for (int i = 0; i < a1.mas.Length; i++)
                {
                    a3.mas[i] = a1.mas[i] * a2.mas[i];
                }
                return a3;
            }
            else
            {
                Console.WriteLine("Размеры не совпадают");
                return null;
            }
        }
        public static bool operator true(Massive a1)
        {
            for (int i = 0; i < a1.mas.Length; i++)
            {
                if (a1.mas[i] < 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator false(Massive a1)
        {
            for (int i = 0; i < a1.mas.Length; i++)
            {
                if (a1.mas[i] < 0)
                {
                    return !false;
                }
            }
            return !true;
        }
        public static explicit operator int(Massive a1)
        {
            return a1.mas.Length;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Massive mas1 = (Massive)obj;
            if (mas1.mas.Length != this.mas.Length)
            {
                return false;
            }
            for (int i = 0; i < mas1.mas.Length; i++)
            {
                if (mas1.mas[i] != this.mas[i])
                {
                    return false;
                }
            }
            return true;
        }
        public override int GetHashCode()
        {
            return mas[0] * count / 2;
        }
        public static bool operator !=(Massive a1, Massive a2)
        {

            return !a1.Equals(a2);
        }
        public static bool operator ==(Massive a1, Massive a2)
        {

            return a1.Equals(a2);
        }
        public static bool operator <(Massive a1, Massive a2)
        {
            int sum1 = 0, sum2 = 0;
            for (int i = 0; i < a1.mas.Length; i++)
            {
                sum1 += a1.mas[i];
            }
            for (int i = 0; i < a2.mas.Length; i++)
            {
                sum2 += a2.mas[i];
            }
            if (sum1 < sum2)
            {
                return true;
            }
            else { return false; }
        }
        public static bool operator >(Massive a1, Massive a2)
        {
            return !(a1 < a2);
        }
        Date now;
        public Massive(int size) { count++; mas = new int[size]; a = new Owner(count.GetHashCode(), "Ilya", "BSTU"); now = new Date(DateTime.Now); }
        public static int seecount()
        {
            return count;
        }
        public void outtime()
        {
            Console.WriteLine(now.date);
        }
        public int this[int i]
        {
            get
            {
                return mas[i];
            }
            set
            {
                mas[i] = value;
            }
        }
        public Owner a;//вложенный объект
         class Date//вложенный класс
        {
            public DateTime date;
            public Date(DateTime date) { this.date = date; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //Massive massives1 = new Massive(5);
            //Massive massives2 = new Massive(5);
            //Massive massives4 = new Massive(5);
            //for (int i=0;i<5;i++)
            //{
            //    massives2[i] = i * i;
            //    massives1[i] = i * 2 * 23;
            //    massives4[i] = i * 2 * 23;
            //}
            //Massive massives3=massives1*massives2;
            //Console.WriteLine(massives3[2]);
            //massives1[0] = -10;
            //if(massives1)
            //{
            //    Console.WriteLine("Нет отрицательных элементов");
            //}
            //massives1[0] = 5;
            //if (massives1)
            //{
            //    Console.WriteLine("Нет отрицательных элементов");
            //}
            //if(massives1>massives2)
            //{
            //    Console.WriteLine("Первый массив больше второго");

            //}
            //if(massives1==massives4)
            //{
            //    Console.WriteLine("Массив 4 равен первому массиву");

            //}
            //if(massives1!=massives2)
            //{
            //    Console.WriteLine("Массив 1 не равен массиву 2");
            //}
            //Console.WriteLine((int)massives1);
            //string check = "proverka";
            //Console.WriteLine(check.isletter('n'));
            //massives1.outtime();
            //Thread.Sleep(10000);
            //Massive massives10 = new Massive(5);
            //massives10.outtime();
            //8 лабораторная работа
            ColletionType<int> a = new ColletionType<int>();

            try
            {
                a.Add(3);
                a.Add(5);
                a.Add(4);
                a.Add(9);
                a.content();
            }
            catch(Exception err)
            {
                Console.WriteLine(err.InnerException);
            }
            finally
            {
                Console.WriteLine("Использую блок finally");
            }
            PO po1 = new PO("TUT.by", "John");
            PO po2 = new PO("Gabella", "ilya");
            PO po3 = new PO("laba5", "Serj");
            
            try
            {
                ColletionType<PO> b = new ColletionType<PO>();//задал ограничение только на значимый тип
                b.Add(po1);
                b.Add(po2);
                b.Add(po3);
            }
            catch (Exception err)
            {
                Console.WriteLine(err.InnerException);
            }
            finally
            {
                Console.WriteLine("Использую блок finally");
            }
        }
    }
}
