using OOPTx2_1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTx2_1.Model
{
    public abstract class Employee : IEmployee
    {
        public string Name { get; set; }
        public double PaymentPerHour { get; set; }

        public abstract double CalculateSalary();

        public override string ToString()
        {
            return $"Name: {Name}, Payment Per Hour: {PaymentPerHour}";
        }
    }
}
