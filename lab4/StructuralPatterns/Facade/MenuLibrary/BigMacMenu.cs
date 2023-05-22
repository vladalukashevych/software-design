using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.MenuLibrary
{
    public class BigMacMenu
    {
        private Package _package;
        private Napkins _napkins;
        private TotalPrice _price;

        public BigMacMenu()
        {
            _package = new Package();
            _napkins = new Napkins(3);
            _price = new TotalPrice();
        }

        public void AddBigMac()
        {
            BigMac bigMac = new BigMac();
            _price.Add(bigMac.Price);
            Console.WriteLine($"Adding {bigMac.Name} for {bigMac.Price}$");
        }

        public void AddFrenchFries()
        {
            FrenchFries frenchFries = new FrenchFries();
            _price.Add(frenchFries.Price);
            Console.WriteLine($"Adding {frenchFries.Name} for {frenchFries.Price}$");
        }

        public void AddSprite()
        {
            Sprite sprite = new Sprite();
            _price.Add(sprite.Price);
            Console.WriteLine($"Adding {sprite.Name} for {sprite.Price}$");
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = _price.Number + _package.Price + _napkins.Price;
            Console.WriteLine($"\nTotal price: {totalPrice}");
            return totalPrice;
        }
    }
}
