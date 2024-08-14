using System;

namespace DesignPatterns.Singleton
{
    // Singleton tasarım kalıbı örneği
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private static readonly object _lock = new object();

        // Özel constructor - dışarıdan erişilemez
        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                // Çoklu iş parçacığı ortamında güvenli bir şekilde Singleton nesnesi oluşturma
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                    return _instance;
                }
            }
        }

        // Singleton sınıfının işlevleri
        public void DoSomething()
        {
            Console.WriteLine("Singleton instance is doing something!");
        }
    }
}
