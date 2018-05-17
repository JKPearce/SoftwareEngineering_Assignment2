using Mazegame.Entity;

namespace Mazegame.Control
{
    public class ListItemCommand : Command
    {
        private Player thePlayer;

        public override CommandResponse Execute(ParsedInput userInput,
            Player thePlayer)
        {
            this.thePlayer = thePlayer;
            return new CommandResponse(thePlayer.ToString());
        }
    }
}
