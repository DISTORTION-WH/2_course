using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Person
    {
        public string Name { get; set; }
        public string Sername { get; set; }

        public Person(string name, string sername)
        {
            Name = name;
            Sername = sername;
        }
    }
}
