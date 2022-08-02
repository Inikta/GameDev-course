class Program
{
    static void Main(string[] args)
    {
        ComputerGames.MOBA moba = new ComputerGames.MOBA("League of Legends", 2009, 132, 5, "The main contender with DOTA");
        ComputerGames.Shooter shooter = new ComputerGames.Shooter("Battlefield 4", 2013, 16, 64, "Also known as BUGField 4");
        ComputerGames.Puzzle puzzle = new ComputerGames.Puzzle("Portal 2", 2011, 7, 64, "The best puzzle game I ever played");
        ComputerGames.RPG rpg = new ComputerGames.RPG("Fallout 4", 2015, "1st-person, 3d-person", 400, "Buy Skyr... I mean Fallout 4");
        ComputerGames.Strategy strategy = new ComputerGames.Strategy("Stellaris", 2016, "Far fantastic future", 20, "One of the cooles galactic empire simulators");

        Console.WriteLine("\t--= MOBA =--");
        moba.Message();

        Console.WriteLine("\t--= Shooter =--");
        shooter.Message();

        Console.WriteLine("\t--= RPG =--");
        rpg.Message();

        Console.WriteLine("\t--= Puzzle =--");
        puzzle.Message();


        Console.WriteLine("\t--= Strategy =--");
        strategy.Message();
    }
}
