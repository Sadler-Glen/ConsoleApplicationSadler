using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Globalization;

namespace ConsoleApplicationSadler
{
    class WeekOneAssignment
    {
        static void Main(string[] args)
        {
            myIntroduction();                               // W01 Assignment Instructions 1 - 3
            clearConsole();
            
            dateCalculations();                             // W01 Assignment Instructions 4, 5
            clearConsole();
            
            glazingCalculations();                          // W01 Assignment Instructions 6, 7
            clearConsole();
        }

        private static void myIntroduction()                // W01 Assignment Instructions 1 - 3
        {
            string fullName, location;
            
            fullName = "Glen Sadler";
            location = "New Zealand";

            Console.WriteLine("=====================================================================");
            Console.WriteLine(" M Y   I N T R O D U C T I O N");
            Console.WriteLine("=====================================================================\r\n");
            // use String Interpolation as required for this assignement
            Console.WriteLine($" My name is {fullName}.");
            Console.WriteLine($" I am from {location}.\r\n");
        }

        private static void dateCalculations()             // W01 Assignment Instructions 4, 5
        {
            DateTime today = DateTime.Today;
            DateTime christmas = new DateTime(2019, 12, 25);
            TimeSpan numberOfDays = christmas - today;

            Console.WriteLine("=====================================================================");
            Console.WriteLine(" D A T E   C A L C U L A T I O N S");
            Console.WriteLine("=====================================================================\r\n");
            Console.WriteLine($" The date today is {today.ToString("d")} (NZ Region d/mm/yyyy).\r\n");
            Console.WriteLine($" There are {numberOfDays.TotalDays} days to Christmas {christmas.Year}.\r\n");            
        }

        private static void glazingCalculations()           // W01 Assignment Instructions 6, 7
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("=====================================================================");
            Console.WriteLine(" G L A Z I N G  C A L C U L A T O R");
            Console.WriteLine("=====================================================================\r\n");

            while (true)
            {
                Console.Write(" Please enter the window width in meters: ");
                widthString = Console.ReadLine();
                if (!double.TryParse(widthString, out width))
                {
                    Console.WriteLine(" Please enter a number > 0.\r\n");
                }
                else
                {
                    if (width > 0)
                    {
                        width = double.Parse(widthString);
                        Console.WriteLine("");
                        break;
                    }
                    else
                    {
                        Console.WriteLine(" Please enter a number > 0.\r\n");   
                    }
                }
            }

            while (true)
            {
                Console.Write(" Please enter the window height in meters: ");
                heightString = Console.ReadLine();
                if (!double.TryParse(heightString, out height))
                {
                    Console.WriteLine(" Please enter a number > 0.\r\n");
                }
                else
                {
                    if (height > 0)
                    {
                        height = double.Parse(heightString);
                        Console.WriteLine("");
                        break;
                    }
                    else
                    {
                       Console.WriteLine(" Please enter a number > 0.\r\n"); 
                    }
                }
            }

            // Calculate the wood length require and convert into feet. 
            woodLength = 2 * (width + height) * 3.25;

            // Calculate the glass area required in square meters
            glassArea = 2 * (width * height);

            Console.WriteLine($" The total length of the wood required is {woodLength} feet.\r\n");
            Console.WriteLine($" The total area of the glass required is {glassArea} square meters.\r\n");
        }

        private static void clearConsole()          // Added to clear console after each method has run
        {
            Console.WriteLine("=====================================================================\r\n");
            Console.Write(" Press any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
        }                     
    }
}
