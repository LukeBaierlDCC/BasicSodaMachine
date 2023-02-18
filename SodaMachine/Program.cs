using System;

namespace SodaMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var sodaMachine = new SodaMachine();

            while (!sodaMachine.checkTotal())
            {
                Console.WriteLine("Please enter currency (5 for a nickel, 10 for a dime, 25 for a quarter, 100 for a dollar).");
                sodaMachine.DepositCoin(Convert.ToInt32(Console.ReadLine()));
            }

            sodaMachine.DisplayDrinkSelections();

            Console.ReadLine();
        }
    }
}
