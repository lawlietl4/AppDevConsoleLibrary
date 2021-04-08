using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLibrary
{
    class ConsoleLibrary
    {

        public int GetConsoleInt(string message, int min, int max)
        {
            decimal test = 0;
            Console.WriteLine(message);
            decimal input = Convert.ToDecimal(Console.ReadLine());
            if (ValueType.Equals(input, test) & (input < min | input > max))
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
        public bool GetConsoleBool(string message)
        {
            bool test = false;
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
        public char GetConsoleChar(string message)
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
        public string GetConsoleString(string message)
        {
            string test = "test";
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (ValueType.Equals(input, test))
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
        public int GetConsoleMenu(string[] items)
        {
            int i = 0;
            items.Append("exit");
            foreach (string item in items)
            {
                if (item == "Exit"|item == "Quit")
                {
                    i = 0;
                    Console.WriteLine(i + " - " + item);
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
