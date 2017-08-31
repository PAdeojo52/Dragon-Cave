using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Cave
{
    class PlayerController
    {
        Player playmovement;
        Dialouge dio;
        //Gold gol;

        public PlayerController(Player play)
        {

            this.playmovement = play;
            dio = new Dialouge();
           // gol = new Gold();
        }

        internal Player Playmovement { get => playmovement; set => playmovement = value; }
        internal Dialouge Dio { get => dio; set => dio = value; }
       // internal Gold Gol { get => gol; set => gol = value; }

        public void PleyerMovement(String s, Room[,] map ,Gold Gol,Dragon Dragon)
        {
            s = Console.ReadLine();




            if (s == "X" || s == "x")
            {
                Console.WriteLine(Dio.YouAreIn1 + "X: " + Playmovement.XPlayerPosition + " Y: " + Playmovement.YPlayerPosition);
                Console.WriteLine("");
                for (int x = 0; x < 4; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        //Console.WriteLine(x);
                        Console.Write(map[x, y].Id /*+ " " + "X: " + x + "Y: " + y*/ );
                    }
                    Console.WriteLine(" ");
                }


            }
            //


            else if (s == "l" || s == "L")
            {
                if (Playmovement.PlayerDirection == "East")
                {
                    Playmovement.PlayerDirection = "North";
                }
                else if (Playmovement.PlayerDirection == "North")
                {
                    Playmovement.PlayerDirection = "West";
                }
                else if (Playmovement.PlayerDirection == "West")
                {
                    Playmovement.PlayerDirection = "South";
                }
                else if (Playmovement.PlayerDirection == "South")
                {
                    Playmovement.PlayerDirection = "East";
                }
            }
            ///


            else if (s == "r" || s == "R")
            {
                if (Playmovement.PlayerDirection == "East")
                {
                    Playmovement.PlayerDirection = "South";

                }
                else if (Playmovement.PlayerDirection == "South")
                {
                    Playmovement.PlayerDirection = "West";
                }
                else if (Playmovement.PlayerDirection == "West")
                {
                    Playmovement.PlayerDirection = "North";
                }
                else if (Playmovement.PlayerDirection == "North")
                {
                    Playmovement.PlayerDirection = "East";
                }

            }

            ///
            else if (s == "Q" || s == "q")
            {
                Console.WriteLine(Dio.Quitter1);
                Environment.Exit(0);

            }
            ///



            else if (s == "F" || s == "f")
            {


                if (Playmovement.PlayerDirection == "East")
                {

                    if (Playmovement.XPlayerPosition == 4)
                    {
                        Console.WriteLine(dio.YouHitAWall1);
                        //Playmovement.XPlayerPosition = Playmovement.XPlayerPosition - 1;

                    }
                    else if (Playmovement.XPlayerPosition <= 3)
                    {
                        Playmovement.XPlayerPosition = Playmovement.XPlayerPosition + 1;
                        Console.WriteLine(dio.YouWalkIntoNextRoom1);
                    }


                }



                else if (Playmovement.PlayerDirection == "West")
                {

                    if (Playmovement.XPlayerPosition == 0)
                    {
                        Console.WriteLine(dio.YouHitAWall1);
                        //Playmovement.XPlayerPosition = Playmovement.XPlayerPosition - 1;

                    }
                    else if (Playmovement.XPlayerPosition >= 0)
                    {
                        Playmovement.XPlayerPosition = Playmovement.XPlayerPosition - 1;
                        Console.WriteLine(dio.YouWalkIntoNextRoom1);
                    }
                }





                else if (Playmovement.PlayerDirection == "North")
                {

                    if(Playmovement.YPlayerPosition ==0)
                    {
                        Console.WriteLine(dio.YouHitAWall1);
                    }
                    else if (Playmovement.YPlayerPosition > 0)
                    {
                        Playmovement.YPlayerPosition = Playmovement.YPlayerPosition - 1;
                        Console.WriteLine(dio.YouWalkIntoNextRoom1);

                    }
                }

                else if (Playmovement.PlayerDirection == "South")
                {
                   

                    if (Playmovement.XPlayerPosition == 4)
                    {
                        Console.WriteLine(dio.YouHitAWall1);
                    }
                    else if (Playmovement.YPlayerPosition <= 3)
                    {
                        Playmovement.YPlayerPosition = Playmovement.YPlayerPosition + 1;
                        Console.WriteLine(dio.YouWalkIntoNextRoom1);
                    }

                    
                }
            }
            else if (s =="G" || s == "g")
            {
                if (map[Playmovement.XPlayerPosition, Playmovement.YPlayerPosition] == Gol && Gol.isGoldPicked == false)
                {
                    Gol.isGoldPicked = true;
                    Gol.Id = ".";
                    Console.WriteLine(Dio.YouGotTheGold1);
                }

            }
            else if(s == "S" || s== "s")
            {

                if (Playmovement.XPlayerPosition  == Dragon.DX1 || Playmovement.YPlayerPosition == Dragon.DY1 && Dragon.IsDragonDead==false)
                {
                    Dragon.IsDragonDead = true;
                    Dragon.Id = ".";

                }

            }
            else if (s == "C" || s == "c")
            {

                if(Gol.isGoldPicked == true && Dragon.IsDragonDead == true)
                {
                    Console.WriteLine(Dio.Winnner);
                    Environment.Exit(0);
                }
                else if(Dragon.IsDragonDead == true && Gol.isGoldPicked == false)
                {
                    Console.WriteLine(dio.FoundEntranceWitoutGold1);

                }
                else if (Dragon.IsDragonDead == false && Gol.isGoldPicked == true)
                {
                    Console.WriteLine(dio.StillDragon1);
                }

            }

           



        }






        }


        /*
public void PlayerMovement()
{

Console.WriteLine("Please Input movement command");

PlayerController = Console.ReadLine();
try
{
if (PlayerController == "F")
{
if (PlayerDirection == "Right")
{
if (Board[XPlayerPosition, YPlayerPosition].EndsWith("P"))
{
Board[XPlayerPosition, YPlayerPosition].TrimEnd('P');
Board[XPlayerPosition, YPlayerPosition] = ".";

}
XPlayerPosition = XPlayerPosition + 1;
Board[XPlayerPosition, YPlayerPosition] = Board[XPlayerPosition, YPlayerPosition] + "P";
}
else if (PlayerDirection == "Left")
{
if (Board[XPlayerPosition, YPlayerPosition].EndsWith("P"))
{
Board[XPlayerPosition, YPlayerPosition].TrimEnd('P');
Board[XPlayerPosition, YPlayerPosition] = ".";

}
XPlayerPosition = XPlayerPosition - 1;
Board[XPlayerPosition, YPlayerPosition] = Board[XPlayerPosition, YPlayerPosition] + "P";
}
else if (PlayerDirection == "North")
{
if (Board[XPlayerPosition, YPlayerPosition].EndsWith("P"))
{
Board[XPlayerPosition, YPlayerPosition].TrimEnd('P');
Board[XPlayerPosition, YPlayerPosition] = ".";

}
YPlayerPosition = YPlayerPosition + 1;
Board[XPlayerPosition, YPlayerPosition] = Board[XPlayerPosition, YPlayerPosition] + "P";
}
else if (PlayerDirection == "South")
{
if (Board[XPlayerPosition, YPlayerPosition].EndsWith("P"))
{
Board[XPlayerPosition, YPlayerPosition].TrimEnd('P');
Board[XPlayerPosition, YPlayerPosition] = ".";

}
YPlayerPosition = YPlayerPosition - 1;
Board[XPlayerPosition, YPlayerPosition] = Board[XPlayerPosition, YPlayerPosition] + "P";

}

}
else if (PlayerController == "L")
{
if (PlayerDirection == "Right")
{
PlayerDirection = "North";
}
else if (PlayerDirection == "North")
{
PlayerDirection = "Left";
}
else if (PlayerDirection == "Left")
{
PlayerDirection = "South";
}
if (PlayerDirection == "South")
{
PlayerDirection = "Right";
}


}
else if (PlayerController == "R")
{
if (PlayerDirection == "Right")
{
PlayerDirection = "South";
}
else if (PlayerDirection == "North")
{
PlayerDirection = "Right";
}
else if (PlayerDirection == "North")
{
PlayerDirection = "South";
}
if (PlayerDirection == "South")
{
PlayerDirection = "Left";
}
}
else if (PlayerController == "Q")
{
Environment.Exit(0);

}
else if (playerController == "G")
{
if (board[XPlayerPosition, YPlayerPosition] == "Gold")
{
Console.WriteLine("Gold has been grabbed");
board[XPlayerPosition, YPlayerPosition] = ".";
}
}
else if (PlayerController == "S")
{
if (PlayerDirection == "East")
{
if (XPlayerPosition < 3)
{
for (int arrowDirection = XPlayerPosition; arrowDirection < 3; arrowDirection++)
{
if (Board[arrowDirection, YPlayerPosition] == "Dragon")
{
Console.WriteLine("You have killed the dragon");


Board[arrowDirection, YPlayerPosition] = ".";
}

}
}
}
}
else if (PlayerController == "X")
{
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
catch (System.IndexOutOfRangeException)
{
if (XPlayerPosition > 3)
{
XPlayerPosition = XPlayerPosition - 1;
Console.WriteLine("You walked into a wall");
}
else if (XPlayerPosition < 0)
{
XPlayerPosition = XPlayerPosition + 1;
Console.WriteLine("You walked into a wall");
}
else if (YPlayerPosition < 0)
{
YPlayerPosition = YPlayerPosition + 1;
Console.WriteLine("You walked into a wall");
}
else if (YPlayerPosition > 3)
{
YPlayerPosition = YPlayerPosition - 1;
Console.WriteLine("You walked into a wall");
}
}

}

*/




        }

