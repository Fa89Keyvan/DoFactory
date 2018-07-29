namespace DoFactory.Adapter
{
    using ChemicalDataBank;
    class Program
    {
        static void Main(string[] args)
        {
            Compound compound = new RichCompound("WATER");

            compound.Display();
        }
    }
}
