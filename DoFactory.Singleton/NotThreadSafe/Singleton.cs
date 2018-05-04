namespace DoFactory.Singleton.NotThreadSafe
{
    class Singleton
    {
        private static Singleton _instansce;

        private Singleton() { }

        public static Singleton SingleInstance
        {
            get
            {
                // Uses lazy initialization.
                // Note: this is not thread safe.
                if (_instansce == null)
                    _instansce = new Singleton();
                return _instansce;
            }
        }
    }
}
