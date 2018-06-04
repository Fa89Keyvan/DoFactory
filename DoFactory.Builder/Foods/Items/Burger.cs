using DoFactory.Builder.Foods.Packings;

namespace DoFactory.Builder.Foods.Items
{
    abstract class Burger : Item
    {
        public abstract string GetName();

        public Packing GetPackingMethod() => new Wrapper();

        public abstract float GetPrice();
    }
}
