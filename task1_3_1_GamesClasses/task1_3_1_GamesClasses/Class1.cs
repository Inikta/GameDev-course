
namespace ComputerGames
{
    class MOBA
    {
        private string _name;

        public string description;

        private int _year;

        private int _AmountOfCharacters;

        private int _TeamSize;

        public MOBA(
            string name,
            int year,
            int amountOfCharacters,
            int teamSize,
            string description)
        {
            this._name = name;
            this._year = year;
            this._AmountOfCharacters = amountOfCharacters;
            this._TeamSize = teamSize;
            this.description = description;
        }
        public void Message() 
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Year: " + _year);
            Console.WriteLine("Amount of characters: " + _AmountOfCharacters);
            Console.WriteLine("Size of team: " + _TeamSize);
            Console.WriteLine("Description: " + description);
        }
    }

    internal class Shooter
    {
        private string _name;

        public string description;

        private int _year;

        private int _AmountOfGunTypes;

        private int _TeamSize;

        public Shooter(
            string name,
            int year,
            int amountOfGunTypes,
            int teamSize,
            string description)
        {
            this._name = name;
            this._year = year;
            this._AmountOfGunTypes = amountOfGunTypes;
            this._TeamSize = teamSize;
            this.description = description;
        }
        public void Message()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Year: " + _year);
            Console.WriteLine("Amount of gun types: " + _AmountOfGunTypes);
            Console.WriteLine("Size of team: " + _TeamSize);
            Console.WriteLine("Description: " + description);
        }
    }

    internal class RPG
    {
        private string _name;

        public string description;

        private int _year;

        private string _view;

        private int _HoursToComplete;

        public RPG(
            string name,
            int year,
            string view,
            int hoursToComplete,
            string description)
        {
            this._name = name;
            this._year = year;
            this._view = view;
            this._HoursToComplete = hoursToComplete;
            this.description = description;
        }
        public void Message()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Year: " + _year);
            Console.WriteLine("View: " + _view);
            Console.WriteLine("Hours to complete: " + _HoursToComplete);
            Console.WriteLine("Description: " + description);
        }
    }

    internal class Puzzle
    {
        private string _name;

        public string description;

        private int _year;

        private int _ComplexityRating;

        private int _AmountOfLevels;

        public Puzzle(
            string name,
            int year,
            int complexityRating,
            int amountOfLevels,
            string description)
        {
            this._name = name;
            this._year = year;
            this._ComplexityRating = complexityRating;
            this._AmountOfLevels = amountOfLevels;
            this.description = description;
        }
        public void Message()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Year: " + _year);
            Console.WriteLine("Complexity rating: " + _ComplexityRating);
            Console.WriteLine("Amount of levels: " + _AmountOfLevels);
            Console.WriteLine("Description: " + description);
        }
    }

    internal class Strategy
    {
        private string _name;

        public string description;

        private int _year;

        private string _HistoricalPeriod;

        private int _AmountOfRivals;

        public Strategy(
            string name,
            int year,
            string historicalPeriod,
            int amountOfRivals,
            string description)
        {
            this._name = name;
            this._year = year;
            this._HistoricalPeriod = historicalPeriod;
            this._AmountOfRivals = amountOfRivals;
            this.description = description;
        }
        public void Message()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Year: " + _year);
            Console.WriteLine("Hsitorical period: " + _HistoricalPeriod);
            Console.WriteLine("Maximal amount of rivals: " + _AmountOfRivals);
            Console.WriteLine("Description: " + description);
        }
    }
}
