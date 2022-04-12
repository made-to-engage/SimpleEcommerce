using System.Collections.Generic;

namespace SimpleEcommerce
{
    public class Basket
    {
        private List<Product> _products;

        public Basket()
        {
            _products = new List<Product>();
        }

        public void AddProducts(List<Product> products)
        {
            _products.AddRange(products);
        }

        public decimal CalculateTotal()
        {
            decimal totalPrice = 0;
            foreach(var product in _products)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }
    }
}