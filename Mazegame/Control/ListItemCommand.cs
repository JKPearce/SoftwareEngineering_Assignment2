using Mazegame.Entity;

namespace Mazegame.Control
{
    public class ListItemCommand : Command
    {

        public override CommandResponse Execute(ParsedInput userInput,
            Player thePlayer)
        {
            return new CommandResponse(thePlayer.ToString());
        }
    }
}
