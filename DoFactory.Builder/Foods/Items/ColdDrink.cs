using DoFactory.Builder.Foods.Packings;

namespace DoFactory.Builder.Foods.Items
{
    abstract class ColdDrink : Item
    {
        public abstract string GetName();

        public Packing GetPackingMethod() => new Bottle();

        public abstract float GetPrice();
    }
}
