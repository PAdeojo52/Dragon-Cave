
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Cave
{
    abstract class Room
    {
        private String[,] baseMap;

        public string id;
        // public string name;
        // public int x;
        // public int y;
        //public int px;
        //public int py;
        protected String descriptionOne;
        protected String descriptionTwo;
        protected String descriptionThree;
        private Gold gold;
        private Pit pit;
        private Dragon dragon;
        private Entrance entrance;
        //protected bool isPlaced;

        public string DescriptionOne { get => descriptionOne; set => descriptionOne = value; }
        public string DescriptionTwo { get => descriptionTwo; set => descriptionTwo = value; }
        public string DescriptionThree { get => descriptionThree; set => descriptionThree = value; }
        internal Gold Gold { get => gold; set => gold = value; }
        internal Pit Pit { get => pit; set => pit = value; }
        internal Dragon Dragon { get => dragon; set => dragon = value; }
        internal Entrance Entrance { get => entrance; set => entrance = value; }
        public string Id { get => id; set => id = value; }
        public string[,] BaseMap { get => baseMap; set => baseMap = value; }

        public abstract void IsPlayerInRoom();
        public abstract void ManRoomSet(int x, int y);
        public abstract void RandRoomSet();



      

        
        /*
        //private bool isNextRoom;
        private bool isThereEntrance;
        private String setEntrance;
        private bool isThereDragon = false;
        private String setDragon;
        private bool IsTherePits1= false;
        private bool IsTherePits2 = false;
        private bool IsTherePits3 = false;
        private String setPits;
        private bool isThereGold = false;
        private String setGold;
        */


        public Room()
        {
            //this.id = "";

            this.descriptionOne = "";
            this.descriptionTwo = "";
            this.descriptionThree = "";
            this.baseMap = baseMap;
        }
        public Room(String[,] baseMap , String id , String descriptionOne, String descriptionTwo, String descriptionThree)
        {
            this.id = "";

            this.descriptionOne = "";
            this.descriptionTwo = "";
            this.descriptionThree = "";
            this.baseMap = baseMap;
        }

        public Room(String[,] baseMap, String  id, String descriptionOne, String descriptionTwo, String descriptionThree , Gold gold)
        {
            this.id = "";

            this.descriptionOne = "";
            this.descriptionTwo = "";
            this.descriptionThree = "";
            this.baseMap = baseMap;
            this.gold = gold;
        }
        public Room(String[,] baseMap, String id, String descriptionOne, String descriptionTwo, String descriptionThree, Pit pit)
        {
            this.id = "";

            this.descriptionOne = "";
            this.descriptionTwo = "";
            this.descriptionThree = "";
            this.baseMap = baseMap;
            this.pit = pit;
        }
        public Room(String[,] baseMap, String id, String descriptionOne, String descriptionTwo, String descriptionThree, Entrance entrance)
        {
            this.id = "";

            this.descriptionOne = "";
            this.descriptionTwo = "";
            this.descriptionThree = "";
            this.baseMap = baseMap;
            this.entrance = entrance;
        }
        public Room(String[,] baseMap, String id, String descriptionOne, String descriptionTwo, String descriptionThree , Dragon dragon)
        {
            this.id = "";

            this.descriptionOne = "";
            this.descriptionTwo = "";
            this.descriptionThree = "";
            this.baseMap = baseMap;
            this.dragon = dragon;
        }

      


        /*
        public String[,] BaseMap { get => baseMap; set => baseMap = value; }
        //public bool IsNextRoom { get => isNextRoom; set => isNextRoom = value; }
        public bool IsThereEntrance { get => isThereEntrance; set => isThereEntrance = value; }
        public string SetEntrance { get => setEntrance; set => setEntrance = value; }
        public bool IsThereDragon { get => isThereDragon; set => isThereDragon = value; }
        public string SetDragon { get => setDragon; set => setDragon = value; }
        public bool IsTherePits11 { get => IsTherePits1; set => IsTherePits1 = value; }
        public bool IsTherePits21 { get => IsTherePits2; set => IsTherePits2 = value; }
        public bool IsTherePits31 { get => IsTherePits3; set => IsTherePits3 = value; }
        public string SetPits { get => setPits; set => setPits = value; }
        public bool IsThereGold { get => isThereGold; set => isThereGold = value; }
        public string SetGold { get => setGold; set => setGold = value; }
       
    */
        /*
            public void SetDragonPlace()
            {
                Random rndx = new Random();
                Random rndy = new Random();

                if (isThereDragon == false)
                {

                    int x = rndx.Next(0, 3);
                    int y = rndy.Next(0, 3);
                    if (BaseMap[x, y] == null)
                    {

                        BaseMap[x, y] = "dragon";
                        Console.WriteLine(x + " " + y);
                        IsThereDragon = true;
                    }
                    else
                    {
                        SetDragonPlace();
                    }

                }

            }

        */
        //public abstract void SetDragonPlace();

        /*
        public void SetEntrancePlace()
        {
            Random rndx = new Random();
            Random rndy = new Random();

            if (IsThereEntrance == false)
            {

                int x = rndx.Next(0,3);
                int y = rndy.Next(0,3);

                BaseMap[x, y] = "Entrance";
                Console.WriteLine(x +" " +  y);
               
            }
            IsThereEntrance = true;
        }



        public void SetGoldPlace()
        {
            Random rndx = new Random();
            Random rndy = new Random();

            if (IsThereGold == false)
            {

               

              int x = rndx.Next(0, 3);
              int y = rndy.Next(0, 3);
                if (BaseMap[x, y] == null)
                {
                    BaseMap[x, y] = "Gold";
                    Console.WriteLine(x + " " + y);
                    IsThereGold = true;
                }
                else
                {
                    SetGoldPlace();
                }

            }

        }
        */
        /*
        public void SetPitPlaces()
        {
            Random rndx1 = new Random();
            Random rndy1 = new Random();
            Random rndx2 = new Random();
            Random rndy2 = new Random();
            Random rndx3 = new Random();
            Random rndy3 = new Random();

            if (IsTherePits11 == false)
            {
                int x = rndx1.Next(0,4);
                int y = rndy1.Next(0,4);

                if (BaseMap[x, y] == null)
                {
                    BaseMap[x, y] = "Pit1";
                    Console.WriteLine(x + " " + y);
                    
                    IsTherePits11 = true;
                }
                else
                {
                    SetPitPlaces();
                }
            }


            if (IsTherePits21 == false)
            {
                int x = rndx2.Next(0,4);
                int y = rndy2.Next(0,4);

                if (BaseMap[x, y] == null)
                {
                    BaseMap[x, y] = "Pit2";
                    Console.WriteLine(x + " " + y);

                    IsTherePits21 = true;
                }
                else
                {
                    SetPitPlaces();
                }
            }

            if (IsTherePits31 == false)
            {
                int x = rndx3.Next(0,4);
                int y = rndy3.Next(0,4);

                if (BaseMap[x, y] == null)
                {
                    BaseMap[x, y] = "Pit3";
                    Console.WriteLine(x + " " + y);

                    IsTherePits31 = true;
                }
                else
                {
                    SetPitPlaces();
                }
            }

        }


    */
        /*
            public void mapUpdate()
            {

                for(int x = 0; x < 3;x++)
                {
                    for(int y = 0; x < 3; y++)
                    {

                        if (BaseMap[x, y] == null)
                        {
                            BaseMap[x, y] = ".";
                        }
                        else if()
                        {

                        }
                    }
                }


            }
            */
        /*
        public void FillInTheBlanks()
        {

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 4; col++)
                {

                    if (BaseMap[row, col] == null)
                    {
                        BaseMap[row, col] = ".";
                    }//= ".";
                }

            }
        }
        */

    }
}
