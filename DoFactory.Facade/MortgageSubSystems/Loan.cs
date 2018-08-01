using System.Diagnostics;

namespace DoFactory.Facade.MortgageSubSystems
{
    class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Debug.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }
}
