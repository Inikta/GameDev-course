﻿
namespace task1_3_2_OOP_Characters
{
    internal class Character
    {
        protected string _name;

        protected Sex _sex;

        protected string _race;

        protected int _age;

        protected int _level;

        public Character(string name, Sex sex, string race, int age, int level)
        {
            this._name = name;
            this._sex = sex;
            this._race = race;
            this._age = age;
            this._level = level;
        }

        virtual public void Message()
        {
            Console.WriteLine("[CHARACTER]");
            Console.WriteLine("I am hero of " + _level + " level. My name is " + _name + " and I am " + _age + " years old.");
            Console.WriteLine("I am " + _sex + " of " + _race + " race.");
        }
    }

    internal class Peasant : Character
    {
        private string? description { get; set; }

        private string country { get; set; }

        private string? LordName { get; set; }
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

        private string? RealName { get; set; }

        private int _id; 
        public Player(string name, Sex sex, string race, int age, int level, string? description, string? realName, int id) : base(name, sex, race, age, level)
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
