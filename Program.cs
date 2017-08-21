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


            //Room[] dd = new Room[3];

            //Dragon gd = new Dragon();




            string[,] Board = new string[4, 4];

            Player playerSet = new Player(Board);           
            Room mapSet = new Room(Board);

          
            //Console.WriteLine(mapSet.IsThereDragon);
            mapSet.SetEntrancePlace();
            mapSet.SetDragonPlace();
           
            mapSet.SetGoldPlace();
             mapSet.SetPitPlaces();

            playerSet.PlayerEntrance();




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


            while (playerSet.Death1 == false)
            {
                playerSet.PlayerMovement();


            }




}
}
}
