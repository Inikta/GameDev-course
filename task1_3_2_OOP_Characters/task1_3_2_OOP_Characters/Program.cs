namespace task1_3_2_OOP_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Character[] characters = {
                new Player("FuBar", Sex.MAN, "Human", 19, 1, "Best player in da world", "Nikita", 1),
                new Peasant("Bob", Sex.MAN, "Human", 36, 4, "Regular peasant", "Kaedwen", "Richard II"),
                new Knight("Alexander Black Jr", Sex.MAN, "Human", 28, 9, "Brave knight", "Temeria", 6)
            };

            Enemy[] enemies = {
                new Bandit("Grok Blackbeard", Sex.MAN, "Kadjit", 33, 10, "Black buckaneers", 555),
                new OrcBoyz("Mork", Sex.MAN, "Orc", 18, 6, "DA RED GOEZ FASTA", 16),
                new Dragon("Aldringel", Sex.WOMAN, "Ancient Dragon", 786, 96, "UNKNOWN", 100000000)
            };

            Console.WriteLine("Characters");
            foreach(Character character in characters)
            {
                character.Message();
                Console.WriteLine("---");
            }

            Console.WriteLine("\nEnemies");
            foreach (Enemy enemy in enemies)
            {
                enemy.Message();
                Console.WriteLine("---");
            }

        }
    }
}