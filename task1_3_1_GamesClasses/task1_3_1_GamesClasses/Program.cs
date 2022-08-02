

class Program
{
    static void Main(string[] args)
    {
        computer_games.MOBA moba = new computer_games.MOBA("League of Legends", 2009, 132, 5, "The main contender with DOTA");
        computer_games.Shooter shooter = new computer_games.Shooter("Battlefield 4", 2013, 16, 64, "Also known as BUGField 4");
        computer_games.Puzzle puzzle = new computer_games.Puzzle("Portal 2", 2011, 7, 64, "The best puzzle game I ever played");
        computer_games.RPG rpg = new computer_games.RPG("Fallout 4", 2015, "1st-person, 3d-person", 400, "Buy Skyr... I mean Fallout 4");
        computer_games.Strategy strategy = new computer_games.Strategy("Stellaris", 2016, "Far fantastic future", 20, "One of the cooles galactic empire simulators");

        Console.WriteLine("\t--= MOBA =--");
        moba.message();

        Console.WriteLine("\t--= Shooter =--");
        shooter.message();

        Console.WriteLine("\t--= RPG =--");
        rpg.message();

        Console.WriteLine("\t--= Puzzle =--");
        puzzle.message();


        Console.WriteLine("\t--= Strategy =--");
        strategy.message();
    }
}
