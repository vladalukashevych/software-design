using FactoryMethod.Subscriptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Applications
{
    public interface IApplication
    {
        public ISubscription GetSubscription();
    }
}
