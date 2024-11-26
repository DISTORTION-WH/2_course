/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class C3 : I2
    {
        private int prField;
        protected string protField;

        public bool PProp { get; set; }

        public int MyProp
        {
            get { return prField; }
            set { prField = value; }
        }

        public string this[int index]
        {
            get { return protField; }
            set { protField = value; }
        }

        public C3()
        {
            prField = 7;
            protField = "пиупау";
            PProp = false;
        }

        public void Method1()
        {
            Console.WriteLine("метод снова вызвали, а он сработал");
        }

        protected int ProtMethod()
        {
            return 1;
        }
    }
}
*/