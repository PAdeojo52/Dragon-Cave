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

            if (PlayerController == "F")
            {
                if(PlayerDirection == "Right")
                {
                    XPlayerPosition = XPlayerPosition + 1;
                }
                else if(PlayerDirection == "Left")
                {
                    XPlayerPosition = XPlayerPosition - 1;
                }
                
            }
            else if (PlayerController == "L")
            {
                PlayerDirection = "Left";

            }
            else if (PlayerController == "R")
            {
                PlayerDirection = "Right";
            }
            else if (PlayerController == "Q")
            {
                Environment.Exit(0);

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
    }
}
