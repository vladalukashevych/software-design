namespace ChainOfResponsibility.HandlerLibrary
{
    public class SecondHandler : SupportHandler
    {
        public override object Handle(object arg)
        {
            if ((int)arg != 2)
                return base.Handle(arg);

            return "Sales and revenue";
        }
    }
}
