using SolidPrinciplesConsoleApp.Products;

namespace SolidPrinciplesConsoleApp.Reporting
{
    public interface IReporting
    {
        void ReleasePurchaseInvoice(List<IProduct> products);
        void ReleaseSalesInvoice(List<IProduct> products);
        void ReleaseInventaryReport(List<IProduct> products);
    }
}
