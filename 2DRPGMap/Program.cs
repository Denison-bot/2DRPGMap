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

        static void SetColor(int y, int x)
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

        static void DisplayMapStatic()
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
                    SetColor(x, y);
                    char element = map[y, x];
                    Console.Write(element);
                    Console.ResetColor();
                }
                Console.Write("│");
                Console.WriteLine();
            }
            Console.Write("└" + new string('─', cols) + "┘");
            Console.WriteLine();
            Console.ReadKey(true);
        }
        
        static void DisplayMapScaled(int scale)
        {
            Console.Clear();
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
                                SetColor(x, y);
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
            Console.ReadKey(true);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("map legend:");
            Console.WriteLine("^ = mountain");
            Console.WriteLine("' = grass");
            Console.WriteLine("~ = water");
            Console.WriteLine("* = trees");
            Console.WriteLine();

            Console.WriteLine("Open in full screen for best view");
            Console.WriteLine();
            Console.WriteLine("Press any key to display maps");
            Console.WriteLine();

            Console.ReadKey(true);

            DisplayMapStatic();
            DisplayMapScaled(2);
            DisplayMapScaled(3);
            DisplayMapScaled(4);
            DisplayMapScaled(5);
        }
    }
}
