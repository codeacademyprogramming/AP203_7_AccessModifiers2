using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Product
    {
        private double _price;
        public string Name { get; set; }
        public double Price {
            get => this._price;
            set
            {
                if (value >= 0)
                    this._price = value;
            }
        }
        public string Category { get; set; }
    }
}
