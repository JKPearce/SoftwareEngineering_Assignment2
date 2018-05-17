using System;

namespace Mazegame.Boundary {
	public interface IMazeClient  {
		String GetReply(String question);
		void PlayerMessage(String message);
	    String GetCommand();
	}
}