using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double annualIncome, double healthExpenditures) : base(name, annualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = (AnnualIncome < 20000.0) ? AnnualIncome * 0.15 : AnnualIncome * 0.25;
            if (HealthExpenditures > 0)
            {
                tax -= HealthExpenditures * 0.5;
            }
            return (tax < 0) ? 0 : tax;
        }
    }
}
