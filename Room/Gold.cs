using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Cave
{
    class Gold : Room
    {
        public String ID;
        public bool isGoldPicked;
        private bool IsPlaced;
        private int GX, GY;
        
        public Gold()
        {
            this.ID = "Gold";
            id = this.ID;
            isGoldPicked = false;
            this.IsPlaced = false;
        }

        public int GX1 { get => GX; set => GX = value; }
        public int GY1 { get => GY; set => GY = value; }
        public bool IsPlaced1 { get => IsPlaced; set => IsPlaced = value; }

        public override void IsPlayerInRoom()
        {
            Console.WriteLine("Gold");
            throw new NotImplementedException();
        }


        public override void ManRoomSet(int x, int y)
        {
            GX1 = x;
            GY1 = y;
            throw new NotImplementedException();
        }

        public override void RandRoomSet()
        {
            throw new NotImplementedException();
        }
    }
}
