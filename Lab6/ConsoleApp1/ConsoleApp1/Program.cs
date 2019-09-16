using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp1
{
   
    abstract class Developer//разработчик
    {
        public Developer(string namedev)
        {
            this.Namedev = namedev;
        }
        private string namedev;
        public string Namedev
        {
            get
            {
                return namedev;
            }
            set
            {
                namedev = value;
            }
        }
        public virtual void infodev()
        {
            Console.WriteLine("Ваш покорный слуга" + namedev);
        }
        public override string ToString()
        {
            return base.ToString() + " Имя автора " + namedev ;
        }
    }
    class PO : Developer//ПО
    {
        private string name;
        public PO(string name, string namedev) : base(namedev)
        {
            this.Name = name;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("Вы ввели пустое значение");
                }
                else
                {
                    name = value;
                }
            }
        }
        public override string ToString()
        {
            return base.ToString()+" Название продукта "+name;
        }

    }
    class TextProc : PO
    {
        int width;
        int height;
        int numofsumbol;
        string content;
        public TextProc(int width, int height, string name, string namedev, string content) : base(name, namedev)
        {
            this.width = width;
            this.height = height;
            this.numofsumbol = content.Length;
            this.content = content;
        }
        public override void infodev()
        {
            base.infodev();
            Console.Write("Переопределнная функция");
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }

        }
        public override string ToString()
        {
            return base.ToString()+" Ширина "+height+" Высота "+width;
        }
    }
    class Word : TextProc
    {
        string nameofdocument;
        public Word(int width, int height, string name, string namedev, string content, string nameofdocument) : base(width, height, name, namedev, content)
        {
            this.nameofdocument = nameofdocument;
        }
        public string Nameofdocument
        {
            get
            {
                return nameofdocument;
            }
            set
            {
                Nameofdocument = value;
            }

        }
        public override string ToString()
        {
            return base.ToString()+" Имя документа "+Nameofdocument;
        }
    }
    class OperationWord : Word
    {
        public OperationWord(int width, int height, string name, string namedev, string content, string nameofdocument) : base(width, height, name, namedev, content, nameofdocument)
        {

        }
        public void Outputinfo()
        {
            Console.WriteLine($"Имя документа: {Nameofdocument} Высота и ширина документа: {Width}*{Height} Содержимое:{Content}");
        }
    }

    class virus : PO
    {
        int key;
        public virus(int key, string name, string namedev) : base(name, namedev) { this.key = key; }
        public int Key
        {
            get
            {
                return key;
            }
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
            virus a = (virus)obj;
            if (a.key == this.key)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return key * Name.Length; ;
        }
        public override string ToString()
        {
            return base.ToString()+" ключ от продукта "+key;
        }
    }
    interface dovirus//4 с одноименным методами в разных интерфейсах
    {
        void hack();
    }
    interface NotDovirus
    {
        void hack();
    }
    class operationvirus : virus,dovirus,NotDovirus
    {
        public operationvirus(int key, string name, string namedev) : base(key, name, namedev) { }
        void dovirus.hack()
        {
            Console.WriteLine("Не вирус, но особо опасен" + Key.GetHashCode());
        }
        void NotDovirus.hack()
        {
            Console.WriteLine("В следующий раз взломаю");
        }
        ~operationvirus()
        {
            Console.WriteLine("Ох е, меня удалили");
        }
    }
    class operationofgames : PO
    {
        int X;
        int Y;
        public operationofgames(string name, string namedev) : base(name, namedev) { }
        public void boom()
        {
            Console.WriteLine("Вы подорвались на мине");
        }
        public void move(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int x
        {
            get
            {
                return X;
            }
            set { X = value; }
        }
        public int y
        {
            get
            {
                return Y;
            }
            set { Y = value; }
        }
    }
    sealed class saper : operationofgames//ненаследуемый класс
    {
        public saper(string name, string namedev, string nameofgamer) : base(name, namedev) { this.nameofgamer = nameofgamer; }
        string nameofgamer;
        public new void boom()
        {
            Console.WriteLine("Игрок подорвался на мине " + nameofgamer);
        }
    }
    interface ISum
    {
        int a { get; set; }
        int b { get; set; }
        int sum(int a, int b);
    }
    class Sum : ISum //Применение интерфейса
    {
        public int a { get; set; }
        public int b { get; set; }
        public int sum(int a,int b)
        {
            return a + b;
        }
    }
    struct bac
    {
        public int a;
        public int b;
        public void sum()
        {
            Console.WriteLine("Сумма структуры " + a + b);
        }
    }
    class Printer
    {
        public virtual void iAmPrinting(object a)//спросить про реализацию
        {
            if(a is Developer)
            {
                Developer b = (Developer)a;
                Console.WriteLine(b.ToString() + b.GetType());
            }
            else
            {
                Console.WriteLine("Параметр не является общим абстрактным классом");
            }
        }
    }
    enum day
    {
        monday=1,tuesday,thirsday,fourthday,friday,saturday,sunday
    }
    public partial class Name
    {
        string name;
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            operationvirus virus = new operationvirus(17, "trol", "ilya");//4 реализация этих интерефейсов
            dovirus virus1 = virus as dovirus;
            virus1.hack();
            Word mywork = new Word(16, 12, "firstwork", "Google", "kachestvenniy", "laba1");
            NotDovirus virus2 = (NotDovirus)virus;//работа с интерфейсом и его методами
            virus2.hack();
            //5
            Console.WriteLine(virus2.ToString());//вызов переорпделенного метода
            bac dual;
            dual.a = 15;
            dual.b = 30;
            dual.sum();
            Console.WriteLine("Сегодня день недели " + day.thirsday);
            Name myname = new Name("ilya", "alekseev");//партиал в разных файлах
            myname.output();
            Computer a = new Computer(7);
            TextProc pr = new TextProc(12, 14, "tr", "gr", "regve");
            PO tt = new PO("greatjob", "bstu");
            a.Add(virus);
            a.Add(mywork);
            a.output();
            a.Del(0);
            a.output();
            a.Add(pr);
            a.Add(tt);
            saper sap1 = new saper("first", "trf", "GGG");
            saper sap2 = new saper("second", "trfy", "Gwefw");
        
            a.Add(sap1);
            a.Add(sap2);
            Controller gg = new Controller();
            Computer ready=gg.SortGame(a);
            ready.output();
            


        }
    }
}
