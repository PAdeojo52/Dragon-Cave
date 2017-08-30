using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Cave
{
    class Entrance : Room
    {
        public String ID;
        private bool IsPlaced;
        private int EX;
        private int EY;



        public Entrance ()
         {
            this.ID = "Entrance";
            id = this.ID;
            this.IsPlaced = false;
            //  base.id = ID;
        }

        public bool IsPlaced1 { get => IsPlaced; set => IsPlaced = value; }
        public int EX1 { get => EX; set => EX = value; }
        public int EY1 { get => EY; set => EY = value; }

        public override void IsPlayerInRoom()
        {

            Console.WriteLine("Playa in the house");

            throw new NotImplementedException();
        }

        public override void ManRoomSet(int x, int y)
        {
            EX1 = x;
            EY1 = y;
            throw new NotImplementedException();
        }

        public override void RandRoomSet()
        {
            throw new NotImplementedException();
        }
    }
}
