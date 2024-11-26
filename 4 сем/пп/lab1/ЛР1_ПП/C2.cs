/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    using System;

    public class C2 : I1
    {
        private int prField;
        protected string protField;
        public bool pProperty { get; set; }

        public event EventHandler PersEvent;

        public int PersProp
        {
            get { return prField; }
            set { prField = value; }
        }

        public string this[int index]
        {
            get { return protField; }
            set { protField = value; }
        }

        public C2()
        {
            prField = 3;
            protField = "пум";
            pProperty = false;
        }

        public void PersMeth()
        {
            Console.WriteLine("вызван метод");
        }

        protected int ProtMethod()
        {
            return 7;
        }

        public int GetPrField()
        {
            return prField;
        }

        public void SetPrField(int value)
        {
            prField = value;
        }

        public virtual void OnPersEvent(EventArgs e)
        {
            PersEvent?.Invoke(this, e);
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            C2 objj = new C2();
            objj.PersMeth();
            objj.pProperty = true;
            objj.SetPrField(10);
            Console.WriteLine(objj.GetPrField());
            Console.WriteLine(objj[0]);

            objj.PersEvent += Obj_PersEvent;
            objj.OnPersEvent(EventArgs.Empty);
        }

        public static void Obj_PersEvent(object sender, EventArgs e)
        {
            Console.WriteLine("МЯУМЯУМЯУМЯУМЯУ");
        }
    }
}
*/