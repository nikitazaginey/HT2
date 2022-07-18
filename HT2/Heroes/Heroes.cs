

namespace HT2
{
    public abstract class Heroes
    {
        // Define the Warriors properties
        public string Name { get; set; } 
        public double Health { get; set; } 
        public double AttkMax { get; set; }
        public double AttkMin { get; set; }
        public double BlockMax { get; set; }
        public Heroes(string name, double health, double attkMax, double attkMin, double blockMax)
        {
            Name = name;
            Health = health;
            AttkMax = attkMax;
            AttkMin = attkMin;
            BlockMax = blockMax;
        }
        public double Attack() => new Random().Next((int)AttkMin, (int)AttkMax);
        public double Block () =>  new Random().Next(1, (int)BlockMax);
        public abstract void SpecialAbilities();


    }
}
