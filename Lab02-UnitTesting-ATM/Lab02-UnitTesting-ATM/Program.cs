using System;

namespace Lab02_UnitTesting_ATM
{
    public class Program
    {
        //Global Vars
        static double currentBalance = 5000;
        static bool keepOpen = true;

        public static void Main(string[] args)
        {
            // keeps menu open until exit is given.
            while (keepOpen)
            {
                MenuNav();
            }
            
        }
       

        //shows text to screen so user can navigate and choose what to do until user chooses exit.
        static bool MenuNav()
        {
            Console.Clear();
            Console.WriteLine("Welcome to your acount. Select an option by pressing the number on the key pad.");
            Console.WriteLine("1) View Balance");
            Console.WriteLine("2) Widthdraw Money");
            Console.WriteLine("3) Deposit Money");
            Console.WriteLine("4) Exit");

            string userNavSelect = Console.ReadLine();
            
            if (userNavSelect == "1")
            {
                ViewCurrentBalance();
            }
            else if (userNavSelect == "2")
            {
                Console.Clear();
                Console.WriteLine("How much would you like to take out?");
                double amountToTakeOut = Double.Parse(Console.ReadLine());

                currentBalance = WidthdrawMony(currentBalance, amountToTakeOut);
               
            }
            else if (userNavSelect == "3")
            {
                Console.Clear();
                Console.WriteLine("How much would you like to put in?");
                double amountToPutIn = Double.Parse(Console.ReadLine());

                currentBalance = DepositMoney(currentBalance, amountToPutIn);
            }
            else if(userNavSelect == "4")
            {
                keepOpen = false;
                return keepOpen;
            }


            return true;
        }

        public static void ViewCurrentBalance()
        {
            string currentBalanceString = String.Format("{0:C}", currentBalance);

            Console.Clear();
            Console.WriteLine($"Your current balance is {currentBalance}");
            Console.ReadLine();
        }

        public static double WidthdrawMony(double moneyOnHand, double moneyGoingOut)
        {
            while (moneyOnHand >= moneyGoingOut && moneyOnHand > 0)
            {
                double afterWidthdraw = moneyOnHand - moneyGoingOut;
                return afterWidthdraw;
            }

            return moneyOnHand;
        }

        public static double DepositMoney(double moneyOnHand, double moneyGoingIn)
        {
            return moneyOnHand + moneyGoingIn;
        }
    }
}
