﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFigureBuilder.ConsoleApp
{
    public class Functions
    {
        public int intValidator(string input)
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
        public void WriteCLine(string text, ConsoleColor color = ConsoleColor.White, bool newline = true)
        {
            Console.ForegroundColor = color;
            if (newline)
                Console.WriteLine(text);
            else
                Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public string ReadCLine(ConsoleColor color = ConsoleColor.White, bool single = false)
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
        public void Spammer(char sign, int len, ConsoleColor Color = ConsoleColor.White) // * input prompt, - output   char len color
        {
            Console.ForegroundColor = Color;
            string output = "";
            for (int i = 0; i < len; i++)
                output += sign;
            Console.WriteLine(output);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public bool YNValidator(string Choice)
        {
            if (Choice == "Y")
                return true;
            else if (Choice == "N")
                return false;
            else
            {
                WriteCLine("Invalid input, start over", ConsoleColor.Red);
                Environment.Exit(0);
                return false;
            }
        }
    }
}
