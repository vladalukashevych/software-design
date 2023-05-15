using SolidPrinciplesConsoleApp.Money;
using static SolidPrinciplesConsoleApp.Enums;

namespace SolidPrinciplesConsoleApp.Products
{
    public class Instrument : Product, IInstrument
    {
        public InstrumentType Type { get; set; }
        public Instrument(string name, string producer, int quantity, Currency price, InstrumentType type)
            : base(name, producer, quantity, price)
        {
            Type = type;
        }
    }
}
