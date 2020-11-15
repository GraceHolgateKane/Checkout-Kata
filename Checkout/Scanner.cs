using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Zen.Checkout
{
    public class Scanner
    {
        private int countA;
        private int discountA = 3;
        private int discountA_value = 5;

        private int countB;
        private int discountB = 2;
        private int discountB_value = 10;

        private List<Product> basket = new List<Product>();
        public void Scan(Product product)
        {
            if (product != null) {
                basket.Add(product);
            }
        }

        public int GetTotal() {

            var total = 0;

            foreach (var product in basket) {
                if (product.Name == "productA")
                {
                    countA++;
                    if (countA == discountA)
                    {
                        total = total - discountA_value;
                        countA = 0;
                    }
                }
                if (product.Name == "productB")
                {
                    countB++;
                    if (countB == discountB)
                    {
                        total = total - discountB_value;
                        countB = 0;
                    }
                }

                total = total + product.Price;
            }
            return total;
        }

    }
}
