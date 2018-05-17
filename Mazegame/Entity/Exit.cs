using System;

namespace Mazegame.Entity {
	public class Exit
	{
	    private String description;
	    private Mazegame.Entity.Location destination;

		public Exit(String description, Location destination)
		{
		    Description = description;
		    Destination = destination;
		}

	    public string Description
	    {
	        get { return description; }
	        set { description = value; }
	    }

	    public Location Destination
	    {
	        get { return destination; }
	        set { destination = value; }
	    }
	}
}