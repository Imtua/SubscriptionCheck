using System;

namespace SF_M12_1
{
    internal class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
        public User() { }
        public User(string login, string name, bool subscription)
        {
            Login = login;
            Name = name;
            IsPremium = subscription;
        }

        public static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда");
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум подписку на наш сервис, чтобы не видеть рекламу!");
            Thread.Sleep(3000);
        }
    }
}
