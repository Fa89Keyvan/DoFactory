using System.Collections.Generic;

namespace DoFactory.Builder.Foods
{
    using Items;
    using System.Diagnostics;

    class Meal
    {
        private List<Item> _items = new List<Item>();
        private float _totalCost = 0;
        public void AddItem(Item item) => _items.Add(item);

        public float CalculateCost()
        {
            _totalCost = 0;
            _items.ForEach((item) => { _totalCost += item.GetPrice(); });
            return _totalCost;
        }

        public void ShowItems() => _items.ForEach((item)=> { Debug.WriteLine($"item: {item.GetName()}, packing: {item.GetPackingMethod().Pack()}, price: {item.GetPrice()}"); });
    }
}
