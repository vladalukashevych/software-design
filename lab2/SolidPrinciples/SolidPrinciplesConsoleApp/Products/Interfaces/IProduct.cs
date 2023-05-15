using SolidPrinciplesConsoleApp.Money;

namespace SolidPrinciplesConsoleApp.Products
{
    //Open Closed

    //All product items implement this interface and extend it with needed
    //properties and methods without having any need to modificate this exact class.
    //Going into detail, we will won't need to specify each product type in methods and
    //others in Warehouse.cs on its own as they all will be IProduct implemention.

    public interface IProduct
    {
        Currency? Price { get; set; }
        string Name { get; set; }
        string Producer { get; set; }
        int Quantity { get; set; }
        void ChangePrice(decimal number);
        void ReducePrice(decimal number);
        void ChangeQuantityBy(int quantity);
    }
}
