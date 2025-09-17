using System.Security.Cryptography;

namespace MonsterGen;

class Program
{
    public class Monster()
    {
        public int atk;
        public int hp;
        public string name;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the monsterGen");
    }


    public void MonsterGenerator()
    {
        Random rnd = new Random();
        string[] monstersN = { "Bronzor", "Chramander", "gible", "Frog" };
        int Names = rnd.Next(monstersN.Length);
    }


}
