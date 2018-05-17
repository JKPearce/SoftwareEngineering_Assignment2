using Mazegame.Entity;
namespace Mazegame.Control
{
    public class EquipCommand : Command
    {
        public override CommandResponse Execute(ParsedInput userInput,
            Player thePlayer)
        {
            return new CommandResponse("You entered the equip command");
        }
    }
}
