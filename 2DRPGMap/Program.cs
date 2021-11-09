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

        static void DisplayMap()
        {
            rows = map.GetLength(0);
            cols = map.GetLength(1);


            //for (int d = 0; d < cols; d++)
            //{
            //    Console.Write("-");                
            //}
            //Console.WriteLine();
            
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    char element = map[y, x];
                    Console.Write(element);
                }
                Console.WriteLine();
            }

            //for (int e = 0; e < cols; e++)
            //{
            //    Console.Write("-");
            //}
        }

        

        static void DisplayMap(int scale)
        {
            rows = map.GetLength(0);
            cols = map.GetLength(1);
            
            Console.SetWindowSize((cols * scale), (rows * scale));
            Console.SetBufferSize((cols * scale), (rows * scale));

            //Console.WriteLine("+");
            //for (int c = 0; c < rows; c++)
            //{
            //    Console.Write("­­­­­­a");
            //}


            for (int y = 0; y < rows; y++)
            {
                for (int a = 0; a < scale; a++)
                {
                    for (int x = 0; x < cols; x++)
                    {
                        for (int b = 0; b < scale; b++)
                        {
                            {                                
                                char element = map[y, x];
                                Console.Write(element);
                            }
                        }
                    }
                }     
            }
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
