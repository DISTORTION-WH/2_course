using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class C4 : C3
    {
        private string prFieldC4;

        public C4() : base()
        {
            prFieldC4 = "приватное поле тут";
        }

        public void Method2()
        {
            Console.WriteLine("метод2 уже устал от того что его вызывают");
        }

        public void Method3()
        {
            Console.WriteLine("метод3 вызван");
            Console.WriteLine("Результат протектед метода" + ProtMethod());
            Console.WriteLine("MyProperty: " + MyProp);
        }
    }
    class C6 : I2
    {
        public void Method1()
        {
            Console.WriteLine("пим");
        }
    }

    class C5 : I2
    {
        public void Method1()
        {
            Console.WriteLine("пау");
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            C4 objj = new C4();
            objj.Method1(); // от с3
            objj.Method2(); //  C4
            objj.Method3();

            C5 objj5 = new C5();
            C6 objj6 = new C6();

            objj5.Method1();
            objj6.Method1();
        }
    }
}

