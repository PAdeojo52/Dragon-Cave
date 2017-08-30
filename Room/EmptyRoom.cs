using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Cave
{
    class EmptyRoom:Room
    {
        private String iD = ".";
        //private bool isDragonDead;
        // Player p1 = new Player();
        private int DX;
        private int DY;
        private bool IsPlaced;

        public string ID { get => iD; set => iD = value; }
        public int DX1 { get => DX; set => DX = value; }
        public int DY1 { get => DY; set => DY = value; }
        public bool IsPlaced1 { get => IsPlaced; set => IsPlaced = value; }

        public EmptyRoom()
        {
            this.ID = ".";
            id = this.ID;

            // base.id = ID;
           // isDragonDead = false;
            this.DX = 0;
            this.DY = 0;
            this.IsPlaced = false;
            DescriptionOne = "";
            DescriptionTwo = "";
            DescriptionThree = "";
        }

        public override void IsPlayerInRoom()
        {
            throw new NotImplementedException();
        }

        public override void ManRoomSet(int x, int y)
        {
            throw new NotImplementedException();
        }

        public override void RandRoomSet()
        {
            throw new NotImplementedException();
        }

        public static implicit operator string(EmptyRoom v)
        {
            throw new NotImplementedException();
        }
    }
}
