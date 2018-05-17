///////////////////////////////////////////////////////////
//  HardCodedData.cs
//  Implementation of the Class HardCodedData
//  Generated by Enterprise Architect
//  Created on:      28-Apr-2014 10:13:37 PM
//  Original author: Gsimmons
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using Mazegame.Boundary;
using Mazegame.Entity;
using Mazegame.Entity.Utility;

namespace MazeDataImpl
{
    public class HardCodedData : IMazeData
    {
        private Location startUp, lounge, t127, gregsOffice, evansCave;
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
            return "Welcome to the Mount Helanous";
        }

        private void CreateLocations()
        {
            startUp =
                new Location("an office with paper strewn everywhere, how anyone works effectively here is a mystery",
                    "Julies Office");
            lounge =
                new Location("an open space containing comfortable looking couches and artwork of dubious quality",
                    "Airport Lounge");
            t127 = new Location("a lecture theatre", "T127");
            gregsOffice = new Location("a spinning vortex of terror", "Greg's Office");
            evansCave = new Shop("a crowded room full of technology related stuff", "Crazy Evan's Discount Technology");

            startUp.GetExitCollection().AddExit("south", new Exit("you see an open space to the south", lounge));
            startUp.GetExitCollection().AddExit("west", new Exit("you see a terrifying office to the west", gregsOffice));
            startUp.GetExitCollection().AddExit("north", new Exit("you see a bleak place to the north", t127));

            lounge.GetExitCollection().AddExit("north", new Exit("you see a mound of paper to the north", startUp));
            lounge.GetExitCollection().AddExit("northwest", new Exit("you see a terrifying office to the northwest", gregsOffice));

            t127.GetExitCollection().AddExit("south", new Exit("you see a mound of paper to the south", startUp));

            gregsOffice.GetExitCollection().AddExit("east", new Exit("you see a mound of paper to the east", startUp));
            gregsOffice.GetExitCollection().AddExit("southeast", new Exit("you see an open space to the southeast", lounge));
            gregsOffice.GetExitCollection().AddExit("west",
                new Exit("you see shiny stuff to the west.. it looks outdated, retro even", evansCave));

            evansCave.GetExitCollection().AddExit("east", new Exit("you see a terrifying office to the east", gregsOffice));
        }

        private void CreateItems()
        {
            gregsOffice.GetInventory().AddMoney(250);
            gregsOffice.GetInventory().AddItem(new Item("GoldUSB1", 2, 1, "A shiny gold 64GB USB stick"));

            evansCave.GetInventory().AddItem(new Item("SurfacePro3",1500,200,"Microsofts new but old idea"));
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
    } //end HardCodedData
} //end namespace Mazegame