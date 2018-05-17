using Mazegame.Entity;

namespace Mazegame.Control
{
    public class MovementState : CommandState
    {
        public MovementState() : base()
        {
            AvailableCommands.Add("go", new MoveCommand());
            AvailableCommands.Add("move", new MoveCommand());
            AvailableCommands.Add("quit", new QuitCommand());
            AvailableCommands.Add("look", new LookCommand());
            AvailableCommands.Add("unlock", new UnlockCommand());
            AvailableCommands.Add("attack", new AttackCommand());
            AvailableCommands.Add("list", new ListItemCommand());
            AvailableCommands.Add("inventory", new ListItemCommand());
            AvailableCommands.Add("grab", new PickUpCommand());
            AvailableCommands.Add("drop", new DropCommand());
        }

        public override CommandState Update(Player thePlayer)
        {
            if (thePlayer.CurrentLocation is Shop)
                return new CommerceState();
            return this;
        }
    }
}
