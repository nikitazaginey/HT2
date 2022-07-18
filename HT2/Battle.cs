using System;


namespace HT2
{
    public class Battle
    {
        // This is a utility class so it makes sense
        // to have just static methods

        // Recieve both Warrior objects
        public static void StartFight(Heroes hero1, Heroes hero2)
        {
            // Loop giving each Warrior a chance to attack
            // and block each turn until 1 dies
            while (true)
            {
                if (GetAttackResult(hero1, hero2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

                if (GetAttackResult(hero1, hero2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
        }

        // Accept 2 Warriors
        public static string GetAttackResult(Heroes heroA,
            Heroes heroB)
        {
            // Calculate one Warriors attack and the others block
            int warAAttkAmt = heroA.Attack();
            int warBBlkAmt = heroB.Block();

            // Subtract block from attack
            int dmg2WarB = warAAttkAmt - warBBlkAmt;

            // If there was damage subtract that from the health
            if (dmg2WarB > 0)
            {
                heroB.Health = heroB.Health - dmg2WarB;
            }
            else dmg2WarB = 0;

            // Print out info on who attacked who and for how
            // much damage
            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage",
                heroA.Name,
                heroB.Name,
                dmg2WarB);

            // Provide output on the change to health
            Console.WriteLine("{0} Has {1} Health\n",
                heroB.Name,
                heroB.Health);

            // Check if the warriors health fell below
            // zero and if so print a message and send
            // a response that will end the loop
            if (heroB.Health <= 0)
            {
                Console.WriteLine("{0} has Died and {1} is Victorious\n",
                    heroB.Name,
                    heroA.Name);

                return "Game Over";
            }
            else return "Fight Again";
        }

    }
}

