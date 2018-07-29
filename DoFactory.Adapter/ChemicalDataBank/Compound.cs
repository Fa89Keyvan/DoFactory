using System.Diagnostics;

namespace DoFactory.Adapter.ChemicalDataBank
{
    /// <summary>
    /// The Target class
    /// </summary>
    public class Compound
    {
        protected string _chemical;
        protected float  _boilingPoint;
        protected float  _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        public Compound(string chemical)
        {
            this._chemical = chemical;
        }

        public virtual void Display()
        {
            Debug.WriteLine($"\nCompound: {_chemical} ------ ");
        }
    }
}
