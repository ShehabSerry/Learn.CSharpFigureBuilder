using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFigureBuilder.ConsoleApp
{
    class Program
    {
        // I moved my user defined functions into "Functions" Class
        // I will try to handle the builder function
        //static void Builder(int Length, string Shape, string BuildingBlock)
        //{
        //    int Len = Length;
        //    string BB = BuildingBlock;
        //    string Output = "";
        //    bool Success = true;
        //    switch (Shape)
        //    {
        //        case "1":  // triangle 
        //            WriteCLine("Would you like to have your triangle Inverted? Y/N: ", newline: false);
        //            string Inversion = ReadCLine(ConsoleColor.Yellow).ToUpper();
        //            switch (Inversion)
        //            {
        //                case "Y":  // inverted (Triangle)
        //                    WriteCLine("Would you like to have your triangle Filled? Y/N: ", newline: false);
        //                    string Filled = ReadCLine(ConsoleColor.Yellow).ToUpper();
        //                    switch (Filled)
        //                    {
        //                        case "Y":  // Filled
        //                            for (int row = Len; row > 0; row--)
        //                            {
        //                                for (int spaces = Len - row; spaces > 0; spaces--)  // spacer
        //                                    Output += " ";

        //                                for (int block = 0; block < row; block++)
        //                                    Output += BB;

        //                                for (int RHS = 0; RHS < row - 1; RHS++)  // after centerline
        //                                    Output += BB;
        //                                Output += "\n";
        //                            }
        //                            WriteCLine($"An Inverted, '{BB}' Filled Triangle of Height: {Len}");
        //                            break;
        //                        case "N":  // Unfilled
        //                            for (int row = Len; row > 0; row--)
        //                            {
        //                                if (row == Len)
        //                                {
        //                                    for (int BaseWidth = 1; BaseWidth < row * 2; BaseWidth++)  // if x = 5, base = 9: 4 - center - 4
        //                                        Output += BB;
        //                                    Output += "\n";
        //                                    continue;
        //                                }
        //                                for (int spaces = Len - row; spaces > 0; spaces--)
        //                                    Output += " ";

        //                                for (int block = 1; block < row * 2; block++)
        //                                {
        //                                    if (block == 1 || block == (row * 2) - 1)
        //                                        Output += BB;
        //                                    else
        //                                        Output += " ";
        //                                }
        //                                Output += "\n";
        //                            }
        //                            WriteCLine($"An Inverted, '{BB}' Unfilled Triangle of Height: {Len}");
        //                            break;
        //                        default:
        //                            Success = false;
        //                            WriteCLine("Invalid input, start over", ConsoleColor.Red);
        //                            break;
        //                    }
        //                    break;
        //                case "N":  // not inverted (Triangle)
        //                    WriteCLine("Would you like to have your triangle Filled? Y/N: ", newline: false);
        //                    Filled = ReadCLine(ConsoleColor.Yellow).ToUpper();
        //                    switch (Filled)
        //                    {
        //                        case "Y":  // Filled (Triangle)
        //                            for (int row = 1; row <= Len; row++)
        //                            {
        //                                for (int spaces = Len - row; spaces > 0; spaces--)
        //                                    Output += " ";

        //                                for (int block = 0; block < row; block++)
        //                                    Output += BB;

        //                                for (int RHS = 0; RHS < row - 1; RHS++)
        //                                    Output += BB;
        //                                Output += "\n";
        //                            }
        //                            WriteCLine($"A Non-Inverted, '{BB}' Filled Triangle of Height: {Len}");
        //                            break;
        //                        case "N":  // Unfilled (Triangle)
        //                            for (int row = 1; row <= Len; row++)
        //                            {
        //                                if(row == Len)
        //                                {
        //                                    for (int BaseWidth = 1; BaseWidth < row * 2; BaseWidth++)  // if x = 5, base = 9: 4 - center - 4
        //                                        Output += BB;
        //                                    break;
        //                                }
        //                                for (int spaces = Len - row; spaces > 0; spaces--)
        //                                    Output += " ";

        //                                for (int block = 1; block < row * 2; block++)
        //                                {
        //                                    if(block == 1 || block == (row * 2) - 1)  
        //                                        Output += BB;
        //                                    else
        //                                        Output += " ";
        //                                }
        //                                Output += "\n";
        //                            }
        //                            WriteCLine($"A Non-Inverted, '{BB}' Unfilled Triangle of Height: {Len}");
        //                            break;
        //                        default:
        //                            Success = false;
        //                            WriteCLine("Invalid input, start over", ConsoleColor.Red);
        //                            break;
        //                    }
        //                    break;
        //                default:
        //                    Success = false;
        //                    WriteCLine("Invalid input, start over", ConsoleColor.Red);
        //                    break;
        //            }
        //            break;

        //        case "2": // Diamond
        //            WriteCLine("Would you like to have your Diamond Filled? Y/N: ", newline: false);
        //            string FilledD = ReadCLine(ConsoleColor.Yellow).ToUpper();
        //            switch (FilledD)
        //            {
        //                case "Y":  // Filled Extra
        //                    for (int row = 1; row <= Len; row++)
        //                    {
        //                        for (int spaces = Len - row; spaces > 0; spaces--)
        //                            Output += " ";

        //                        for (int block = 0; block < row; block++)
        //                            Output += BB;

        //                        for (int RHS = 0; RHS < row - 1; RHS++)
        //                            Output += BB;
        //                        Output += "\n";
        //                    }
        //                    for (int row = Len - 1; row > 0; row--)
        //                    {
        //                        for (int spaces = Len - row; spaces > 0; spaces--)  // spacer
        //                            Output += " ";

        //                        for (int block = 0; block < row; block++)
        //                            Output += BB;

        //                        for (int RHS = 0; RHS < row - 1; RHS++)  // after centerline
        //                            Output += BB;
        //                        Output += "\n";
        //                    }
        //                    WriteCLine($"An Unfilled {BB} Diamond with a height of {Len} from the center");
        //                    break;
        //                case "N":  // Unfilled
        //                    for (int row = 1; row <= Len; row++)
        //                    {
        //                        for (int spaces = Len - row; spaces > 0; spaces--)
        //                            Output += " ";

        //                        for (int block = 1; block < row * 2; block++)
        //                        {
        //                            if (block == 1 || block == (row * 2) - 1)
        //                                Output += BB;
        //                            else
        //                                Output += " ";
        //                        }
        //                        Output += "\n";
        //                    }
        //                    for (int row = Len - 1; row > 0; row--)
        //                    {
        //                        for (int spaces = Len - row; spaces > 0; spaces--)
        //                            Output += " ";

        //                        for (int block = 1; block < row * 2; block++)
        //                        {
        //                            if (block == 1 || block == (row * 2) - 1)
        //                                Output += BB;
        //                            else
        //                                Output += " ";
        //                        }
        //                        Output += "\n";
        //                    }
        //                    WriteCLine($"An Unfilled {BB} Diamond of a height of {Len} from the core");
        //                    break;
        //                default:
        //                    Success = false;
        //                    WriteCLine("Invalid input, start over", ConsoleColor.Red);
        //                    break;           
        //            }
        //            break;
        //        default:
        //            Success = false;
        //            WriteCLine("Invalid input, start over", ConsoleColor.Red);
        //            break;
        //    }
        //    Spammer('*', 54, ConsoleColor.Yellow);
        //    if(Success)
        //    {
        //        Spammer('-', 54);
        //        WriteCLine($"\n{Output}", ConsoleColor.Green);
        //        Spammer('-', 54);
        //    }

        //}
        static void Main(string[] args)
        {
            Console.Title = "ShapeBuilder";
            Functions fun = new();
            fun.WriteCLine("");
            fun.Spammer('*', 54, ConsoleColor.Cyan);
            fun.WriteCLine("  SHAPE BUILDER CLI\n  This Program will prompt you to choose a character\n  Specify the Length\n  Pick a shape \n  Indicate whether it's Inverted or not \n  And indicate whether it's filled or not");
            fun.Spammer('*', 54, ConsoleColor.Cyan);
            fun.WriteCLine("");

            bool Again = true;
            while(Again)
            {
                fun.Spammer('*', 54, ConsoleColor.Yellow);
                fun.WriteCLine("Please insert the length of your desired shape: ", newline: false);
                string Length = fun.ReadCLine(ConsoleColor.Yellow);
                fun.Spammer('*', 54, ConsoleColor.Yellow);
                int ParsedLength = fun.intValidator(Length);
                if (ParsedLength == 0)
                {
                    fun.WriteCLine("Invalid length, start over", ConsoleColor.Red);
                    return;
                }
                else
                {
                    fun.Spammer('*', 54, ConsoleColor.Yellow);
                    fun.WriteCLine("Insert the char to be used as the building block: ", newline: false);
                    string BuildingBlock = fun.ReadCLine(ConsoleColor.Yellow, true);
                    fun.Spammer('*', 54, ConsoleColor.Yellow);

                    fun.Spammer('*', 54, ConsoleColor.Yellow);
                    fun.WriteCLine("Choose one from the listed shapes: \n  --[1] Triangle [1]-- \n  --[2] Diamond  [2]-- ");
                    fun.WriteCLine("Insert your option: ", newline: false);
                    string Shape = fun.ReadCLine(ConsoleColor.Yellow, true);
                    if (Shape != "1" && Shape != "2")
                    {
                        fun.WriteCLine("Invalid input, start over", ConsoleColor.Red);
                        return;
                    }
                    fun.Spammer('*', 54, ConsoleColor.Yellow);

                    //Builder(ParsedLength, Shape, BuildingBlock);

                    fun.WriteCLine("Would you like to Create Another Shape? Y/N: ", newline: false);
                    string Another = fun.ReadCLine(ConsoleColor.Yellow).ToUpper();
                    if (Another == "Y")
                        Again = true;  // useless line but I gotta do it
                    else if (Another == "N")
                        Again = false;
                    else
                    {
                        fun.WriteCLine("Invalid input, start over", ConsoleColor.Red);
                        return;
                    }
                }
            }
            fun.WriteCLine("That's it, press any key to end the program: ", ConsoleColor.Cyan, false);
            Console.ReadKey();
        }
    }
}

