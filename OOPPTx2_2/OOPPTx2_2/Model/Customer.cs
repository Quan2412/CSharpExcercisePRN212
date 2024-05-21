using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTx2_2.Model
{
    // Customer class inherit from Person class
    public class Customer : Person
    {
        public double Balance { get; set; }

        public override void Display()
        {
            Console.WriteLine($"Customer - Name: {Name}, Age: {Age}, Address: {Address}, Balance: {Balance}");
        }
    }
}
