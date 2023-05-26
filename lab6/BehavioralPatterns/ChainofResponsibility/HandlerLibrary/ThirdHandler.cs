namespace ChainOfResponsibility.HandlerLibrary
{
    public class ThirdHandler : SupportHandler
    {
        public override object Handle(object arg)
        {
            if ((int)arg != 3)
                return base.Handle(arg);

            return "Security support";
        }
    }
}
