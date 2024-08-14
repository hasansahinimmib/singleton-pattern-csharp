using System;

namespace DesignPatterns.Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Singleton örneğine erişim
            Singleton instance1 = Singleton.Instance;
            Singleton instance2 = Singleton.Instance;

            // İki örneğin aynı olup olmadığını kontrol et
            if (instance1 == instance2)
            {
                Console.WriteLine("Both instances are the same.");
            }

            // Singleton örneği ile bir şeyler yap
            instance1.DoSomething();
        }
    }
}
