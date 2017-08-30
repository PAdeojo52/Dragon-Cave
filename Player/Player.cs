using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Cave
{
    class Player
    {
        private Room[,] board;
        private int xPlayerPosition;
        private int yPlayerPosition;
        private String playerController;
        private String playerDirection;
        private int playerArrow;
        private bool Death;
        private String iD;
        private bool isPlayerEntraceSet;

        public int XPlayerPosition { get => xPlayerPosition; set => xPlayerPosition = value; }
        public int YPlayerPosition { get => yPlayerPosition; set => yPlayerPosition = value; }
        public string PlayerController { get => playerController; set => playerController = value; }
        public string PlayerDirection { get => playerDirection; set => playerDirection = value; }
        public int PlayerArrow { get => playerArrow; set => playerArrow = value; }
        public bool Death1 { get => Death; set => Death = value; }
        public string ID { get => iD; set => iD = value; }
        public bool IsPlayerEntraceSet { get => isPlayerEntraceSet; set => isPlayerEntraceSet = value; }

        public Player(Room[,] map)
        {
            this.board = map;
            this.xPlayerPosition = 0;
            this.yPlayerPosition = 0;
            this.playerDirection = "East";
            this.playerArrow = 1;
            this.Death = false;
            this.isPlayerEntraceSet = false;

        }


        




    }
}
