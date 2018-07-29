using System.Diagnostics;

namespace DoFactory.Adapter.ChemicalDataBank
{
    public class RichCompound : Compound
    {
        //The adaptee
        private ChemicalDatabank _chemicalDatabank;

        /// <summary>
        /// The Adapter class
        /// </summary>
        /// <param name="chemical"></param>
        public RichCompound(string chemical) : base(chemical)
        {
            _chemicalDatabank = new ChemicalDatabank();
        }

        public override void Display()
        {
            _boilingPoint     = _chemicalDatabank.GetCriticalPoint(_chemical, "B");
            _meltingPoint     = _chemicalDatabank.GetCriticalPoint(_chemical, "M");
            _molecularFormula = _chemicalDatabank.GetMolecularStructure(_chemical);
            _molecularWeight  = _chemicalDatabank.GetMolecularWeight(_chemical);

            base.Display();
            Debug.WriteLine($" Formula: {_molecularFormula}");
            Debug.WriteLine($" Weight : {_molecularWeight}");
            Debug.WriteLine($" Melting Pt: {_meltingPoint}");
            Debug.WriteLine($" Boiling Pt: {_boilingPoint}");
        }
    }
}
