using System;


namespace HT2
{
    public  class Swordsman : Heroes
    {
        public Swordsman(string name, int health, int attkMax, int attkMin, int blockMax)
            : base("swordsman", 100, 30, 20, 10) { }
        public override void SpecialAbilities()
        {
            Console.WriteLine($"Unit {Name} has not special abilities");
        }
    }
}
