using System;
using System.Linq;

namespace ConsoleLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLibrary cl = new ConsoleLibrary();
            int option = 1;
            string[] options = 
                {
                    "Open", "Save", "Print", "Exit"
                };
            while (option != 0)
            {
                option = cl.GetConsoleMenu(options);
                int age = cl.GetConsoleInt("Please enter your age(0-110)", 0, 110);
                int area = cl.GetConsoleInt("Please enter your area code(0-999)", 0, 999);
                int zip = cl.GetConsoleInt("Please enter your Zip code(0-99999)", 0, 99999);
                int[] maxMin = cl.GetCustomConsoleInt("Please enter a maximum and a minimum number");
                char initial = cl.GetConsoleChar("Please enter your first initial");
                bool isAwesome = cl.GetConsoleBool("Are you awesome?");
                string lName = cl.GetConsoleString("Please enter your last name");
                if (option == 3)
                {
                    Console.WriteLine
                        (
                            Convert.ToString(age) + 
                            Convert.ToString(area) + 
                            Convert.ToString(zip) + 
                            Convert.ToString(maxMin) + 
                            initial + 
                            Convert.ToString(isAwesome) + 
                            lName
                        );
                }
                else if (option == 2)
                {
                    ConsoleLibrary cli = new ConsoleLibrary();
                    cli.FileAsync(Convert.ToString(age) +
                            Convert.ToString(area) +
                            Convert.ToString(zip) +
                            Convert.ToString(maxMin) +
                            initial +
                            Convert.ToString(isAwesome) +
                            lName);
                }
                else if (option == 1)
                {
                    string[] lines = System.IO.File.ReadAllLines(@"..\..\endFile.txt");
                    Console.WriteLine("printing file contents of endfile");
                    foreach(string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
        
        
    }
}
