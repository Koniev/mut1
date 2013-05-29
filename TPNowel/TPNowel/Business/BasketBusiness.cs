using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TPNowel.Model;

namespace TPNowel.Business
{
    public class BasketBusiness
    {
        public delegate decimal CalculPrice(List<ProductBasket> productsList);
        public List<ProductBasket> Basket { get; set; }

        public decimal GetTotalPrice()
        {
            CalculPrice c = (list) =>
                {
                    decimal price = 0;
                    foreach (var product in list)
                    {
                        price += product.Price;
                    }
                    return price;
                };

            return c(this.Basket);
        }

        public void GetProductsInBasket()
        {
        }
        public void AddProductToBasket()
        {
        }
        public void ClearBasket()
        {
        }
    }
}
