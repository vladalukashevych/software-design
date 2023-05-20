
namespace AbstractFactory
{
    public static class EnumsPrinter
    {
        public static string ToString(List<ItemColor> options)
        {
            string output = "";
            foreach (var c in options)
            {
                output += $"{c}";
                if (!c.Equals(options[options.Count - 1]))
                    output += ", ";
            }
            return output;
        }

        public static string ToString(List<LeatherType> options)
        {
            string output = "";
            foreach (var c in options)
            {
                output += $"{c}";
                if (!c.Equals(options[options.Count - 1]))
                    output += ", ";
            }
            return output;
        }
    }
}
