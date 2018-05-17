using Mazegame.Entity;
namespace Mazegame.Control
{
    public class UnlockCommand : Command
    {
        public override CommandResponse Execute(ParsedInput userInput,
            Player thePlayer)
        {
            return new CommandResponse("You entered the unlock command");
        }
    }
}
