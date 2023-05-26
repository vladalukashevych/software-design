namespace ChainOfResponsibility.HandlerLibrary
{
    public class FourthHandler : SupportHandler
    {
        public override object Handle(object arg)
        {
            if ((int)arg != 4)
                return base.Handle(arg);

            return "Administration support";
        }
    }
}
