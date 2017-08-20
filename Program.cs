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
            
                        
            Room mapSet = new Room(Board);


            //Console.WriteLine(mapSet.IsThereDragon);
            mapSet.SetEntrancePlace();
            mapSet.SetDragonPlace();
           
            mapSet.SetGoldPlace();
             mapSet.SetPitPlaces();





            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {

                    if (Board[row, col] == null)
                    {
                        Board[row, col] = ".";
                    }//= ".";
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
