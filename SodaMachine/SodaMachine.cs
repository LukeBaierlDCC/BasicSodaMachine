using System;
using System.Collections.Generic;
using System.Text;

namespace SodaMachine
{
    class SodaMachine
    {
        const int SodaPrice = 125;
        public double RunningTotal { get; set; }

        public SodaMachine()
        {
            RunningTotal = 0;
        }

        public void DepositCoin(int money)
        {
            switch (money)
            {
                case (5):                
                    RunningTotal += 5;
                    break;
                case (10):
                    RunningTotal += 10;
                    break;
                case (25):
                    RunningTotal += 25;
                    break;
                case (100):
                    RunningTotal += 100;
                    break;
                default:
                    Console.WriteLine("No pennies, please.");
                    break;
            }
        }

        public bool checkTotal()
        {
            if (RunningTotal >= SodaPrice)
                return true;
            else
                return false;            
        }
        public void DisplayDrinkSelections()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("* Your beverage selections are as follows: *");
            Console.WriteLine("*             1 = Pepsi                    *");
            Console.WriteLine("*             2 = Mountain Dew             *");
            Console.WriteLine("*             3 = Coca Cola                *");
            Console.WriteLine("********************************************");
            Console.WriteLine("");
            Console.Write("Choose your beverage: ");
            MakeDrinkSelection(Convert.ToChar(Console.ReadLine().ToUpper()));
        }

        private void MakeDrinkSelection(char selection)
        {
            bool selectionOK = false;
            while (!selectionOK)
            {
                switch (selection)
                {
                    case '1':
                        {
                            Console.WriteLine("Now dispensing your Pepsi. Thank you.");
                            ReturnChange();
                            selectionOK = true;
                            break;
                        }
                    case '2':
                        {
                            Console.WriteLine("Now dispensing your Mountain Dew. Thank you.");
                            ReturnChange();
                            selectionOK = true;
                            break;
                        }
                    case '3':
                        {
                            Console.WriteLine("Now dispensing your Coca Cola. Thank you.");
                            ReturnChange();
                            selectionOK = true;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("That's not in our inventory. Try again.");
                            selection = Convert.ToChar(Console.ReadLine().ToUpper());
                            selectionOK = false;
                            Console.ReadLine();
                            break;
                        }
                }
            }
        }
        private void ReturnChange()
        {
            if (RunningTotal > SodaPrice)
            {
                Console.WriteLine("Your change is {0:C}", (RunningTotal - SodaPrice) * 0.01);
            }
        }
    }
}
