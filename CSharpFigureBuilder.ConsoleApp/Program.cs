using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFigureBuilder.ConsoleApp
{
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
        static string ReadCLine(ConsoleColor color = ConsoleColor.White, bool single = false)
        {
            string input = "";
            Console.ForegroundColor = color;
            if (single)
            {
                int ascii = Console.ReadKey().KeyChar;
                char charinput = (char)ascii;
                return charinput.ToString(); 
            }
            else
                input = Console.ReadLine();

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
                        case "Y":  // inverted (Triangle)
                            WriteCLine("Would you like to have your triangle Filled? Y/N: ", newline: false);
                            string Filled = ReadCLine(ConsoleColor.Yellow).ToUpper();
                            switch (Filled)
                            {
                                case "Y":  // Filled

                                    break;
                                case "N":  // Unfilled

                                    break;
                                default:
                                    WriteCLine("Invalid input, start over", ConsoleColor.Red);
                                    break;
                            }
                            break;
                        case "N":  // not inverted (Triangle)
                            WriteCLine("Would you like to have your triangle Filled? Y/N: ", newline: false);
                            Filled = ReadCLine(ConsoleColor.Yellow).ToUpper();
                            switch (Filled)
                            {
                                case "Y":  // Filled (Triangle)

                                    break;
                                case "N":  // Unfilled (Triangle)

                                    break;
                                default:
                                    WriteCLine("Invalid input, start over", ConsoleColor.Red);
                                    break;
                            }
                            break;
                    }
                    break;

                case "2": // Diamond
                    WriteCLine("Would you like to have your Diamond Filled? Y/N: ", newline: false);
                    string FilledD = ReadCLine(ConsoleColor.Yellow).ToUpper();
                    switch (FilledD)
                    {
                        case "Y":  // Filled Extra

                            break;
                        case "N":  // Unfilled

                            break;
                    }
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

            Spammer('*', 52);
            WriteCLine("Please insert the length of your desired shape: ", newline: false);
            string length = ReadCLine(ConsoleColor.Yellow);
            Spammer('*', 52);
            int ParsedLength = intValidator(length);
            if (ParsedLength == 0)
                WriteCLine("Invalid length, start over", ConsoleColor.Red);
            else
            {
                Spammer('*', 52);
                WriteCLine("Choose one from the listed shapes: \n  --[1] Triangle-- \n  --[2] Diamond ");
                WriteCLine("Insert your option: ", newline: false);
                string shape = ReadCLine(ConsoleColor.Yellow);
                Spammer('*', 52);

                Spammer('*', 52);
                WriteCLine("Insert the char to be used as the building block: ", newline:false);
                string BuildingBlock = ReadCLine(ConsoleColor.Yellow, true);
                WriteCLine("");
                Spammer('*', 52);
            }

            Console.ReadKey();

        }
    }
}

