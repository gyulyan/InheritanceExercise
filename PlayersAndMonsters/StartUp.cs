using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Hero hero = new Hero("Taki", 3);
            Console.WriteLine(hero);

        }
    }
}