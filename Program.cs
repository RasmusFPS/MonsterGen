using System.Diagnostics;
using System.Security.Cryptography;

namespace MonsterGen;

class Program
{
    class Monster()
    {
        public int atk;
        public int hp;
        public string name;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the monsterGen \nDo you want to create a monster [Y/n]");
        string input = Console.ReadLine().ToLower();
        if (input != "y")
        {
            return;
        }
        else
        {
            MonsterGenerator();
        }

    }


    public static void MonsterGenerator()
    {
        Random rnd = new Random();
        string[] monstersN = { "Bronzor", "Chramander", "gible", "Frog" };
        int Names = rnd.Next(monstersN.Length);
        int atk = rnd.Next(1, 10);
        int hp = rnd.Next(10, 50);
        string name = monstersN[Names];

        Console.WriteLine($"Name:{name}");
        Console.WriteLine($"HP:{hp}");
        Console.WriteLine($"ATK:{atk}");

    }

    public static void Attack()
    {
        
    }


}
