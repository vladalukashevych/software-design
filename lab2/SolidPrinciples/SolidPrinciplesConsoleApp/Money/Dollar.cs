namespace SolidPrinciplesConsoleApp.Money
{
    public class Dollar : Currency
    {
        public override string Symbol { get { return "$"; } }
        public Dollar(decimal number) : base(number) { }

    }
}
