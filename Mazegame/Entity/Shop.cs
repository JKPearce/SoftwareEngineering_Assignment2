using System;

namespace Mazegame.Entity {
	public class Shop : Location {

		public Shop(){
		}

	    public Shop(String description, String label, NonPlayerCharacter npc) : base(description, label, npc)
	    {
	    }
	}
}