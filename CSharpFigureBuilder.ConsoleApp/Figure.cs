using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharpFigureBuilder.ConsoleApp
{
    public class Figure
    {
        public int Length { get; set; }
        public string BuildingBlock { get; set; }
        public string Shape { get; set; }
        public bool Inverted { get; set; }
        public bool Filled { get; set; }

        public Figure(int Len, string BBlock, string shape, bool Inversion, bool Fill)
        {
            Length = Len;
            BuildingBlock = BBlock;
            Shape = shape;
            Inverted = Inversion;
            Filled = Fill;
        }

        // gotta scrap this approach it's still verbose

        public string BuildFigure()
        {
            switch (Shape)
            {
                case "1":  // Triangle
                    if (Inverted)
                        return BuildInvertedTriangle();
                    else
                        return BuildNonInvertedTriangle();
                case "2":  // Diamond
                    return BuildDiamond();
                default:
                    return "Invalid shape! Start over";
            }
        }
        public string BuildNonInvertedTriangle()
        {
            string Output = "";
            if (Filled)  // Filled (Triangle)
            {
                for (int row = 1; row <= Length; row++)
                {
                    for (int spaces = Length - row; spaces > 0; spaces--)
                        Output += " ";


                    for (int block = 0; block < row; block++)
                        Output += BuildingBlock;

                    for (int RHS = 0; RHS < row - 1; RHS++)
                        Output += BuildingBlock;
                    Output += "\n";
                }
                return Output;
            }
            else  // Unfilled (Triangle)
            {
                for (int row = 1; row <= Length; row++)
                {
                    if (row == Length)
                    {
                        for (int BaseWidth = 1; BaseWidth < row * 2; BaseWidth++)  // if x = 5, base = 9: 4 - center - 4
                            Output += BuildingBlock;
                        break;
                    }
                    for (int spaces = Length - row; spaces > 0; spaces--)
                        Output += " ";

                    for (int block = 1; block < row * 2; block++)
                    {
                        if (block == 1 || block == (row * 2) - 1)
                            Output += BuildingBlock;
                        else
                            Output += " ";
                    }
                    Output += "\n";
                }
                return Output;
            }

            


            // func Tri invert >> filled or unfilled

            // funt Diamond >> filled(extra) or unfilled


        }
        public string BuildInvertedTriangle()
        {
            return "placeholder for now";
        }
        public string BuildDiamond()
        {
            return "placeholder for now";
        }
    }
}
