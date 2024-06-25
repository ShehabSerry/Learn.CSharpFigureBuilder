using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFigureBuilder.ConsoleApp
{
    // As of what has been written on Sunday
    class Program
    {
        static int intValidator(string input)
        {
            if (!string.IsNullOrWhiteSpace(input) && int.TryParse(input, out int result))
                return int.Parse(input);
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                WriteCLine("Invalid input, insert a valid value: ", ConsoleColor.Red, false);
                return intValidator(ReadCLine(ConsoleColor.Yellow));
            }
        }
        static void WriteCLine(string text, ConsoleColor color = ConsoleColor.White, bool newline = true)
        {
            Console.ForegroundColor = color;
            if (newline)
                Console.WriteLine(text);
            else
                Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static string ReadCLine(ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            string input = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            return input;
        }
        static void Spammer(char sign, int len, ConsoleColor Color = ConsoleColor.White) // * input prompt, - output   char len color
        {
            Console.ForegroundColor = Color;
            string output = "";
            for (int i = 0; i < len; i++)
                output += sign;
            Console.WriteLine(output);
            Console.ForegroundColor = ConsoleColor.White;
        }
        static void Brain(string Choice)
        {
            switch (Choice)
            {
                case "1":  // triangle 
                    WriteCLine("Would you like to have your triangle Inverted? Y/N: ", newline: false);
                    string Inversion = ReadCLine(ConsoleColor.Yellow).ToUpper();
                    switch (Inversion)
                    {
                        case "Y":  // inverted
                            WriteCLine("Would you like to have your triangle Filled? Y/N: ", newline: false);
                            string Filled = ReadCLine(ConsoleColor.Yellow).ToUpper();
                            switch (Filled)
                            {
                                case "Y":

                                    break;
                                case "N":

                                    break;

                            }

                            break;
                        case "N":  // not inverted
                            break;
                    }
                    break;

                case "2": // Diamond

                    break;
                default:
                    WriteCLine("Invalid input, start over", ConsoleColor.Red);
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.Title = "ShapeBuilder";
            WriteCLine("");
            Spammer('*', 52, ConsoleColor.Cyan);
            WriteCLine("SHAPE BUILDER CLI\n This Program will prompt you to choose a character\n Pick a shape \n Indicate whether it's Inverted or not \n And indicate whether it's filled or not");
            Spammer('*', 52, ConsoleColor.Cyan);
            WriteCLine("");

            Spammer('*', 40);
            WriteCLine("Please insert the size of the length: ", newline: false);
            string length = ReadCLine(ConsoleColor.Yellow);
            Spammer('*', 40);
            int ParsedLength = intValidator(length);
            if (ParsedLength == 0)
                WriteCLine("Invalid length, start over", ConsoleColor.Red);
            else
            {
                Spammer('*', 40);
                WriteCLine("Choose one from the listed shapes: \n  --[1] Triangle-- \n  --[2] Diamond ");
                WriteCLine("Insert your option: ", newline: false);
                string shape = ReadCLine(ConsoleColor.Yellow);
                Spammer('*', 40);
            }

            Console.ReadKey();





        }
    }
}

