using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }

        public Product Retrieve(int productId)
        {
            // Code that retrieves the defined product

            return new Product();
        }
        public bool Save()
        {
            // Code that saves the defined product

            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}

