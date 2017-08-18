using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Cave
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Board = new string[4, 4];

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {

                    Board[row, col] = ".";
                }

            }





            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {
                    Console.Write(Board[row, col]);
                }
                Console.WriteLine();
            }







        }
    }
}
