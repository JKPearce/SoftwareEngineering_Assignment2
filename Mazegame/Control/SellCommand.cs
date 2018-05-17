using Mazegame.Entity;
namespace Mazegame.Control
{
    public class SellCommand : Command
    {
        public override CommandResponse Execute(ParsedInput userInput,
            Player thePlayer)
        {
            return new CommandResponse("You entered the sell command");
        }
    }
}
