using System;
using System.Collections.Generic;

namespace SimpleEcommerce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the simple Ecommerce Store");

            var tshirt = new Product() { SKU = "001", Name = "T-Shirt", Price = 19.99M, };
            var jumper = new Product() { SKU = "002", Name = "Jumper", Price = 49.99M, };
            var shoes = new Product() { SKU = "003", Name = "Shoes", Price = 99.00M, };

            Console.WriteLine("Adding products to Basket");

            var basket = new Basket();
            basket.AddProducts(new List<Product> {  tshirt, tshirt, jumper });

            var amount = basket.CalculateTotal();

            var paymentMethod = new Cash();
            var result = paymentMethod.Pay(amount);
            if (result)
            {
                Console.WriteLine($"{amount} successfully paid with Cash");
            }
            else
            {
                Console.WriteLine($"Cash payment is not allowed");
            }

            Console.ReadLine();
        }
    }
}
