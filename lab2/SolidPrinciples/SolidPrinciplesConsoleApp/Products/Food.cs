using SolidPrinciplesConsoleApp.Money;
using SolidPrinciplesConsoleApp.Products.Interfaces;

namespace SolidPrinciplesConsoleApp.Products
{
    //Interface Segregation Principle

    //Interface IProduct has only absolute general properties and methods,
    //so the implementation classes won't be forced to implement what they
    //can't do. As it can be seen here, method NotExpired was not written
    //in IProduct, where class Instrument won't be able to implement it.
    //So IFood was used for it.

    public class Food : Product, IFood
    {
        public DateTime ExpirationDate { get; set; }
        public Food(string name, string producer, int quantity, Currency price, DateTime expirationDate)
            : base(name, producer, quantity, price)
        {
            ExpirationDate = expirationDate;
        }

        public bool NotExpired()
        {
            return DateTime.Now < ExpirationDate;
        }
    }
}
