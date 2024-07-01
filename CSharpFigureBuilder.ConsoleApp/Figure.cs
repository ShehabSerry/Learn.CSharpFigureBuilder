using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharpFigureBuilder.ConsoleApp
{
    public enum ShapeType // enum tab tab
    {
        Triangle,
        Diamond
    }
    public class Figure
    {
        public int Length { get; set; }
        public string BuildingBlock { get; set; }
        public ShapeType Shape { get; set; } // ceratin enums instead of random strings
        public bool Inverted { get; set; }
        public bool Filled { get; set; }

        public Figure(int Len, string BBlock, ShapeType shape, bool Inversion, bool Fill)
        {
            Length = Len;
            BuildingBlock = BBlock;
            Shape = shape;
            Inverted = Inversion;
            Filled = Fill;
        }

        // Alt Cons for diamondd
        public Figure(int Len, string BBlock, ShapeType shape, bool Fill)
        {
            Length = Len;
            BuildingBlock = BBlock;
            Shape = shape;
            Filled = Fill;
        }

        public string BuildFigure()
        {
            switch (Shape)
            {
                case ShapeType.Triangle: // enums are Just about right
                    return Filled ? BuildFilledTriangle() : BuildUnfilledTriangle();
                case ShapeType.Diamond:
                    return BuildDiamond();
                default:
                    return "Invalid shape! Start over";
            }
        }
        public string BuildFilledTriangle(bool DiamondMaker = false)
        {
            string Output = "";
            int initial = Inverted ? Length : 1;
            if (DiamondMaker && Inverted)
                initial = Length - 1;
            int stop = Inverted ? 0 : Length;  // ternary cond the result
            int step = Inverted ? -1 : 1;  // decr incr
            for (int row = initial; Inverted ? row > stop : row <= stop ; row += step)
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
        public string BuildUnfilledTriangle(bool DiamondMaker = false)
        {
            string Output = "";
            int initial = Inverted ? Length - 1 : 1;
            if (DiamondMaker && Inverted)
                initial = Length;
            int stop = Inverted ? 0 : Length - 1;
            int step = Inverted ? -1 : 1;
            if (Inverted && !DiamondMaker)
            {
                for (int BaseWidth = 1; BaseWidth < Length * 2; BaseWidth++)
                    Output += BuildingBlock;
                Output += "\n";
            }
            for (int row = initial; Inverted ? row > stop : row <= stop; row += step)
            {
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
            if (!Inverted && !DiamondMaker)
            {
                for (int BaseWidth = 1; BaseWidth < Length * 2; BaseWidth++)
                    Output += BuildingBlock;
                Output += "\n";
            }
            return Output;
        }

        public string BuildDiamond()
        {
            string Output = "";
            if (Filled)
            {
                Output += BuildFilledTriangle(true);
                Inverted = true;  // flipper 
                Output += BuildFilledTriangle(true);
            }
            else
            {
                Output += BuildUnfilledTriangle(true);
                Inverted = true;
                Output += BuildUnfilledTriangle(true);
            }
            return Output; 
        }
    }
}
