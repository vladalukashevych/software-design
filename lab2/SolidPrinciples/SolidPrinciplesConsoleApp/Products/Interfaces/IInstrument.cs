using static SolidPrinciplesConsoleApp.Enums;

namespace SolidPrinciplesConsoleApp.Products
{
    public interface IInstrument : IProduct
    {
        InstrumentType Type { get; set; }
    }
}
