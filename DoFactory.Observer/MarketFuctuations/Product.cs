using System;
using System.Collections.Generic;
using System.Text;

namespace DoFactory.Observer.MarketFuctuations
{
    public class ChangedPriceEventArgs
    {
        public string ProductName { get; set; }
        public decimal NewPrice { get; set; }
    }
    abstract class Product
    {
        private decimal _price;

        public  delegate void ChangePrice(object sender,ChangedPriceEventArgs changedPriceEventArgs);
        public  event ChangePrice OnChangedPrice;

        public Product(decimal price)
        {
            this._price = price;
        }

        public decimal Price
        {
            get => this._price;
            set
            {
                this._price = value;
                OnChangedPrice(null,new ChangedPriceEventArgs { ProductName = this.ProductName, NewPrice = value });
            }
        }
        public int ID { get; set; }
        public string ProductName { get; set; }
    }
}
