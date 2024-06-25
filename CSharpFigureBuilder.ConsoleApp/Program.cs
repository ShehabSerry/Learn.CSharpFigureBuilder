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
                Console.WriteLine();
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
        static void Builder(int Length, string Shape, string BuildingBlock)
        {
            int Len = Length;
            string BB = BuildingBlock;
            string Output = "";
            switch (Shape)
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
                                    for (int row = 1; row <= Len; row++)
                                    {
                                        for (int spaces = Len - row; spaces > 0; spaces--)  // spacer
                                            Output += " ";

                                        for (int block = 0; block < row; block++)
                                            Output += BB;

                                        for (int RHS = 0; RHS < row - 1; RHS++)  // after midpoint
                                            Output += BB;
                                        Output += "\n";
                                    }
                                    WriteCLine($"A Non-Inverted, '{BB}' Filled Triangle of Height: {Len}");
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
            Spammer('-', 54);
            WriteCLine($"\n{Output}", ConsoleColor.Green);
            Spammer('-', 54);
        }
        static void Main(string[] args)
        {
            Console.Title = "ShapeBuilder";
            WriteCLine("");
            Spammer('*', 54, ConsoleColor.Cyan);
            WriteCLine("SHAPE BUILDER CLI\n This Program will prompt you to choose a character\n Pick a shape \n Indicate whether it's Inverted or not \n And indicate whether it's filled or not");
            Spammer('*', 54, ConsoleColor.Cyan);
            WriteCLine("");

            Spammer('*', 54);
            WriteCLine("Please insert the length of your desired shape: ", newline: false);
            string Length = ReadCLine(ConsoleColor.Yellow);
            Spammer('*', 54);
            int ParsedLength = intValidator(Length);
            if (ParsedLength == 0)
                WriteCLine("Invalid length, start over", ConsoleColor.Red);
            else
            {
                Spammer('*', 54);
                WriteCLine("Insert the char to be used as the building block: ", newline: false);
                string BuildingBlock = ReadCLine(ConsoleColor.Yellow, true);
                Spammer('*', 54);

                Spammer('*', 54);
                WriteCLine("Choose one from the listed shapes: \n  --[1] Triangle-- \n  --[2] Diamond ");
                WriteCLine("Insert your option: ", newline: false);
                string Shape = ReadCLine(ConsoleColor.Yellow, true);
                if(Shape != "1" && Shape != "2")
                {
                    WriteCLine("Invalid input, start over", ConsoleColor.Red);
                    return;
                }                 
                Spammer('*', 54);

                Builder(ParsedLength, Shape, BuildingBlock);
            }

            Console.ReadKey();

        }
    }
}

