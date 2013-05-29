using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPNowel.Model;
namespace TPNowel.Business
{
    public class ProductBusiness 
    {
        public List<Product> Products { get; set; }

        public ProductBusiness ()
	    {
            this.Products = new List<Product>();
	    }

        public void InitializeProducts()
        {
            this.Products.Add(new Product()
            {
                Label = "Toto",
                Price = 3.76M
            });
        }
    }
}
