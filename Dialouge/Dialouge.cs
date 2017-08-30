using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dragon_Cave
{ 
    class Dialouge
    {


        private String winnner, dampBreeze, foulStench, StillDragon, StillGold,
            nothingHappens, Quitter, DragonEatsYou, GoldInRoom, Help, FoundEntranceWitoutGold, YouDied, Direction, YouAreIn,
            YouHitAWall, YourOutOfArrows, YouLeaveTheCave, YouFallIntoPit, YouGotTheGold, YouHaveAnArrow, YouHearARoar, YouHearAThud, YouWalkIntoNextRoom;

        public Dialouge()
        {
            winnner = "!!!!!! You Win !!!!!!";
            dampBreeze = "A damp breeze is in the air!\n";
            foulStench = "A foul stench is in the air!\n";
            StillDragon = "But there is still a dragon to slay.";
            StillGold = "But there is still gold to be found.";
            nothingHappens = "Nothing happens.";
            Quitter = "Quitter!!!";
            DragonEatsYou = "The Dragon Eats You !!!";
            GoldInRoom = "The room is glittering!\n";
            Help = "Try the following commands:\n";
                FoundEntranceWitoutGold = "Try to find the gold and return here to climb back out.";
            YouDied = "You Die !!!";
            Direction = "You are facing ";
            YouAreIn = "You are in: ";

            YouHitAWall = "You bump into a wall.";
            YourOutOfArrows = "You don't have an arrow.";

            YouLeaveTheCave = "You escape the cave!!!";
            YouFallIntoPit = "You fall into a pit !!!";
            YouGotTheGold = "You got the gold !!!";
            YouHaveAnArrow = "You have 1 arrow that you can shoot.";
            YouHearARoar = "You here a giant roar in the distance!!!";
            YouHearAThud = "You here a thud in the distance.";
            YouWalkIntoNextRoom = "You walk into the next room.";

        }

        public string Winnner { get => winnner; set => winnner = value; }
        public string DampBreeze { get => dampBreeze; set => dampBreeze = value; }
        public string FoulStench { get => foulStench; set => foulStench = value; }
        public string StillDragon1 { get => StillDragon; set => StillDragon = value; }
        public string StillGold1 { get => StillGold; set => StillGold = value; }
        public string NothingHappens { get => nothingHappens; set => nothingHappens = value; }
        public string Quitter1 { get => Quitter; set => Quitter = value; }
        public string DragonEatsYou1 { get => DragonEatsYou; set => DragonEatsYou = value; }
        public string GoldInRoom1 { get => GoldInRoom; set => GoldInRoom = value; }
        public string Help1 { get => Help; set => Help = value; }
        public string FoundEntranceWitoutGold1 { get => FoundEntranceWitoutGold; set => FoundEntranceWitoutGold = value; }
        public string YouDied1 { get => YouDied; set => YouDied = value; }
        public string Direction1 { get => Direction; set => Direction = value; }
        public string YouAreIn1 { get => YouAreIn; set => YouAreIn = value; }
        public string YouHitAWall1 { get => YouHitAWall; set => YouHitAWall = value; }
        public string YourOutOfArrows1 { get => YourOutOfArrows; set => YourOutOfArrows = value; }
        public string YouLeaveTheCave1 { get => YouLeaveTheCave; set => YouLeaveTheCave = value; }
        public string YouFallIntoPit1 { get => YouFallIntoPit; set => YouFallIntoPit = value; }
        public string YouGotTheGold1 { get => YouGotTheGold; set => YouGotTheGold = value; }
        public string YouHaveAnArrow1 { get => YouHaveAnArrow; set => YouHaveAnArrow = value; }
        public string YouHearARoar1 { get => YouHearARoar; set => YouHearARoar = value; }
        public string YouHearAThud1 { get => YouHearAThud; set => YouHearAThud = value; }
        public string YouWalkIntoNextRoom1 { get => YouWalkIntoNextRoom; set => YouWalkIntoNextRoom = value; }



    }
}
