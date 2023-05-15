using SolidPrinciplesConsoleApp.Products;

namespace SolidPrinciplesConsoleApp.Warehouse
{
    public interface IWarehouse
    {
        List<IProduct> Products { get; set; }

        void AddProducts(List<IProduct> products);
        void AddProduct(IProduct product);
        void RemoveProducts(List<IProduct> products);
        void RemoveProduct(IProduct product);        
    }
}
