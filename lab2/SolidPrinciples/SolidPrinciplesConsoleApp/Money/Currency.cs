namespace SolidPrinciplesConsoleApp.Money
{
    public abstract class Currency
    {
        public int WholePart { get; private set; }
        public int FractionalPart { get; private set; }
        public abstract string Symbol { get; }
        public Currency(decimal number)
        {
            SetFractionalNumber(number);
        }
        public decimal GetFractionalNumber()
        {
            string number = $"{WholePart},{FractionalPart}";
            return decimal.Parse(number);
        }
        public void SetFractionalNumber(decimal number)
        {
            WholePart = (int)number;
            FractionalPart = (int)(number % 1 * 100);
        }
        public void SetWholePart(int number)
        {
            WholePart = number;
        }
        public void SetFractionalPart(int number)
        {
            FractionalPart = number;
        }
    }
}
