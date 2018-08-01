namespace DoFactory.Facade
{
    using System;
    using MortgageSubSystems;
    class Program
    {
        static void Main(string[] args)
        {
            MortgageService mortgageService = new MortgageService();

            Customer customer = new Customer("Sam");

            bool eligible = mortgageService.IsEligible(customer, 2500000);

            Console.WriteLine($"{customer.Name} has been " + (eligible ? "Approved" : "Rejected"));

            Console.ReadKey();
        }
    }
}
