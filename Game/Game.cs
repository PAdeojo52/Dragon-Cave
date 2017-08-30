using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Dragon_Cave
{
    class Game
    {
        Dragon Dragon;
        Entrance Entrance;
        Pit Pit1;
        Pit Pit2;
        Pit Pit3;
        Gold Gold;
        Player Player;
        String UserInput;
        Room[,] RoomSet;
        Dialouge dio;
        PlayerController PC;
        String Input;



        public Game(Room[,] RoomSet)
        {
            this.RoomSet = RoomSet;
            Dragon = new Dragon();
            Entrance = new Entrance();
            Pit1 = new Pit();
            Pit2 = new Pit();
            Pit3 = new Pit();
            Gold = new Gold();
            Player = new Player(this.RoomSet);
            dio = new Dialouge();
            PC = new PlayerController(Player);
            Input = " ";


        }

        internal Dragon Dragon1 { get => Dragon; set => Dragon = value; }
        internal Entrance Entrance1 { get => Entrance; set => Entrance = value; }
        internal Pit Pit11 { get => Pit1; set => Pit1 = value; }
        internal Pit Pit21 { get => Pit2; set => Pit2 = value; }
        internal Pit Pit31 { get => Pit3; set => Pit3 = value; }
        internal Gold Gold1 { get => Gold; set => Gold = value; }
        public string UserInput1 { get => UserInput; set => UserInput = value; }
        internal Player Player1 { get => Player; set => Player = value; }
        internal Room[,] RoomSet1 { get => RoomSet; set => RoomSet = value; }


        public void StartGame()
        {
            
            SetDragon(Dragon1);
            SetEntrance(Entrance1);
            SetGold(Gold1);
            SetPit(Pit11);
            FillInTheBlank();
            SetPlayer(Player1);


            Console.WriteLine("Welcome to Dragon Cave!");
            Console.WriteLine("Try to find the gold and return here to climb back out.");
            Console.WriteLine("You have 1 arrow that you can shoot.");
            Console.WriteLine("Try the following commands:");
            Console.WriteLine("Move (F)orward, Turn (L)eft, Turn (R)ight,");
            Console.WriteLine("(G)rab the Gold, (S)hoot the Arrow, (C)limb out.");
            Console.WriteLine("(Q)uit the game, Use (X) to cheat.");


            for(int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    Console.Write(RoomSet1[x, y].Id );
                }
                Console.WriteLine(" ");
            }


            while (Player1.Death1 == false)
            {


                Console.WriteLine(dio.Direction1 + Player1.PlayerDirection);

                Console.WriteLine("Please enter move");


                PC.PleyerMovement(Input, RoomSet1);

            }


        }



        public void SetDragon(Dragon dragon)
        {

            Random rndx = new Random();
            Random rndy = new Random();

            if (dragon.IsPlaced1 == false)
            {


                int x = rndx.Next(0, 3);
                int y = rndy.Next(0, 3);
                if (RoomSet1[x, y] == null)
                {
                    dragon.DX1 = x;
                    dragon.DY1 = y;
                    RoomSet1[x, y] = dragon;
                    Console.WriteLine(x + " " + y);

                    // IsThereDragon = true;
                }
                else
                {
                    SetDragon(dragon);
                }
            }

        }
        public void SetEntrance(Entrance entrance)
        {

            Random rndx = new Random();
            Random rndy = new Random();

            if (entrance.IsPlaced1 == false)
            {


                int x = rndx.Next(0, 3);
                int y = rndy.Next(0, 3);
                if (RoomSet1[x, y] == null)
                {
                    entrance.EX1 = x;
                    entrance.EY1 = y;
                    RoomSet1[x, y] = entrance;
                    Console.WriteLine(x + " " + y);

                    // IsThereDragon = true;
                }
                else
                {
                    SetEntrance(entrance);
                }
            }
        }


        public void SetGold(Gold gold)
        {

            Random rndx = new Random();
            Random rndy = new Random();

            if (gold.IsPlaced1 == false)
            {


                int x = rndx.Next(0, 3);
                int y = rndy.Next(0, 3);
                if (RoomSet1[x, y] == null)
                {
                    gold.GX1 = x;
                    gold.GY1 = y;
                    RoomSet1[x, y] = gold;
                    Console.WriteLine(x + " " + y);

                    // IsThereDragon = true;
                }
                else
                {
                    SetGold(gold);
                }
            }
        }

        public void SetPit(Pit pit)
        {

            Random rndx = new Random();
            Random rndy = new Random();

            if (pit.IsPlaced1 == false)
            {


                int x = rndx.Next(0, 3);
                int y = rndy.Next(0, 3);
                if (RoomSet1[x, y] == null)
                {
                    pit.PX1 = x;
                    pit.PY1 = y;
                    RoomSet1[x, y] = pit;
                    Console.WriteLine(x + " " + y);

                    // IsThereDragon = true;
                }
                else
                {
                    SetPit(pit);
                }
            }
        }

        public void Death()
        {
            Console.WriteLine("You have Died");
            Player.Death1 = true;

        }


        public void FillInTheBlank()
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (RoomSet1[x, y] == null)
                    {


                        EmptyRoom Dummy = new EmptyRoom();
                        Dummy.DX1 = x;
                        Dummy.DY1 = y;

                        RoomSet1[x, y] = Dummy;

                        // Room Dummy = new Room();
                    }
                }
            }
        }


        public void SetPlayer(Player player)
        {
            Random rndx = new Random();
            Random rndy = new Random();

            if (player.IsPlayerEntraceSet == false)
            {


                int x = rndx.Next(0, 3);
                int y = rndy.Next(0, 3);
                if (RoomSet1[x, y].Id == ".")
                {
                    player.XPlayerPosition = x;
                    player.YPlayerPosition = y;
                    RoomSet1[x, y].Id = RoomSet1[x, y].Id + "P";
                    Console.WriteLine(x + " " + y);

                    // IsThereDragon = true;
                }
                else
                {
                    SetPlayer(player);
                }
            }



        }

        public void RoomLogic()
        {


        }


    }
}
