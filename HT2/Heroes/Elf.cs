using System;


namespace HT2
{
    public class Elf : Heroes
    {
        public Elf(string name, int health, int attkMax, int attkMin, int blockMax)
          : base("Elf", 85, 35, 25, 20) { }
        public override void SpecialAbilities()
        {
            Console.WriteLine($"Unit {Name} use special protection!");
            BlockMax = 30;
        }
    }
}
