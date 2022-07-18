using System;


namespace HT2
{
    public class Magician : Heroes
    {
        public Magician(string name, int health, int attkMax, int attkMin, int blockMax)
           : base("Magician", 70, 40, 25, 10) { }
        public override void SpecialAbilities()
        {
            Console.WriteLine($"Unit {Name} use special magic!");
            AttkMax = 50;
            AttkMin = 35;
        }
    }
}
