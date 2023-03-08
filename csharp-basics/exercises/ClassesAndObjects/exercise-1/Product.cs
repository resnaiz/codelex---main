using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_1
{
    internal class Product
    {
        double price { get; set; }
        int amount { get; set; }
        string name { get; set; }

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            this.price = priceAtStart;
            this.amount = amountAtStart;
            this.name = name;
        }

        public void PrintProduct()
        {
            string printedText = string.Format("{0}, price {1}, amount {2}", name, price, amount);
            Console.WriteLine(printedText);
        }

        public void AmountChange(int newAmount)
        {
            amount = newAmount;
        }

        public void PriceChanged(double newPrice)
        {
            price = newPrice;
        }
    }
}
