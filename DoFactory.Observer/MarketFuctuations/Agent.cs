using System.Collections.Generic;
using System.Diagnostics;

namespace DoFactory.Observer.MarketFuctuations
{
    class Agent
    {
        private List<Product> _lstPorducts = new List<Product>();

        public void AddProduct(Product product)
        {
            product.OnChangedPrice += this.Product_OnChangedPrice;
            _lstPorducts.Add(product);
        }

        private void Product_OnChangedPrice(object sender, ChangedPriceEventArgs changedPriceEventArgs)
        {
            Debug.WriteLine($"Product {changedPriceEventArgs.ProductName} price changes to {changedPriceEventArgs.NewPrice}");
        }
    }
}
