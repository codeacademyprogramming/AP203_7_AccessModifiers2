using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    public class Store
    {
        public Store(int limit)
        {
            this.Products = new Product[0];
            this.ProductLimit = limit;
        }
        public int ProductLimit { get; set; }
        public string Name { get; set; }
        public int WorkerCount { get; set; }

        public Product[] Products;

        public void AddProduct(Product product)
        {
            if (this.Products.Length == this.ProductLimit)
                throw new Exception("Product limit doldu!");

            Array.Resize(ref Products, this.Products.Length+1);
            this.Products[this.Products.Length-1] = product;    
        }
    }
}
