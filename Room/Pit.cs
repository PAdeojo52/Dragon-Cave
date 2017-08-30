using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Cave
{
    class Pit : Room
    {

        private bool IsPlaced;
        private int PX, PY;
        public string ID;

        public Pit()
        {
            this.ID = "Pit";
            id = this.ID;

            this.IsPlaced = false;

        }

        public int PX1 { get => PX; set => PX = value; }
        public int PY1 { get => PY; set => PY = value; }
        public bool IsPlaced1 { get => IsPlaced; set => IsPlaced = value; }

        public override void IsPlayerInRoom()
        {

            Console.WriteLine("The player has fallen in the hole");
            throw new NotImplementedException();
        }

        public override void ManRoomSet(int x, int y)
        {
            PX1 = x;
            PY1 = y;
            throw new NotImplementedException();
        }

        public override void RandRoomSet()
        {
            throw new NotImplementedException();
        }
    }
}
