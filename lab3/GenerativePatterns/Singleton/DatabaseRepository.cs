namespace Singleton
{
    sealed public class DatabaseRepository
    {
        private DatabaseRepository() { }

        public int Id { get; private set; }

        private static DatabaseRepository? _instance;
        private static readonly object _lock = new object();

        public static DatabaseRepository Instance(int id)
        {
            if (_instance == null)
            {                
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DatabaseRepository();
                        _instance.Id = id;
                    }
                }
            }

            return _instance;
        }
    }
}