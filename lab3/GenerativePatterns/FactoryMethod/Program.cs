using FactoryMethod;
using FactoryMethod.Applications;
using FactoryMethod.Subscriptions;

IApplication application = new WebSite();
ISubscription subscription = application.GetSubscription();
Console.WriteLine("\n Subscription you've just got: \n");
Helper.PrintSubscription(subscription);