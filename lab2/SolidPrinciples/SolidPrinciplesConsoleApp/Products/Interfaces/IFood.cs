namespace SolidPrinciplesConsoleApp.Products.Interfaces
{
    internal interface IFood : IProduct
    {
        public DateTime ExpirationDate { get; set; }
        bool NotExpired();
    }
}
