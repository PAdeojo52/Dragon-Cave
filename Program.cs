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
            
            Room[,] roomLayout = new Room[4,4];

            Game newGame = new Game(roomLayout);
            newGame.StartGame();



            //Room[] dd = new Room[3];

            //Dragon gd = new Dragon();

            /*
            Room[,] mapSet = new Room[4, 4];
            Entrance Entrance = new Entrance();
            Dragon Dragon = new Dragon();
            Gold Gold = new Gold();
            */




            // string[,] Board = new string[4, 4];





            //Player playerSet = new Player(Board);           
            // Room mapSet = new Room(Board);


            //Console.WriteLine(mapSet.IsThereDragon);
            // mapSet.SetEntrancePlace();
            //mapSet.SetDragonPlace();

            //mapSet.SetGoldPlace();
            ///mapSet.SetPitPlaces();

            // playerSet.PlayerEntrance();

            //mapSet.FillInTheBlanks();




            /*
            while (playerSet.Death1 == false)
            {
                playerSet.PlayerMovement();


            }
            */



        }
    }
}