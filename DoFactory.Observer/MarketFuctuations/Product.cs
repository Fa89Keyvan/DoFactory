using System;
using System.Collections.Generic;
using System.Text;

namespace DoFactory.Observer.MarketFuctuations
{
    class Product
    {
        private decimal _price;

        public  delegate void ChangePrice(Product product);
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
                OnChangedPrice(this);
            }
        }
        public int ID { get; set; }
    }
}
