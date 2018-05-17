using System;
using System.Collections;
using System.Text;

namespace Mazegame.Entity
{
    public class Location
    {
        private NonPlayerCharacter npc;
        private Inventory items;

        private String description;
        private String label;
        private readonly ExitCollection exitCollection;

        public Location()
        {
            exitCollection = new ExitCollection();
            items = new Inventory();
            
        }

        public Location(String description, String label, NonPlayerCharacter npc) : this()
        {
            Description = description;
            Label = label;
            this.npc = npc;
            
        }

        public Inventory GetInventory()
        {
            return items;
        }

        public NonPlayerCharacter GetNPC()
        {
            return this.npc;
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String Label
        {
            get { return label; }
            set { label = value; }
        }

        public ExitCollection GetExitCollection()
        {
            return exitCollection;
        }

        public override string ToString()
        {
            return
                this.npc.Name+ this.npc.Dialogue +
                "**********\n" + this.Label + "\n**********\n"
                + "Exits found :: " + exitCollection.AvailableExits()
                + "\n" + items.ToString() 
                + "\n**********\n" + this.Description + "\n**********\n";
        }
    } 
} 