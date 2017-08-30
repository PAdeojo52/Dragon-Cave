﻿using System;
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

        public PlayerController(Player play)
        {

            this.playmovement = play;
            dio = new Dialouge();
        }

        internal Player Playmovement { get => playmovement; set => playmovement = value; }
        internal Dialouge Dio { get => dio; set => dio = value; }

        public void PleyerMovement(String s , Room[,] map)
        {
            s = Console.ReadLine();
            if(s == "X" || s == "x")
            {
                for(int x = 0; x<3;x++)
                {
                    for(int y = 0; y<3; y++)
                    {
                        //Console.WriteLine(x);
                        Console.Write(map[x, y].Id + " " + "X: " + x + "Y: " + y  );
                    }
                    Console.WriteLine(" ");
                }

            }
            else if (s== "l" || s == "L")
            {
                if(Playmovement.PlayerDirection == "East")
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
            else if( s== "r" || s == "R")
            {
                if(Playmovement.PlayerDirection == "East")
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
            else if (s == "Q" || s== "q")
            {
                Environment.Exit(0);

            }
            else if(s == "F" || s == "f")
            {

                if (Playmovement.XPlayerPosition <= 4)
                {
                    if (Playmovement.PlayerDirection == "East")
                    {
                        Playmovement.XPlayerPosition = Playmovement.XPlayerPosition + 1;
                    }
                }
                else
                {
                    dio.
                }
                else if (Playmovement.PlayerDirection == "West")
                {
                    Playmovement.XPlayerPosition = Playmovement.XPlayerPosition - 1;
                }
                else if (Playmovement.PlayerDirection == "South")
                {
                    Playmovement.YPlayerPosition = Playmovement.YPlayerPosition - 1;
                }
                else if (Playmovement.PlayerDirection == "North")
                {
                    Playmovement.YPlayerPosition = Playmovement.YPlayerPosition + 1;
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
}
