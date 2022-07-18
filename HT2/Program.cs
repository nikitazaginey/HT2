namespace HT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Swordsman swordsman = new Swordsman();
            Magician magician = new Magician();
            Battle.StartFight(swordsman, magician);

            Console.ReadKey();
        }
    }
}