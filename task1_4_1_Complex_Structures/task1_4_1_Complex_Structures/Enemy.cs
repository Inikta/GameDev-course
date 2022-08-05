namespace task1_3_2_OOP_Characters
{
    public class Enemy
    {
        protected string _name;

        protected Sex _sex;

        protected string _race;

        protected int _age;

        protected int _level;

        public int _maxHealthPoints;

        public int currentHP;

        public Enemy(string name, Sex sex, string race, int age, int level, int health)
        {
            this._name = name;
            this._sex = sex;
            this._race = race;
            this._age = age;
            this._level = level;
            this._maxHealthPoints = health;
            this.currentHP = _maxHealthPoints;
        }

        virtual public void Message()
        {
            Console.WriteLine("[ENEMY]");
            Console.WriteLine("I am an enemy of " + _level + " level. My name is " + _name + " and I am " + _age + " years old.");
            Console.WriteLine("I am " + _sex + " of " + _race + " race.");
        }
    }

    public class Bandit : Enemy
    {
        private string GangName { get; set; }

        private int money { get; set; }
        public Bandit(string name, Sex sex, string race, int age, int level, int health, string gangName, int money) : base(name, sex, race, age, level, health)
        {
            GangName = gangName;
            this.money = money;
        }

        public override void Message()
        {
            base.Message();
            Console.WriteLine("Your money or your life!");
        }
    }

    public class Dragon : Enemy
    {
        private string _TrueName;

        private int money { get; set; }
        public Dragon(string name, Sex sex, string race, int age, int level, int health, string trueName, int money) : base(name, sex, race, age, level, health)
        {
            _TrueName = trueName;
            this.money = money;
        }

        public override void Message()
        {
            base.Message();
            Console.WriteLine("Bow low, you insects!");
        }
    }

    public class OrcBoyz : Enemy
    {
        private string FavoriteColor;

        private int ToothAmount { get; set; }
        public OrcBoyz(string name, Sex sex, string race, int age, int level, int health, string favoriteColor, int toothAmount) : base(name, sex, race, age, level, health)
        {
            FavoriteColor = favoriteColor;
            this.ToothAmount = toothAmount;
        }

        public override void Message()
        {
            base.Message();
            Console.WriteLine("WAAAAAAAGHH!");
        }
    }
}
