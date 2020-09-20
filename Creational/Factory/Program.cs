using System;
using Factory.FactoryMethod;
using Factory.InternalFactory;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            // FACTORY METHOD
            var programer = Employee.CreateProgramer("Adam", "Smith");
            var headOfFinance = Employee.CreateHeadOfDepartment("Megan", "Harrison");

            Console.WriteLine(programer);
            Console.WriteLine(headOfFinance);

            // INNER FACTORY

            var pln = Money.Factory.PLN(100);
            var usd = Money.Factory.USD(200);

            Console.WriteLine(pln);
            Console.WriteLine(usd);
        }
    }
}
