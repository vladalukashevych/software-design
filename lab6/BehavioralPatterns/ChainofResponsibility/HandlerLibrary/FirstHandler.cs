namespace ChainOfResponsibility.HandlerLibrary
{
    public class FirstHandler : SupportHandler
    {
        public override object Handle(object arg)
        {
            if ((int)arg != 1)
                return base.Handle(arg);

            return "Customer service";
        }
    }
}
