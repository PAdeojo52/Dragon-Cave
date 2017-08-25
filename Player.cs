using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Cave
{
    class Player
    {
        private String[,] board;
        private int xPlayerPosition;
        private int yPlayerPosition;
        private String playerController;
        private String playerDirection;
        private String playerArrow;
        private bool Death = false;
        private bool isPlayerEntraceSet = false;
        

        public Player(string[,] board)
        {
            this.board = board;
        }

        public String PlayerController { get => playerController; set => playerController = value; }
        public string PlayerDirection { get => playerDirection; set => playerDirection = value; }
        public string PlayerArrow { get => playerArrow; set => playerArrow = value; }
        public bool Death1 { get => Death; set => Death = value; }
        public String[,] Board { get => board; set => board = value; }
        public int YPlayerPosition { get => yPlayerPosition; set => yPlayerPosition = value; }
        public int XPlayerPosition { get => xPlayerPosition; set => xPlayerPosition = value; }

        public void PlayerEntrance()
        {
            Random rndx = new Random();
            Random rndy = new Random();

            if(isPlayerEntraceSet == false)
            {
                int x = rndx.Next(0, 3);
                int y = rndy.Next(0, 3);
                //int xHolder = x;
               // int yHiolder = y;

                if (Board[x,y] == null)
                {
                    XPlayerPosition = x;
                    YPlayerPosition = y;

                    Board[x, y] = "P";
                    PlayerDirection = "East";
                    Console.WriteLine("player : "+x + " " + y);
                    isPlayerEntraceSet = true;

                }
                else
                {
                    PlayerEntrance();
                }
               
            }


        }

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
                        if(Board[XPlayerPosition,YPlayerPosition].EndsWith("P"))
                        {
                            Board[XPlayerPosition, YPlayerPosition].TrimEnd('P');
                            Board[XPlayerPosition, YPlayerPosition] = ".";

                        }
                        XPlayerPosition = XPlayerPosition - 1;
                        Board[XPlayerPosition, YPlayerPosition] = Board[XPlayerPosition, YPlayerPosition] + "P";
                    }
                    else if(PlayerDirection == "North")
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
                    if(PlayerDirection == "Right")
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
            catch(System.IndexOutOfRangeException)
            {
                if(XPlayerPosition > 3)
                {
                    XPlayerPosition = XPlayerPosition- 1;
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


        public void PlayerDeath()
        {
            if (Board[XPlayerPosition, YPlayerPosition] == "Dragon")
            {
                Death1 = true;
            }
            if(Board[XPlayerPosition, YPlayerPosition] == "Pit")
            {
                Death1 = true;
            }

        }
    }
}
