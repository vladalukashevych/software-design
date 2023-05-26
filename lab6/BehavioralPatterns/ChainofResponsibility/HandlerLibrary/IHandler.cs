namespace ChainOfResponsibility.HandlerLibrary
{
    public interface IHandler
    {
        public object Handle(object arg);
        public SupportHandler SetNext(SupportHandler handler);
    }
}
