
namespace task1_3_2_OOP_Characters
{
    internal class Character
    {
        protected string name;

        protected Sex sex;

        protected string race;

        protected int age;

        protected int level;

        public Character(string name, Sex sex, string race, int age, int level)
        {
            this.name = name;
            this.sex = sex;
            this.race = race;
            this.age = age;
            this.level = level;
        }

        virtual public void Message()
        {
            Console.WriteLine("[CHARACTER]");
            Console.WriteLine("I am hero of " + level + " level. My name is " + name + " and I am " + age + " years old.");
            Console.WriteLine("I am " + sex + " of " + race + " race.");
        }
    }

    internal class Peasant : Character
    {
        private string? description { get; set; }

        private string country { get; set; }

        private string LordName { get; set; }
        public Peasant(string name, Sex sex, string race, int age, int level, string? description, string country, string LordName) : base(name, sex, race, age, level)
        {
            this.description = description;
            this.country = country;
            this.LordName = LordName;
        }

        public override void Message()
        {
            base.Message();
            Console.WriteLine("Get out of this field, while " + LordName + " haven't noticed!");
        }
    }

    internal class Knight : Character
    {
        private string? description { get; set; }

        private string country { get; set; }

        private int ArmorClass { get; set; }
        public Knight(string name, Sex sex, string race, int age, int level, string? description, string country, int armorClass) : base(name, sex, race, age, level)
        {
            this.description = description;
            this.country = country;
            ArmorClass = armorClass;
        }

        public override void Message()
        {
            base.Message();
            Console.WriteLine("Don't even dare to try pierce my armor of " + ArmorClass + "th class!");
        }
    }

    internal class Player : Character
    {
        private string? description { get; set; }

        private string RealName { get; set; }

        private int _id; 
        public Player(string name, Sex sex, string race, int age, int level, string? description, string realName, int id) : base(name, sex, race, age, level)
        {
            this.description = description;
            this.RealName = realName;
            this._id = id;
        }

        public override void Message()
        {
            base.Message();
            Console.WriteLine("I am player!");
        }
    }
}
