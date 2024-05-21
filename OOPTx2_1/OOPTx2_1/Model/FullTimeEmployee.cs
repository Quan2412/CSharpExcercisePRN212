using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTx2_1.Model
{
    public class FullTimeEmployee : Employee
    {
        // Inherit and alternate abstract method CalculateSalary
        public override double CalculateSalary()
        {
            return 8 * PaymentPerHour;
        }

        public override string ToString()
        {
            return $"Full-time Employee - {base.ToString()}, Salary: {CalculateSalary()}";
        }
    }
}
