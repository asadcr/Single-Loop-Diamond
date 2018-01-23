using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLoopDiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int grid = 10;
            char character = '*';
            print_shape(grid, character);
        }

        static void print_shape(int grid=10, char character = '*')
        {
            int row = 0;
            int col = 0;
            int i = 1;
            while (i < (grid * grid))
            {
                if (i % grid == 0)
                    Console.WriteLine();
                else
                {
                    row = i / grid;
                    col = i - (row * grid);

                    if (row > (grid / 2))
                        row = grid - row;

                    int stars = 2 * row - 1;
                    int spaces = ((grid - (2 * (row + 1))) / 2) + 1;

                    stars += spaces;

                    if (col <= spaces)
                        Console.Write(" ");
                    else if (col <= stars)
                        Console.Write(character);
                }
                i++;
            }
            Console.ReadKey();
        }
    }
}
