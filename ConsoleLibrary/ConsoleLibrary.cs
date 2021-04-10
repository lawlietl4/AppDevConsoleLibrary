using System;
using System.IO;
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
            Console.WriteLine(message);
            int input = Convert.ToInt32(Console.ReadLine());
            if (input > min || input < max)
            {
                Console.WriteLine("value accepted!");
            }
            else
            {
                Console.WriteLine("The value was not valid in the given context, application now ending");
                Console.ReadLine();
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
            int ret = 0;
            int i = 0;
            items.Append("exit");
            foreach (string item in items)
            {
                if (item == "Exit"||item == "Quit")
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
            try
            {
                ret = Convert.ToInt32(Console.ReadLine());
                
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            return ret;
        }
        public int[] GetCustomConsoleInt(string message)
        {
            int[] values = { };
            Console.WriteLine(message);
            Console.Write("Minimum: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maximum: ");
            int max = Convert.ToInt32(Console.ReadLine());
            values.Append(min);
            values.Append(max);
            return values;
        }
        public void FileAsync(string outcomes)
        {
            File.WriteAllText("endFile.txt",outcomes);
        }
    }
}
