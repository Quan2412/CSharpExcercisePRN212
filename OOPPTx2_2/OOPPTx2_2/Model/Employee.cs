using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTx2_2.Model
{
    // Employee class inherit from Person class
    public class Employee : Person
    {
        public double Salary { get; set; }

        public override void Display()
        {
            Console.WriteLine($"Employee - Name: {Name}, Age: {Age}, Address: {Address}, Salary: {Salary}");
        }
    }
}
