namespace DoFactory.Builder.Foods.Items
{
    using Packings;
    interface Item
    {
        string GetName();
        Packing GetPackingMethod();
        float GetPrice();
    }
}
