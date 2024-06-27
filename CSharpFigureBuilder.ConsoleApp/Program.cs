using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFigureBuilder.ConsoleApp
{
    class Program
    {
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
                int ParsedLength = fun.intValidator(Length);
                if (ParsedLength == 0)
                {
                    fun.WriteCLine("Invalid length, start over", ConsoleColor.Red);
                    return;
                }
                else
                {
                    fun.Spammer('*', 54, ConsoleColor.Yellow);
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


                    string shapename = "";
                    if (Shape == "1")
                    {
                        shapename = "Triangle";
                        fun.WriteCLine($"Would you like to have your {shapename} Inverted? Y/N: ", newline: false);
                        string Inversion = fun.ReadCLine(ConsoleColor.Yellow).ToUpper();
                        bool isInverted = fun.YNValidator(Inversion);
                        string InversionStatus = isInverted ? "n Inverted" : " Non-Inverted";

                        fun.WriteCLine($"Would you like to have your {shapename} Filled? Y/N: ", newline: false);
                        string Filled = fun.ReadCLine(ConsoleColor.Yellow).ToUpper();
                        bool isFilled = fun.YNValidator(Filled);
                        string FillStatus = isFilled ? "Filled" : "Unfilled";
                        Figure Fig = new(ParsedLength, BuildingBlock, Shape, isInverted, isFilled);
                        fun.Spammer('*', 54, ConsoleColor.Yellow);
                        fun.WriteCLine($"A{InversionStatus}, '{BuildingBlock}' {FillStatus} {shapename} of Height: {ParsedLength}");
                        
                        fun.Spammer('-', 54);
                        fun.WriteCLine($"\n{Fig.BuildFigure()}", ConsoleColor.Green);
                        fun.Spammer('-', 54);
                    }
                    else if (Shape == "2")
                    {
                        shapename = "Diamond";
                        fun.WriteCLine($"Would you like to have your {shapename} Filled? Y/N: ", newline: false);
                        string Filled = fun.ReadCLine(ConsoleColor.Yellow).ToUpper();
                        bool isFilled = fun.YNValidator(Filled);
                        string FillStatus = isFilled ? " Filled" : "n Unfilled";
                        Figure Fig = new(ParsedLength, BuildingBlock, Shape, isFilled);
                        fun.Spammer('*', 54, ConsoleColor.Yellow);
                        fun.WriteCLine($"A{FillStatus} '{BuildingBlock}' {shapename} with centerline width of {ParsedLength}: ");

                        fun.Spammer('-', 54);
                        fun.WriteCLine($"\n{Fig.BuildFigure()}", ConsoleColor.Green);
                        fun.Spammer('-', 54);
                    }
                        
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
