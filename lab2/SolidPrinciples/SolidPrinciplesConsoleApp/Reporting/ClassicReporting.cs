using SolidPrinciplesConsoleApp.Products;

namespace SolidPrinciplesConsoleApp.Reporting
{
    public class ClassicReporting : IReporting
    {        
        private const string horizontalBorder = "------------------------------------------------------------\n";
        private string TableHeader
        {
            get
            {
                return
                    horizontalBorder +
                    "|          Name |      Producer | Quantity |         Price |\n" +
                horizontalBorder;
            }
        }

        private void ReleaseReport(List<IProduct> products, string header)
        {
            string output =
                    horizontalBorder +
                    $"|       {header,-30} {DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")} |\n" +
                    TableHeader;
            decimal total = 0;

            foreach (IProduct product in products)
            {
                output += $"|{product.Name,15} {product.Producer,15} {product.Quantity,10} {product.Price!.GetFractionalNumber(),10} {product.Price!.Symbol,4}|\n";

                total += product.Price.GetFractionalNumber() * product.Quantity;
            }
            total = Math.Round(total, 2);

            output += horizontalBorder;
            output += $"|         Total:                             {total,10}   {products[0].Price.Symbol}|\n";
            output += horizontalBorder;

            Console.WriteLine(output);
            Console.WriteLine("\n\n");
        }

        public void ReleaseInventaryReport(List<IProduct> products)
        {
            ReleaseReport(products, "Inventary Report");
        }

        public void ReleaseSalesInvoice(List<IProduct> products)
        {
            ReleaseReport(products, "Sales Invoice");
        }

        public void ReleasePurchaseInvoice(List<IProduct> products)
        {
            ReleaseReport(products, "Purchase Invoice");
        }
    }
}
