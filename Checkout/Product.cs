using System;

namespace Zen.Checkout
{
    public class Product
    {
        public string Name;
        public int Price;

        public Product(string N, int P) {
            Name = N;
            Price = P;
        }
    }
}
