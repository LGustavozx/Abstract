using System;
using System.Collections.Generic;
using System.Globalization;
using Abstract.Entities;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            List<TaxPayer> taxPayers = new List<TaxPayer>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayers.Add(new Individual(name, annualIncome, healthExpenditures));
                }
                else if (type == 'c')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    taxPayers.Add(new Company(name, annualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine("\nTAXES PAID:");
            double totalTaxes = 0.0;
            foreach (TaxPayer taxPayer in taxPayers)
            {
                double tax = taxPayer.Tax();
                totalTaxes += tax;
                Console.WriteLine($"{taxPayer.Name}: $ {tax.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine($"\nTOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}