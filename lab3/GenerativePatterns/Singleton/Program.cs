using Singleton;

Thread t1 = new Thread(() =>
{
    var instance = DatabaseRepository.Instance(1);
});

Thread t2 = new Thread(() =>
{
    var instance = DatabaseRepository.Instance(2);
});

t1.Start();
t2.Start();

t1.Join();
t2.Join();

Console.WriteLine(DatabaseRepository.Instance(3).Id);
