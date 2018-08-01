using System.Diagnostics;

namespace DoFactory.Facade.MortgageSubSystems
{
    class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Debug.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }
}
