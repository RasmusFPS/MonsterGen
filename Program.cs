using System.Diagnostics;
using System.Security.Cryptography;

namespace MonsterGen;

class Program
{

    static void Main(string[] args)
    {
        var monster1 = CreateMonster();
        var monster2 = CreateMonster();

        Console.WriteLine($"Name:{monster1.name} \natk:{monster1.atk} \nhp:{monster1.hp}");
        Console.WriteLine($"Name:{monster2.name} \natk:{monster2.atk} \nhp:{monster2.hp}");



        Attack(monster1.name, monster1.atk);
        Console.WriteLine();
        Attack(monster2.name, monster2.atk);

    }

    static (string name, int atk, int hp) CreateMonster()
    {
        Random rnd = new Random();
        string[] Monsternames = { "slog", "cho", "chud", "gall", "Murky", "Bronzer" };
        int Nameindex = rnd.Next(Monsternames.Length);
        string name = Monsternames[Nameindex];
        int atk = rnd.Next(1, 10);
        int hp = rnd.Next(10, 100);
        return (name, atk, hp);
    }

    static void Attack(string name, int atk)
    {
        Random random = new Random();
        int dmg = random.Next(0, atk);

        if (dmg == 0)
        {
            Console.WriteLine($"Monster {name}! Missed!");
        }
        else
        {
            Console.WriteLine($"Monster {name}! Does {dmg} Damage!");
        }
    }
}
