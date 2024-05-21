using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTx2_2.Model
{
    // Abstract class Person for inheritance
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public abstract void Display();
    }
}
