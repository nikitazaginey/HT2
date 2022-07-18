

namespace HT2
{
    public abstract class Heroes
    {
        // Define the Warriors properties
        public string Name { get; set; } 
        public int Health { get; set; } 
        public int AttkMax { get; set; }
        public int AttkMin { get; set; }
        public int BlockMax { get; set; }
        public Heroes(string name, int health, int attkMax, int attkMin, int blockMax)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            AttkMin = attkMin;
            BlockMax = blockMax;
        }
        public int Attack() => new Random().Next(AttkMin, AttkMax);
        public  int Block () =>  new Random().Next(1, BlockMax);
        public abstract void SpecialAbilities();


    }
}
