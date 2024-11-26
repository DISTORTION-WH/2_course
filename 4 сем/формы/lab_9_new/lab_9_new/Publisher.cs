using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9_new
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Publisher()
        {

        }
        public Publisher(string name)
        {
            Name = name;
        }
    }
}
