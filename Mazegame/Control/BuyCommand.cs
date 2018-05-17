using Mazegame.Entity;
namespace Mazegame.Control
{
    public class BuyCommand : Command
    {
        public override CommandResponse Execute(ParsedInput userInput,
            Player thePlayer)
        {
            return new CommandResponse("You entered the buy command");
        }
    }
}
