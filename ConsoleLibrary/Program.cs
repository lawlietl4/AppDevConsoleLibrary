using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            string[] options = 
                {
                    "Open", "Save", "Print", "Quit"
                };
            Program p = new Program();
            
            option = p.GetConsoleMenu(options);
            while (option != 0)
            {
                int age = p.GetConsoleInt("Please enter your age(0-110)", 0, 110);
                int area = p.GetConsoleInt("Please enter your area code(0-999)", 0, 999);
                int zip = p.GetConsoleInt("Please enter your Zip code(0-99999)", 0, 99999);
                int maxMin = p.GetConsoleInt(
                    "Please enter a maximum and a minimum number", Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())
                    );
                char initial = p.GetConsoleChar("Please enter your first initial");
                bool isAwesome = p.GetConsoleBool("Are you awesome?");
                string lName = p.GetConsoleString("Please enter your last name");
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
            }
        }
        int GetConsoleInt(string message, int min, int max)
        {
            decimal test = 0;
            Console.WriteLine(message);
            decimal input = Convert.ToDecimal(Console.ReadLine());
            if(ValueType.Equals(input, test)&(input < min | input > max))
            {
                Console.WriteLine("value accepted!");
            }
            else
            {
                Console.WriteLine("The value was not valid in the given context, application now ending");
                Environment.Exit(0);
            }
            return Convert.ToInt32(input);
        }
        bool GetConsoleBool(string message)
        {
            bool test=false;
            Console.WriteLine(message);
            bool input = Convert.ToBoolean(Console.ReadLine());
            if (ValueType.Equals(input, test))
            {
                Console.WriteLine("value accepted!");
            }
            else
            {
                Console.WriteLine("The input value was incorrect and/or not Boolean");
            }
            return input;
        }
        char GetConsoleChar(string message)
        {
            char test = 'a';
            Console.WriteLine(message);
            char input = Convert.ToChar(Console.ReadLine());
            if (ValueType.Equals(input, test))
            {
                Console.WriteLine("values accepted!");
            }
            else
            {
                Console.WriteLine("value not accepted, application now ending...");
                Environment.Exit(0);
            }
            return input;
        }
        string GetConsoleString(string message)
        {
            string test = "test";
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if(ValueType.Equals(input, test))
            {
                Console.WriteLine("Value accepted!");

            }
            else
            {
                Console.WriteLine("value was not of string type and now application will end...");
                Environment.Exit(1);
            }
            return input;
        }
        int GetConsoleMenu(string[] items)
        {
            int i = 0;
            items.Append("exit");
            foreach (string item in items)
            {
                if (item == "exit")
                {
                    i = 0;
                }
                else
                {
                    i += 1;
                    Console.WriteLine(i + " - " + item);
                }
            }
            Console.WriteLine("Please enter what you would like to do...");
            int ret = Convert.ToInt32(Console.ReadLine());
            return ret;
        }
    }
}
