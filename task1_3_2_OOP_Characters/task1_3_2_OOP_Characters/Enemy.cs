namespace task1_3_2_OOP_Characters
{
    public class Enemy
    {
        protected string name;

        protected Sex sex;

        protected string race;

        protected int age;

        protected int level;

        public Enemy(string name, Sex sex, string race, int age, int level)
        {
            this.name = name;
            this.sex = sex;
            this.race = race;
            this.age = age;
            this.level = level;
        }

        virtual public void Message()
        {
            Console.WriteLine("[ENEMY]");
            Console.WriteLine("I am an enemy of " + level + " level. My name is " + name + " and I am " + age + " years old.");
            Console.WriteLine("I am " + sex + " of " + race + " race.");
        }
    }

    public class Bandit : Enemy
    {
        private string GangName { get; set; }

        private int money { get; set; }
        public Bandit(string name, Sex sex, string race, int age, int level, string gangName, int money) : base(name, sex, race, age, level)
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
        public Dragon(string name, Sex sex, string race, int age, int level, string trueName, int money) : base(name, sex, race, age, level)
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
        public OrcBoyz(string name, Sex sex, string race, int age, int level, string favoriteColor, int toothAmount) : base(name, sex, race, age, level)
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
