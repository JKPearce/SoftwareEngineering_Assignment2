using System;

namespace Mazegame.Entity {
	public class Player : Character {
	    private Location currentLocation;
	    private Inventory inventory;

	    public Player()
	    {
	        
        }

	    public Player(String name) : base(name)
		{
		    inventory = new Inventory();
            inventory.AddItem(new Item("warhammer", 10, 8, "It's hammer time"));
            inventory.AddMoney(100);
        }

	    public Inventory PlayerInventory
	    {
	        get { return inventory; }
	        set { inventory = value; }
        }

        public Location CurrentLocation
	    {
	        get { return currentLocation; }
	        set { currentLocation = value; }
	    }

	    public override string ToString()
	    {
	        return inventory.ToString();
	    }
	}

}