using SolidPrinciplesConsoleApp.Money;

namespace SolidPrinciplesConsoleApp.Products
{
    // Liskov Substitution Principle

    // All written extencions of this class do not
    // argue with its logics and are substitutable.

    public class Product : IProduct
    {
        public string Name { get; set; }
        public string Producer { get; set; }
        public int Quantity { get; set; }
        public Currency? Price { get; set; }

        public Product(string name, string producer, int quantity, Currency? price)
        {
            Name = name;
            Producer = producer;
            Quantity = quantity;
            Price = price;
        }

        public void ChangePrice(decimal amount)
        {
            if (Price != null)
                Price.SetFractionalNumber(amount);
        }

        public void ReducePrice(decimal amount)
        {
            if (Price != null)
            {
                decimal newPrice = Price.GetFractionalNumber() - amount;
                Price.SetFractionalNumber(newPrice);
            }
        }

        public void ChangeQuantityBy(int quantity)
        {
            Quantity += quantity;
        }
    }
}
