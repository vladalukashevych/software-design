using SolidPrinciplesConsoleApp.Products;

namespace SolidPrinciplesConsoleApp.Warehouse
{
    //Single Responsibility

    //This class has only one responsibility and it is to store and manage products and
    //is not filled with excessive functionality such as releasing reports on invoices or etc.

    public class Warehouse : IWarehouse
    {
        public List<IProduct> Products { get; set; }

        public Warehouse(List<IProduct> products)
        {
            Products = products;
        }

        public void AddProducts(List<IProduct> products)
        {
            foreach (var item in products)
                AddProduct(item);
        }

        public void AddProduct(IProduct product)
        {
            int index = Products.FindIndex(g => g.Name == product.Name && g.Producer == product.Producer);
            if (index >= 0)
                Products[index].ChangeQuantityBy(product.Quantity);
            else
                Products.Add(product);
        }

        public void RemoveProducts(List<IProduct> products)
        {
            foreach (var item in products)
                RemoveProduct(item);
        }

        public void RemoveProduct(IProduct product)
        {
            int index = Products.FindIndex(g => g.Name == product.Name && g.Producer == product.Producer);
            if (index >= 0)
            {
                Products[index].ChangeQuantityBy(-product.Quantity);
                if (Products[index].Quantity == 0)
                    Products.RemoveAt(index);
            }
        }
    }
}
