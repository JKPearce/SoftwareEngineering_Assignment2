using System;
using Mazegame.Entity;
using Mazegame.Entity.Utility;

namespace Mazegame.Boundary {
	public interface IMazeData  {
		Location GetStartingLocation();
	    String GetWelcomeMessage();
	    StrengthTable GetStrengthTable();
	    AgilityTable GetAgilityTable();
	    WeightLimit GetWeightLimit();
	}
}