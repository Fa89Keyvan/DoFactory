using System.Diagnostics;

namespace DoFactory.Facade.MortgageSubSystems
{
    class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Debug.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }

}
