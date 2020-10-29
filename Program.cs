using System;

// Dylan McFarlin
// Date revised: 9-3-20
// Challenge#1
// Program that instructs you how to make a frozen pizza
// Code reviewed by: Sean Chandler

namespace Day2Group8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("How to Make a Pizza");
            Console.WriteLine();
            Console.WriteLine("Are you hungry? (yes/no)");
            string hungryA = Console.ReadLine();
            if (hungryA == "yes")
            {
                Console.Clear();
                Console.WriteLine("Walk to freezer...");
            }
            else
            {
                Console.WriteLine("Do not prepare pizza.");
                System.Environment.Exit(1);
            }
            Console.WriteLine();
            Console.WriteLine("Do you have a frozen pizza already in the freezer? (yes/no)");
            string isPizzaInFreezerA = Console.ReadLine();
            if (isPizzaInFreezerA == "yes")
            {
                Console.Clear();
                Console.WriteLine("Grab the frozen pizza from the freezer and set on kitchen table.");
                Console.WriteLine("Walk to oven...");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Go to the grocery store to purchase pizza.");
                System.Environment.Exit(1);
            }
            Console.WriteLine();
            Console.WriteLine("Is there anything already in the oven? (yes/no)");
            string isThereStuffInOvenA = Console.ReadLine();
            if (isThereStuffInOvenA == "yes")
            {
                Console.Clear();
                Console.WriteLine("Clear oven.");
                Console.WriteLine("Then preheat oven to 350 degrees.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Preheat oven to 350 degrees.");
            }
            Console.WriteLine();
            Console.WriteLine("Is the oven up to temperature yet? (yes/no)");
            string isOvenUpToTempA = Console.ReadLine();
            if (isOvenUpToTempA == "yes")
            {
                Console.Clear();
                Console.WriteLine("Walk to cabinets.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wait another 2min, then walk to cabinets.");
            }
            Console.WriteLine();
            Console.WriteLine("Are you at the cabinet containing the pan? (yes/no)");
            string isUserAtCabinetA = Console.ReadLine();
            if (isUserAtCabinetA == "yes")
            {
                Console.Clear();
                Console.WriteLine("Grab pan.");
                Console.WriteLine("Then remove the frozen pizza from the packaging.");
                Console.WriteLine("Place the frozen pizza onto the pan.");
                Console.WriteLine("Place pizza pan in the center of oven to begin cooking!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Find the correct cabinet containing the pan.");
                Console.WriteLine("Then remove the frozen pizza from the packaging.");
                Console.WriteLine("Place the frozen pizza onto the pan.");
                Console.WriteLine("Place pizza pan in the center of oven to begin cooking!");
            }
            Console.WriteLine();
            Console.WriteLine("After waiting x amount of minutes, does the pizza look done? (yes/no)");
            string isPizzaDoneA = Console.ReadLine();
            if (isPizzaDoneA == "yes")
            {
                Console.Clear();
                Console.WriteLine("Take pizza out of oven and let cool.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Wait another 2min...");
                Console.WriteLine("Then take pizza out of oven and let cool.");
            }
            Console.WriteLine();
            Console.WriteLine("Is the pizza cool enough to eat? (yes/no)");
            string isPizzaCoolEnoughToEatA = Console.ReadLine();
            if (isPizzaCoolEnoughToEatA == "yes")
            {
                Console.Clear();
                Console.WriteLine("Put some parmesan cheese and chilli peppers.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Let pizza cool a minute longer...");
                Console.WriteLine("Then grab parmesan cheese and chilli peppers.");
            }
            Console.WriteLine();
            Console.WriteLine("Would you like extra parmesan cheese? (yes/no)");
            string extraParmesanCheeseA = Console.ReadLine();
            if (extraParmesanCheeseA == "yes")
            {
                Console.Clear();
                Console.WriteLine("Put extra cheese on pizza.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Do not put extra parmesan cheese.");
            }
            Console.WriteLine();
            Console.WriteLine("Would you like extra chilli peppers on pizza? (yes/no)");
            string extraChilliPeppersA = Console.ReadLine();
            if (extraChilliPeppersA == "yes")
            {
                Console.Clear();
                Console.WriteLine("Put more chilli peppers on pizza.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Do not put more chilli peppers on pizza.");
            }
            Console.WriteLine();
            Console.WriteLine("Go to cabinet to find pizza cutter.");
            Console.WriteLine("Is there a pizza cutter??? (yes/no)");
            string isTherePizzaCutterA = Console.ReadLine();
            if (isTherePizzaCutterA == "yes")
            {
                Console.Clear();
                Console.WriteLine("Cut pizza with pizza cutter into nice even slices.");
                Console.WriteLine("Then serve and share pizza :)");
                Console.WriteLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Rip hot pizza apart expeditiously with hands.");
                Console.WriteLine("Then serve and share pizza :)");
                Console.WriteLine();
            }
        }
    }
}
