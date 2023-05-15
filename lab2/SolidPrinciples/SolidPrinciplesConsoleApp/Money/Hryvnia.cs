namespace SolidPrinciplesConsoleApp.Money
{
    public class Hryvnia : Currency
    {
        public override string Symbol { get { return "₴"; } }
        public Hryvnia(decimal number) : base(number) { }
    }
}
