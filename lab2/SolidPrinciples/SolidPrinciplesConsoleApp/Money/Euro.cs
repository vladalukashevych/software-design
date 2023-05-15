namespace SolidPrinciplesConsoleApp.Money
{
    public class Euro : Currency
    {
        public override string Symbol { get { return "€"; } }

        public Euro(decimal number) : base(number) { }
    }
}
