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
            playerSet.PlayerDirection = "East";

            Console.WriteLine("Welcome to Dragon Cave!");
            Console.WriteLine("Try to find the gold and return here to climb back out.");
            Console.WriteLine("You have 1 arrow that you can shoot.");
            Console.WriteLine("Try the following commands:");
            Console.WriteLine("Move (F)orward, Turn (L)eft, Turn (R)ight,");
            Console.WriteLine("(G)rab the Gold, (S)hoot the Arrow, (C)limb out.");
            Console.WriteLine("(Q)uit the game, Use (X) to cheat.");








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

                Console.WriteLine("Direction: " + playerSet.PlayerDirection);
                
                Console.WriteLine("");
                playerSet.PlayerMovement();


            }




}
}
}
