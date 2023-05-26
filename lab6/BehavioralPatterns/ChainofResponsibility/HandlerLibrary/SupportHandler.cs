using ChainOfResponsibility.HandlerLibrary;

namespace ChainOfResponsibility
{
    public abstract class SupportHandler : IHandler
    {
        private SupportHandler? _next { get; set; }

        public virtual object Handle(object arg)
        {
            if (_next != null)
            {
                return _next.Handle(arg);
            }
            return -1;
        }

        public SupportHandler SetNext(SupportHandler next)
        {
            _next = next;
            return next;
        }
    }
}
