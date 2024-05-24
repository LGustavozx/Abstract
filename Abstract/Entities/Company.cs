using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            return (NumberOfEmployees > 10) ? AnnualIncome * 0.14 : AnnualIncome * 0.16;
        }
    }
}
