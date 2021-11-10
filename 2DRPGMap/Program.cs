using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DRPGMap
{
    class Program
    {
        static int rows;
        static int cols;
        static int scale;

        static char[,] map = new char[12,30] // dimensions defined by following data:
        {
        {'^','^','^','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'^','^','\'','\'','\'','\'','*','*','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','~','~','~','\'','\'','\''},
        {'^','^','\'','\'','\'','*','*','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','~','~','~','\'','\'','\'','\'','\''},
        {'^','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','~','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','^','^','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','\'','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','^','^','^','^','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','\'','~','~','~','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','^','^','^','^','\'','\'','\''},
        {'\'','\'','\'','\'','\'','\'','\'','~','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        {'\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\'','\''},
        };

        static void Colors(int y, int x)
        {
            if (map[x, y] == '\'')
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (map[x, y] == '^')
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            else if (map[x, y] == '~')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (map[x, y] == '*')
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        static void DisplayMap()
        {
            

            rows = map.GetLength(0);
            cols = map.GetLength(1);

            Console.Write("┌" + new string('─', cols) + "┐");
            Console.WriteLine();
            for (int y = 0; y < rows; y++)
            {
                Console.Write("│");
                for (int x = 0; x < cols; x++)
                {
                    Colors(x, y);
                    char element = map[y, x];
                    Console.Write(element);
                    Console.ResetColor();
                }
                Console.Write("│");
                Console.WriteLine();
            }
            Console.Write("└" + new string('─', cols) + "┘");
            Console.WriteLine();
        }
        
        static void DisplayMap(int scale)
        {
            rows = map.GetLength(0);
            cols = map.GetLength(1);
            
            Console.SetWindowSize((cols * scale) + 2, (rows * scale) + 3);
            Console.SetBufferSize((cols * scale) + 2, (rows * scale) + 3);

            Console.Write("┌" + new string('─', cols*scale) + "┐");
            
            for (int y = 0; y < rows; y++)
            {
                for (int a = 0; a < scale; a++) //scale
                {
                    Console.Write("│");
                    for (int x = 0; x < cols; x++)
                    {
                        for (int b = 0; b < scale; b++) //scale
                        {
                            {
                                Colors(x, y);
                                char element = map[y, x];
                                Console.Write(element);
                                Console.ResetColor();
                            }
                        }
                    }
                    Console.Write("│");
                }               
            }
            Console.Write("└" + new string('─', cols * scale) + "┘");
        }

        static void Main(string[] args)
        {
            
            //set map scale
            scale = 3;

            Console.WriteLine("map legend:");
            Console.WriteLine("^ = mountain");
            Console.WriteLine("' = grass");
            Console.WriteLine("~ = water");
            Console.WriteLine("* = trees");
            Console.WriteLine();

            Console.ReadKey(true);

            DisplayMap();

            Console.ReadKey(true);

            DisplayMap(scale);

            Console.ReadKey(true);
        }
    }
}
