using System;


namespace HT2
{
    public class Elf : Heroes
    {
        public Elf()
          : base("Elf", 85, 35, 25, 20) { }
        public override void SpecialAbilities()
        {
            Console.WriteLine($"Unit {Name} use special protection!");
            BlockMax = 30;
        }
    }
}
