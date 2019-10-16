using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksMachine
{
    public class Program
    {
        // bool variables for working out what they have ordered
        public static bool tea = false, milk = false, sugar = false, coffee = false;
        public static string userInput;
        // amount of ingredients
        public static int numTea = 10, numSugar = 10, numMilk = 10, numCoffee = 10, numCups = 10;
        public static int teaMilkSugarCount = 0, teaMilkCount = 0, teaSugarCount = 0, teaCount = 0, coffeeMilkSugarCount = 0, coffeeMilkCount = 0, coffeeSugarCount = 0, coffeeCount = 0; 
       
       public enum Menu
        {
            Quit = 0,
            Tea = 1,
            Coffee = 2
        }


       
        static void Main()
        {
            // runs menu display
            // Menu();
            // takes the users input (string) and turns it into a int
            userInput = Console.ReadLine();
            int result = Int32.Parse(userInput);
            menu.Menu();
            Enum.GetValues(typeof(Menu)).Cast<Menu>();

        //     do
        //     {
        //         switch (result)
        //         {
        //             case 1:
        //                 TeaChoice();
        //                 break;
        //             case 2:
        //                 CoffeeChoice();
        //                 break;
        //             case 3:
        //                 Ingredients();
        //                 break;
        //             case 4:
        //                 Quit();
        //                 break;
        //         }

        //         Menu();
        //         userInput = Console.ReadLine();
        //         result = Int32.Parse(userInput);


        //     // while ingridcheck is true it will stay within the loop
        //     } while (IngridCheck());

        //     // in the event that they run out of ingredients (IngridCheck = false) this error message prints
        //     Console.Write("Error: Not enough ingredients. Unable to process any requests.");
        //     Console.ReadKey();
        // }

        // /// <summary>
        // /// In the event that an ingredient <= 0 the loop ends and they cant order anymore items
        // /// </summary>
        // static bool IngridCheck()
        // {
        //     if (numTea <= 0)
        //     {
        //         return false;
        //     }
        //     if (numMilk <= 0)
        //     {
        //         return false;
        //     }
        //     if (numSugar <= 0)
        //     {
        //         return false;
        //     }
        //     if (numCoffee <= 0)
        //     {
        //         return false;
        //     }
        //     if (numCups <= 0)
        //     {
        //         return false;
        //     }

        //     return true;
        // }
        // /// <summary>
        // /// menu displays what the user can input
        // /// </summary>
        // // static void Menu()
        // // {
        // //     Console.WriteLine("\nPlease pick between the following options:");
        // //     Console.WriteLine("1. - Tea");
        // //     Console.WriteLine("2. - Coffee");
        // //     Console.WriteLine("3 - Inventory");
        // //     Console.WriteLine("4. - Exit");
        // // }

        // /// <summary>
        // /// when the user has choses TeaChoice
        // /// </summary>
        // static void TeaChoice()
        // {
        //     string message = "You have chosen Tea.";
        //     tea = true;
        //     Console.WriteLine(message);
        //     // sets tea to true so the program knows the user wants tea

        //     SugarChoice();
        // }
        // /// <summary>
        // /// when the user choses CoffeeChoice
        // /// </summary>
        // static void CoffeeChoice()
        // {
        //     string message = "You have chosen Coffee.";
        //     Console.WriteLine(message);
        //     // sets coffee to true so the program knows the user wants coffee
        //     coffee = true;
        //     SugarChoice();
        // }

        // /// <summary>
        // ///  asks if the use wants sugar
        // /// </summary>
        // static void SugarChoice()
        // {
        //     string message = "\nWould you like Sugar? y/n:";
        //     Console.WriteLine(message);
        //     userInput = Console.ReadKey().KeyChar.ToString().ToLower();
        //     if (userInput == "y")
        //     {
        //         Console.WriteLine("");
        //         // in the event they want sugar the sugar boolean goes from false to true
        //         sugar = true;
                
        //     }
        //     // runs the MilkChoice method, doesnt matter if they want sugar or not
        //     MilkChoice();
        // }
        // /// <summary>
        // /// asks if the user wants milk
        // /// </summary>
        // static void MilkChoice()
        // {
        //     string message = "\nWould you like Milk? y/n:";
        //     Console.WriteLine(message);
        //     // uses .ReadKey().KeyChar.ToString().ToLower() so that the user cannot input more than one character and that it will be lowercase, allowing for it to be easier to validate
        //     userInput = Console.ReadKey().KeyChar.ToString().ToLower();
        //     if (userInput == "y")
        //     {
        //         Console.WriteLine("");
        //         //sets milk to true so the program knows the user wants milk
        //         milk = true;
        //     }
        //     // runs the Checkout method
        //     Checkout();
        // }
        // /// <summary>
        // /// looks at what the user has asked for and makes it for them
        // /// </summary>
        // static void Checkout()
        // {
        //     // if the user has opted for tea, milk and sugar
        //     if (tea == true && milk == true && sugar == true)
        //     {
        //         Console.WriteLine("\nTea with milk and sugar. This has been ordered: " + (++teaMilkSugarCount) + " time(s).");
        //         --numCups; --numTea; --numMilk; --numSugar;
        //     }
        //     // if the user has opted for tea and milk
        //     if (tea == true && milk == true && sugar == false)
        //     {
        //         Console.WriteLine("\nTea with milk. This has been ordered: " + (++teaMilkCount) + " time(s).");
        //         --numCups; --numTea; --numMilk; 
        //     }
        //     // if the user has opted for tea and sugar
        //     if (tea == true && milk == false && sugar == true)
        //     {
        //         Console.WriteLine("\nTea with sugar. This has been ordered: " + (++teaSugarCount) + " time(s).");
        //         --numCups; --numTea; --numSugar;
        //     }
        //     // if the user has opted for just tea
        //     if (tea == true && milk == false && sugar == false)
        //     {
        //         Console.WriteLine("\nJust Tea. This has been ordered: " + (++teaCount) + " time(s).");
        //         --numCups; --numTea;
        //     }
        //     // if the user has opted for coffee, milk and sugar
        //     if (coffee == true && milk == true && sugar == true)
        //     {
        //         Console.WriteLine("\nCoffee with milk and sugar. This has been ordered: " + (++coffeeMilkSugarCount) + " time(s).");
        //         --numCups; --numCoffee; --numMilk; --numSugar;
        //     }
        //     // if the user has opted for coffee and milk
        //     if (coffee == true && milk == true && sugar == false)
        //     {
        //         Console.WriteLine("\nCoffee with milk. This has been ordered: " + (++coffeeMilkCount) + " time(s).");
        //         --numCups; --numCoffee; --numMilk;
        //     }
        //     // if the user has opted for coffee and sugar
        //     if (coffee == true && milk == false && sugar == true)
        //     {
        //         Console.WriteLine("\nCoffee with sugar. This has been ordered: " + (++coffeeSugarCount) + " time(s).");
        //         --numCups; --numCoffee; --numSugar;
        //     }
        //     // if the user has opted for just coffee
        //     if (coffee == true && milk == false && sugar == false)
        //     {
        //         Console.WriteLine("\nJust Coffee. This has been ordered: " + (++coffeeCount) + " time(s).");
        //         --numCups; --numCoffee;
        //     } 
        // }
        // static void Quit()
        // {
        //     Console.WriteLine("\nQuiting\n");
        //     // quits the application
        //     System.Environment.Exit(1);
        // }
        // static void Ingredients()
        // {
        //     // prints for the user 
        //     Console.WriteLine("Remaining Tea: " + numTea);
        //     Console.WriteLine("Remaining Sugar: " + numSugar);
        //     Console.WriteLine("Remaining Milk: " + numMilk);
        //     Console.WriteLine("Remaining Cups: " + numCups);
        // }









    }
    }
}
