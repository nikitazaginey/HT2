using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT2
{
    internal class MainСharacter : Heroes
    {
        public MainСharacter(string name)
          : base(name, 500, 60, 40, 25) { }
        public override void SpecialAbilities()
        {
            Console.WriteLine($"You drink special elixir! Your defense is improved");
            BlockMax = 70;
        }
    }
}
