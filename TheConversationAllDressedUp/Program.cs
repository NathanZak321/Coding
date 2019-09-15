using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheConversationAllDressedUp
{
    //--------------------------------------------------------------------
    // Application: The Conversation All Dressed Up
    // Author:      Nathan Zak
    // Description: A conversation with the user about getting a loan.
    // Date Created:9/7/2019
    // Date Revised:9/15/2019
    //--------------------------------------------------------------------
    class Program
    {
 
        static void Main(string[] args)
        {
            //-----------------------
            // - Screen Settings -
            //-----------------------
            ConsoleColor openingClosingScreenBackground = ConsoleColor.Black;
            ConsoleColor openingClosingScreenForeground = ConsoleColor.Blue;
            ConsoleColor appScreenBackground = ConsoleColor.White;
            ConsoleColor appScreenForeground = ConsoleColor.DarkRed;

            //--------------
            // - Variables -
            //--------------
            string userName;
            string bankChoice;
            string typeOfLoan;
            string userResponse;
            double loanPrinciple;
            double loanInterestRate;
            int loanTermMonths;
         

            //------------------------
            // - Starting Screen -
            //------------------------
            // set cursor invisible, background colors, foreground colors, and clear screen
            Console.CursorVisible = false;
            Console.BackgroundColor = openingClosingScreenBackground;
            Console.ForegroundColor = openingClosingScreenForeground;
            Console.Clear();


            //-----------------
            // - Intro Screen -
            //-----------------
            Console.WriteLine();
            Console.WriteLine("\t\tLoan Calculator");
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();

            //-------------------------
            // - Initial Screen -
            //-------------------------
            // set cursor invisible, background colors, foreground colors, and clear screen
            Console.CursorVisible = true;
            Console.BackgroundColor = appScreenBackground;
            Console.ForegroundColor = appScreenForeground;
            Console.Clear();

            //----------------
            // - Greet User -
            //----------------
            Console.WriteLine();
            Console.WriteLine(" Welcome!");
            Console.WriteLine(" This application is designed to calculate monthly loan payments.");

            //-----------------
            // - Get Username -
            //-----------------
            Console.WriteLine();
            Console.Write(" What is your name? ");
            userName = Console.ReadLine();
            Console.WriteLine(" It is nice to meet you " + userName + ".");

            //----------------------------
            // - Ask If They Want A Loan -
            //----------------------------
            Console.WriteLine();
            Console.Write($" How about we set you up with loan today {userName}?");
            userResponse = Console.ReadLine();

            if (userResponse == "yes")
            {
                Console.CursorVisible = true;
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine(" Perfect! Now let me just get one more piece of information and we can get started.");

                //----------------
                // - New Screen -
                //----------------
                Console.Clear();

                //-----------------
                // - Bank To Use -
                //-----------------
                Console.WriteLine();
                Console.Write(" Now tell me the name of your bank that you would like to recieve the loan from.");
                bankChoice = Console.ReadLine();
                Console.WriteLine(" Very well {0}, a loan will be coming from {1}.", userName, bankChoice);

                //---------------
                // - Loan Type -
                //---------------
                Console.WriteLine();
                Console.WriteLine(" Based off your bank choice only a few options are available, please choose one of the following.");
                Console.WriteLine("\t\"HOME\"  \"COLLEGE\"");

                //----------------
                // - Loan Type -
                //----------------
                Console.WriteLine();
                Console.Write(" Now go ahead and enter the amount you would like to receive.");
                userResponse = Console.ReadLine();
                loanPrinciple = Convert.ToDouble(userResponse);

                //-------------------
                // - How Long - 
                //-------------------
                Console.WriteLine();
                Console.WriteLine(" Please state the length of the loan in years");
                userResponse = Console.ReadLine();
                loanTermMonths = Convert.ToInt32(userResponse) * 12;

                //-------------------
                // - Interest Rate -
                //-------------------
                Console.WriteLine();
                if (typeofLoan.ToUpper() == "HOME")
                {
                   loanInterestRate = 0.0375 / 12;
                }
                else if (typeOfLoan.ToUpper() == "COLLEGE")
                {
                   loanInterestRate = 0.0450 / 12;
                }
                else //NotVaild
                {
                    Console.WriteLine(" Sorry that type of loan cannot be done.");
                    Console.WriteLine(" Sadly I cannot help you today.");
                }

                //-----------------
                // - Clear Screen -
                //-----------------
                Console.Clear();


                //-----------------------
                // - Closing Screen -
                //-----------------------

                Console.CursorVisible = false;
                Console.BackgroundColor = openingClosingScreenBackground;
                Console.ForegroundColor = openingClosingScreenForeground;
                Console.Clear();

                //-------------------------
                // Closing Screen
                //-------------------------
                Console.WriteLine();
                Console.WriteLine("\t\tThank You for Your Interest in Our Application");
                Console.WriteLine();
                Console.WriteLine("\tPress any key to exit.");
                Console.ReadKey();
            }
        }

        private class typeofLoan
        {
        }
    }
}
