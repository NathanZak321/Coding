using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    //----------------------------------------------
    // Title: Cost of Flooring
    // Application: Console
    // Description: Calculate the cost for flooring
    // Author: Zak
    // Date Created: 9/19/2019
    //----------------------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            //
            // variable
            //
            string userResponse2;
            string userResponse;
            int
            string room1Name = "Living Room";
            double room1Length = Convert.ToInt32(userResponse);
            double room1Width = userResponse;
            double room1CostSqFoot = 5.00;
            double room1Area;
            double room1Cost;

            string userResponse2;
            string room2Name = "Kitchen";
            double room2Length = userResponse2;
            double room2Width = userResponse2;
            double room2CostSqFoot = 3.50;
            double room2Area;
            double room2Cost;


            double totalArea;
            double totalCost;

            
            //------------------------
            // - Greeting -
            //------------------------
            Console.WriteLine();
            Console.Write("Hello User");
            Console.WriteLine();

            //----------------------------
            // - Description -
            //----------------------------
            Console.WriteLine();
            Console.Write("I'm here to help you calculate the cost of flooring for your house or whatever your building is.");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

            //-------------------------------
            // - Ask for Measurements -
            //-------------------------------
            Console.WriteLine();
            Console.WriteLine("Please tell me the length of your first room.");
            userResponse = Console.ReadLine();
            Console.WriteLine(" So your first room is " + room1Length + "feet long.");

            //------------------
            Console.WriteLine();
            Console.WriteLine("And what is the width of your first room?");
            userResponse = Console.ReadLine();
            Console.WriteLine("The width of the second room is " + room1Width + "feet long.");

            //---------------------------------
            // - Display flooring cost by room -
            //---------------------------------
            //
            // header
            //
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("\t\tFlooring Cost By Room.");
            Console.WriteLine();

            // 
            // Display Table Headers
            //
        
            Console.WriteLine(
            "Room".PadRight(15) +
            "Length".PadLeft(10) +
            "Width".PadLeft(10) +
            "Area".PadLeft(10) +
            "Cost/SqFt".PadLeft(15) +
            "Cost".PadLeft(10) 
             );
            Console.WriteLine(
            "----".PadRight(15) +
            "------".PadLeft(10) +
            "-----".PadLeft(10) +
            "----".PadLeft(10) +
            "---------".PadLeft(15) +
            "----".PadLeft(10)
            );

            //
            //Calculate Table Values
            //
            room1Area = room1Length * room1Width;
            room1Cost = room1Area * room1CostSqFoot;
            room2Area = room2Length * room2Width;
            room2Cost = room2Area * room2CostSqFoot;
            totalArea = room1Area + room2Area;
            totalCost = room1Cost + room2Cost;

            //
            //Display Table Values
            //
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
            room1Name.PadRight(15) +
            room1Length.ToString("f").PadLeft(10) +
            room1Width.ToString("f").PadLeft(10) +
            room1Area.ToString("f").PadLeft(10) +
            room1CostSqFoot.ToString("c").PadLeft(15) +
            room1Cost.ToString("c").PadLeft(10)
            );

            Console.WriteLine(
            room2Name.PadRight(15) +
            room2Length.ToString("f").PadLeft(10) +
            room2Width.ToString("f").PadLeft(10) +
            room2Area.ToString("#.###").PadLeft(10) +
            room2CostSqFoot.ToString("c").PadLeft(15) +
            room2Cost.ToString("c").PadLeft(10)
            );

            Console.WriteLine(
                "------".PadLeft(45) +
                "------".PadLeft(25) 
                );

            Console.WriteLine(
            "Total".PadLeft(5) +
            totalArea.ToString("f").PadLeft(40) +
            totalCost.ToString("c").PadLeft(25)
            );


            //
            //Pause For User
            //
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
