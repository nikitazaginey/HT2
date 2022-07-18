using System;


namespace HT2
{
    public  class Swordsman : Heroes
    {
        public Swordsman()
            : base("Swordsman", 100, 30, 20, 10) { }
        public override void SpecialAbilities()
        {
            Console.WriteLine($"Unit {Name} has not special abilities");
        }
    }
}
