using System.Linq;
using task1_3_2_OOP_Characters;

class Program
{
    static void Main(string[] args)
    {
        DictionaryTask();
        Console.WriteLine("-----------");
        LinkedListTask(45, 44, 50);
    }

    private static void DictionaryTask()
    {
        Dictionary<string, Character> characterList = new Dictionary<string, Character>();
        characterList.Add("FuBar", new Player("FuBar", Sex.MAN, "Human", 19, 1, "Best player in da world", "Nikita", 1));
        characterList.Add("Bob", new Peasant("Bob", Sex.MAN, "Human", 36, 4, "Regular peasant", "Kaedwen", "Richard II"));
        characterList.Add("Alexander", new Knight("Alexander Black Jr", Sex.MAN, "Human", 28, 9, "Brave knight", "Temeria", 6));

        foreach (KeyValuePair<string, Character> pair in characterList)
        {
            Console.WriteLine($"Key: {pair.Key}");
            Console.WriteLine($"Value: {pair.Value}");
        }
    }

    private static void LinkedListTask(int hp1, int hp2, int hp3)
    {
        LinkedList<Enemy> enemyList = new LinkedList<Enemy>();
        enemyList.AddLast(new Bandit("Grok Blackbeard", Sex.MAN, "Kadjit", 33, 10, hp1, "Black buckaneers", 555));
        enemyList.AddLast(new OrcBoyz("Mork", Sex.MAN, "Orc", 18, 6, hp2, "DA RED GOEZ FASTA", 16));
        enemyList.AddLast(new Dragon("Aldringel", Sex.WOMAN, "Ancient Dragon", 786, 96, hp3, "UNKNOWN", 100000000));

        bool death = false;

        while (!death)
        {
            foreach(Enemy enemy in enemyList)
            {
                enemy.currentHP -= 2;
                Console.WriteLine($"{enemy} HP: {enemy.currentHP} / {enemy._maxHealthPoints}");

                if (enemy.currentHP <= 0)
                {
                    death = true;
                }
            }
            Console.WriteLine();
        }

        Console.WriteLine("Dead:");

        foreach (Enemy enemy in enemyList)
        {
            if (enemy.currentHP <= 0)
            {
                Console.WriteLine($"{enemy} is dead.");
            }
        }
        Console.WriteLine();

        Enemy aliveEnemy = enemyList.MaxBy(keySelector: (Enemy e) => e.currentHP);

        if (aliveEnemy == null)
        {
            Console.WriteLine("No one has survived!");
        } else
        {
            Console.WriteLine("Most powerful alive:");
            Console.WriteLine($"{aliveEnemy} : {aliveEnemy.currentHP} / {aliveEnemy._maxHealthPoints}");
        }
    }
}
