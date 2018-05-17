using System;
using Mazegame.Boundary;
using Mazegame.Entity;
using Mazegame.Entity.Utility;

namespace MazeDataImpl
{
    public class HardCodedData : IMazeData
    {
        private Location startUp, westHall, mainHall, eastHall, butlerBedroom, maidBedroom, smithRoom;
        private AgilityTable agilityModifier;
        private StrengthTable strengthModifier;
        private WeightLimit weightLookup;

        public HardCodedData()
        {
            CreateLocations();
            PopulateAgilityTable();
            PopulateStrengthTable();
            PopulateWeightLimit();
            CreateItems();
        }

        ~HardCodedData()
        {
        }

        public virtual void Dispose()
        {
        }

        public Location GetStartingLocation()
        {
            return startUp;
        }

        public StrengthTable GetStrengthTable()
        {
            return strengthModifier;
        }

        public AgilityTable GetAgilityTable()
        {
            return agilityModifier;
        }

        public WeightLimit GetWeightLimit()
        {
            return weightLookup;
        }

        public String GetWelcomeMessage()
        {
            return "Welcome to the Duke's Mansion";
        }
        

        private void CreateLocations()
        {

            startUp = new Location("A large, open room with Immaculately clean marbles floors", "Mansion Lobby", new NonPlayerCharacter("Johnny", "heyo", false));
            westHall = new Location("A long hallway leading west", "West Hall", new NonPlayerCharacter("Joasdasdasdahnny", "heyo", false));
            mainHall = new Location("A room filled with neatly places paintings and sculptures", "Main Hall", new NonPlayerCharacter("Johasdasdasdasdnny", "heyo", false));
            eastHall = new Location("A long hallway leading east", "East Hall", new NonPlayerCharacter("Joaaaaaaaaaaaaaaaaaaaaaahnny", "heyo", false));
            butlerBedroom = new Shop("A small, tidy room with bare furniture", "Butler's Bedroom", new NonPlayerCharacter("Johnasdssadasdny", "heyo", false));
            maidBedroom = new Shop("A small, fragrant room", "Maid's Bedroom", new NonPlayerCharacter("Johaaaaaanny", "heyo", false));
            smithRoom = new Shop("The room smells of metal and something burning", "Blacksmith's Workshop", new NonPlayerCharacter("ssss", "heyo", false));

            startUp.GetExitCollection().AddExit("north", new Exit("You see a large room to the north", mainHall));

            startUp.GetExitCollection().AddExit("northwest", new Exit("You see a large hall to the north west", westHall));

            startUp.GetExitCollection().AddExit("northeast", new Exit("You see a large hall to the north east", eastHall));

            westHall.GetExitCollection().AddExit("up", new Exit("You see stairs leading up", smithRoom));
            smithRoom.GetExitCollection().AddExit("down", new Exit("You see stairs leading down", westHall));

            mainHall.GetExitCollection().AddExit("west", new Exit("The large hall continues to the west", westHall));
            westHall.GetExitCollection().AddExit("east", new Exit("The large hall continues to the east", mainHall));

            mainHall.GetExitCollection().AddExit("northeast", new Exit("You see a small room to the northeast", butlerBedroom));
            butlerBedroom.GetExitCollection().AddExit("southwest", new Exit("You see a large room to the southwest", mainHall));

            mainHall.GetExitCollection().AddExit("east", new Exit("The large hall continues to the east", eastHall));
            eastHall.GetExitCollection().AddExit("west", new Exit("The large hall continues to the west", mainHall));

            eastHall.GetExitCollection().AddExit("south", new Exit("You see a small room to the south", maidBedroom));
            maidBedroom.GetExitCollection().AddExit("west", new Exit("You see a large room to the west", startUp));

            eastHall.GetExitCollection().AddExit("northwest", new Exit("You see a small room to the northwest", butlerBedroom));
        }

        private void CreateItems()
        {
            startUp.GetInventory().AddMoney(50);
            startUp.GetInventory().AddItem(new Item("short_sword", 10, 3, "The shortest sword"));
            startUp.GetInventory().AddItem(new Item("padded_armor", 5, 10, "Harder than normal leather"));

            westHall.GetInventory().AddItem(new Item("warhammer", 12, 8, "It's hammer time"));
            westHall.GetInventory().AddMoney(10);

            mainHall.GetInventory().AddItem(new Item("studded_leather_armor", 25, 20, "These studs should provide a bit more protection"));
            mainHall.GetInventory().AddMoney(50);

            eastHall.GetInventory().AddItem(new Item("key", 1, 0.5, "I wonder what this opens"));
            eastHall.GetInventory().AddItem(new Item("large_rock", 1000, 1000, "That is a big rock"));

            butlerBedroom.GetInventory().AddItem(new Item("leather_armor", 10, 15, "Better than no armor"));
            butlerBedroom.GetInventory().AddItem(new Item("long_sword", 15, 4, "The longest of swords"));
            butlerBedroom.GetInventory().AddItem(new Item("chain_mail", 150, 40, "Chains linked to form armor"));

            maidBedroom.GetInventory().AddItem(new Item("nunchaku", 2, 2, "A pair of nunchaku, smells of pizza"));
            maidBedroom.GetInventory().AddItem(new Item("dagger", 1, 2, "Short but pointy"));

            smithRoom.GetInventory().AddItem(new Item("large_steel_shield", 20, 15, "A Large metal shield"));
            smithRoom.GetInventory().AddItem(new Item("dwarven_war_axe", 30, 15, "A common weapon for a dwarf"));
            smithRoom.GetInventory().AddItem(new Item("great_sword", 50, 15, "The greatest of them all"));
            smithRoom.GetInventory().AddItem(new Item("great_club", 5, 10, "A brutal weapon popular amoung giants"));
            smithRoom.GetInventory().AddItem(new Item("chain_shirt", 100, 25, "Like the chain mail, but a shirt"));


        }

        private void PopulateAgilityTable()
        {
            agilityModifier = AgilityTable.GetInstance();
            agilityModifier.SetModifier(1, -5);
            agilityModifier.SetModifier(2, -5);
            agilityModifier.SetModifier(3, -5);
            agilityModifier.SetModifier(4, -3);
            agilityModifier.SetModifier(5, -3);
            agilityModifier.SetModifier(6, -2);
            agilityModifier.SetModifier(7, -2);
            agilityModifier.SetModifier(8, -1);
            agilityModifier.SetModifier(9, -1);
            agilityModifier.SetModifier(10, 0);
            agilityModifier.SetModifier(11, 0);
            agilityModifier.SetModifier(12, 1);
            agilityModifier.SetModifier(13, 1);
            agilityModifier.SetModifier(14, 2);
            agilityModifier.SetModifier(15, 2);
            agilityModifier.SetModifier(16, 3);
            agilityModifier.SetModifier(17, 3);
            agilityModifier.SetModifier(18, 4);
            agilityModifier.SetModifier(19, 4);
            agilityModifier.SetModifier(20, 6);
            agilityModifier.SetModifier(21, 6);
            agilityModifier.SetModifier(22, 6);
            agilityModifier.SetModifier(23, 6);
            agilityModifier.SetModifier(24, 6);
            agilityModifier.SetModifier(25, 6);
            agilityModifier.SetModifier(26, 8);
            agilityModifier.SetModifier(27, 8);
            agilityModifier.SetModifier(28, 8);
            agilityModifier.SetModifier(29, 8);
            agilityModifier.SetModifier(30, 8);
            agilityModifier.SetModifier(31, 8);
            agilityModifier.SetModifier(32, 11);
        }

        private void PopulateWeightLimit()
        {
            weightLookup = WeightLimit.GetInstance();
            weightLookup.SetModifier(1, 6);
            weightLookup.SetModifier(2, 13);
            weightLookup.SetModifier(3, 20);
            weightLookup.SetModifier(4, 26);
            weightLookup.SetModifier(5, 33);
            weightLookup.SetModifier(6, 40);
            weightLookup.SetModifier(7, 46);
            weightLookup.SetModifier(8, 53);
            weightLookup.SetModifier(9, 60);
            weightLookup.SetModifier(10, 66);
            weightLookup.SetModifier(11, 76);
            weightLookup.SetModifier(12, 86);
            weightLookup.SetModifier(13, 100);
            weightLookup.SetModifier(14, 116);
            weightLookup.SetModifier(15, 133);
            weightLookup.SetModifier(16, 153);
            weightLookup.SetModifier(17, 173);
            weightLookup.SetModifier(18, 200);
            weightLookup.SetModifier(19, 233);
            weightLookup.SetModifier(20, 266);
            weightLookup.SetModifier(21, 306);
            weightLookup.SetModifier(22, 346);
            weightLookup.SetModifier(23, 400);
            weightLookup.SetModifier(24, 466);
            weightLookup.SetModifier(25, 533);
            weightLookup.SetModifier(26, 613);
            weightLookup.SetModifier(27, 693);
            weightLookup.SetModifier(28, 800);
            weightLookup.SetModifier(29, 933);
        }

        private void PopulateStrengthTable()
        {
            strengthModifier = StrengthTable.GetInstance();
            strengthModifier.SetModifier(1, -5);
            strengthModifier.SetModifier(2, -4);
            strengthModifier.SetModifier(3, -4);
            strengthModifier.SetModifier(4, -3);
            strengthModifier.SetModifier(5, -3);
            strengthModifier.SetModifier(6, -2);
            strengthModifier.SetModifier(7, -2);
            strengthModifier.SetModifier(8, -1);
            strengthModifier.SetModifier(9, -1);
            strengthModifier.SetModifier(10, 0);
            strengthModifier.SetModifier(11, 0);
            strengthModifier.SetModifier(12, 1);
            strengthModifier.SetModifier(13, 1);
            strengthModifier.SetModifier(14, 2);
            strengthModifier.SetModifier(15, 2);
            strengthModifier.SetModifier(16, 3);
            strengthModifier.SetModifier(17, 3);
            strengthModifier.SetModifier(18, 4);
            strengthModifier.SetModifier(19, 4);
            strengthModifier.SetModifier(20, 5);
            strengthModifier.SetModifier(21, 5);
            strengthModifier.SetModifier(22, 5);
            strengthModifier.SetModifier(23, 5);
            strengthModifier.SetModifier(24, 5);
            strengthModifier.SetModifier(25, 5);
            strengthModifier.SetModifier(26, 8);
            strengthModifier.SetModifier(27, 8);
            strengthModifier.SetModifier(28, 8);
            strengthModifier.SetModifier(29, 8);
            strengthModifier.SetModifier(30, 10);
            strengthModifier.SetModifier(31, 10);
            strengthModifier.SetModifier(32, 10);
            strengthModifier.SetModifier(33, 10);
            strengthModifier.SetModifier(34, 10);
            strengthModifier.SetModifier(35, 10);
            strengthModifier.SetModifier(36, 12);
            strengthModifier.SetModifier(37, 12);
            strengthModifier.SetModifier(38, 12);
            strengthModifier.SetModifier(39, 12);
            strengthModifier.SetModifier(40, 12);
            strengthModifier.SetModifier(41, 15);
            strengthModifier.SetModifier(42, 15);
            strengthModifier.SetModifier(43, 15);
            strengthModifier.SetModifier(44, 17);
            strengthModifier.SetModifier(45, 17);
            strengthModifier.SetModifier(46, 18);
        }
    }
}