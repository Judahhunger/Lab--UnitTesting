using System;

 namespace Lab02UnitTestingATM
{
    public class Program
    {
        //Global Vars
        public static double currentBalance = 5000;
        public static bool keepOpen = true;

        static void Main(string[] args)
        {
            // keeps menu open until exit is given.
            try
            {
                while (keepOpen)
                {
                    MenuNav();
                }
            }
            finally
            {
                Console.WriteLine("Don't Forget your receipt.");
                Console.ReadLine();
            }
           
            
        }
       

        //shows text to screen so user can navigate and choose what to do until user chooses exit.
        public static bool MenuNav()
        {
            Console.Clear();
            Console.WriteLine("Welcome to your acount. Select an option by pressing the number on the key pad.");
            Console.WriteLine("1) View Balance");
            Console.WriteLine("2) Widthdraw Money");
            Console.WriteLine("3) Deposit Money");
            Console.WriteLine("4) Exit");

            string userNavSelect = Console.ReadLine();
            try
            {
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
                else if (userNavSelect == "4")
                {
                    keepOpen = false;
                    return keepOpen;
                }


                return true;
            }
            catch (Exception)
            {

                Console.WriteLine("Please enter a valid number");
                Console.Read();
                return true;
            }
           
        }

        /// <summary>
        /// views for current balance as $ amount.
        /// </summary>
        public static void ViewCurrentBalance()
        {
            string currentBalanceString = String.Format("{0:C}", currentBalance);

            Console.Clear();
            Console.WriteLine($"Your current balance is {currentBalance}");
            Console.ReadLine();
        }
       
        /// <summary>
        /// Widthdraws from balance if the widthdrawed amount will not make balance go negitive.
        /// </summary>
        /// <param name="moneyOnHand"></param>
        /// <param name="moneyGoingOut"></param>
        /// <returns>new balance or if nothing taken out old balance.</returns>
        public static double WidthdrawMony(double moneyOnHand, double moneyGoingOut)
        {
            try
            {
                while (moneyOnHand >= moneyGoingOut && moneyOnHand > 0)
                {
                    double afterWidthdraw = moneyOnHand - moneyGoingOut;
                    return afterWidthdraw;
                }

                return moneyOnHand;
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        /// <summary>
        /// Adds to balance if number is positive
        /// </summary>
        /// <param name="moneyOnHand"></param>
        /// <param name="moneyGoingIn"></param>
        /// <returns>new balance with added money or if input is negitive old balance.</returns>
        public static double DepositMoney(double moneyOnHand, double moneyGoingIn)
        {
            try
            {
                while (moneyGoingIn > 0)
                {
                    return moneyOnHand + moneyGoingIn;
                }
                return moneyOnHand;
            }
            catch (Exception)
            {

                throw;
            }
           
            
        }
    }
}
