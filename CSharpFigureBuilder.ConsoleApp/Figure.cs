using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFigureBuilder.ConsoleApp
{
    public class Figure
    {
        // prop tab tab thank Esio
        // That's pretty much all of the properties I need to know to make a shape
        public int Length { get; set; }
        public string BuildingBlock { get; set; }
        public string Shape { get; set; }
        public bool Inverted { get; set; }
        public bool Filled { get; set; }

        // ctor tab tab
        public Figure(int Len, string BBlock, string shape, bool Inversion, bool Fill)
        {
            Length = Len;
            BuildingBlock = BBlock;
            Shape = shape;
            Inverted = Inversion;
            Filled = Fill;
        }

        // Now I gotta think of a way to sort the flow, the switch case rollercoaster is ugly
    }
}
