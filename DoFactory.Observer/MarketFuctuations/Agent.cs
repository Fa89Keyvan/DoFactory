using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

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

        private void Product_OnChangedPrice(Product product)
        {
            Debug.WriteLine($"Product {product.ID} price changes to {product.Price}");
        }
    }
}
