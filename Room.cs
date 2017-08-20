
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Cave
{
    class Room
    {
        private String[,] baseMap;
        //private bool isNextRoom;
        private bool isThereEntrance = false;
        private String setEntrance;
        private bool isThereDragon = false;
        private String setDragon;
        private bool IsTherePits1= false;
        private bool IsTherePits2 = false;
        private bool IsTherePits3 = false;
        private String setPits;
        private bool isThereGold = false;
        private String setGold;

        public Room(String[,] baseMap)
        {
            this.baseMap = baseMap;
        }

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

    }
}
