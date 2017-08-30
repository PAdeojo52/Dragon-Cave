using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Cave
{
    class Dragon : Room
    {
        public String ID = "dragon";
        private bool isDragonDead;
       // Player p1 = new Player();
        private int DX;
        private int DY;
        private bool IsPlaced;

        
        public Dragon()
        {
            this.ID = "Dragon";
            id = this.ID;

           // base.id = ID;
            isDragonDead = false;
            this.DX = 0;
            this.DY = 0;
            this.IsPlaced = false;
            DescriptionOne = "";
            DescriptionTwo = "";
            DescriptionThree = "";
            


        }

        public bool IsPlaced1 { get => IsPlaced; set => IsPlaced = value; }
        public bool IsDragonDead { get => isDragonDead; set => isDragonDead = value; }
        public int DX1 { get => DX; set => DX = value; }
        public int DY1 { get => DY; set => DY = value; }

        public override void IsPlayerInRoom()
        {
            if (isDragonDead == false)
            {

                
                Console.WriteLine("Dragon");

            }
            else
            {
                Console.WriteLine("The Dragon is dead");
            }
            throw new NotImplementedException();
        }

       
        public override void ManRoomSet(int x, int y)
        {
                DX1 = x;
                DY1 = y;
            throw new NotImplementedException();
        }

        public override void RandRoomSet()
        {
            throw new NotImplementedException();
        }
    }
}
