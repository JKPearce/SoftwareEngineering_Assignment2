using Mazegame.Entity;

namespace Mazegame.Control
{
    public abstract class Command
    {
        public abstract CommandResponse Execute(ParsedInput userInput,
            Player thePlayer);
    }
}
