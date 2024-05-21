using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTx2_1.Model
{
    public class PartTimeEmployee : Employee
    {

        public double WorkingHours { get; set; }
        // Inherit and alternate abstract method CalculateSalary
        public override double CalculateSalary()
        {
            return WorkingHours * PaymentPerHour;
        }

        public override string ToString()
        {
            return $"Part-time Employee - {base.ToString()}, Working Hours: {WorkingHours}, Salary: {CalculateSalary()}";
        }
    }
}
