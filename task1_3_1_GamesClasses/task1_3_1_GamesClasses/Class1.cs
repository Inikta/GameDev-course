
namespace computer_games
{
    class MOBA
    {
        private string name;

        public string description;

        private int year;

        private int amountOfCharacters;

        private int teamSize;

        public MOBA(
            string name,
            int year,
            int amountOfCharacters,
            int teamSize,
            string description)
        {
            this.name = name;
            this.year = year;
            this.amountOfCharacters = amountOfCharacters;
            this.teamSize = teamSize;
            this.description = description;
        }
        public void message() 
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Amount of characters: " + amountOfCharacters);
            Console.WriteLine("Size of team: " + teamSize);
            Console.WriteLine("Description: " + description);
        }
    }

    internal class Shooter
    {
        private string name;

        public string description;

        private int year;

        private int amountOfGunTypes;

        private int teamSize;

        public Shooter(
            string name,
            int year,
            int amountOfGunTypes,
            int teamSize,
            string description)
        {
            this.name = name;
            this.year = year;
            this.amountOfGunTypes = amountOfGunTypes;
            this.teamSize = teamSize;
            this.description = description;
        }
        public void message()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Amount of gun types: " + amountOfGunTypes);
            Console.WriteLine("Size of team: " + teamSize);
            Console.WriteLine("Description: " + description);
        }
    }

    internal class RPG
    {
        private string name;

        public string description;

        private int year;

        private string view;

        private int hoursToComplete;

        public RPG(
            string name,
            int year,
            string view,
            int hoursToComplete,
            string description)
        {
            this.name = name;
            this.year = year;
            this.view = view;
            this.hoursToComplete = hoursToComplete;
            this.description = description;
        }
        public void message()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("View: " + view);
            Console.WriteLine("Hours to complete: " + hoursToComplete);
            Console.WriteLine("Description: " + description);
        }
    }

    internal class Puzzle
    {
        private string name;

        public string description;

        private int year;

        private int complexityRating;

        private int amountOfLevels;

        public Puzzle(
            string name,
            int year,
            int complexityRating,
            int amountOfLevels,
            string description)
        {
            this.name = name;
            this.year = year;
            this.complexityRating = complexityRating;
            this.amountOfLevels = amountOfLevels;
            this.description = description;
        }
        public void message()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Complexity rating: " + complexityRating);
            Console.WriteLine("Amount of levels: " + amountOfLevels);
            Console.WriteLine("Description: " + description);
        }
    }

    internal class Strategy
    {
        private string name;

        public string description;

        private int year;

        private string historicalPeriod;

        private int amountOfRivals;

        public Strategy(
            string name,
            int year,
            string historicalPeriod,
            int amountOfRivals,
            string description)
        {
            this.name = name;
            this.year = year;
            this.historicalPeriod = historicalPeriod;
            this.amountOfRivals = amountOfRivals;
            this.description = description;
        }
        public void message()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Hsitorical period: " + historicalPeriod);
            Console.WriteLine("Maximal amount of rivals: " + amountOfRivals);
            Console.WriteLine("Description: " + description);
        }
    }
}
