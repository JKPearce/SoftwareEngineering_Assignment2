using System;
using Mazegame.Entity;

namespace Mazegame.Control
{
    public class CommandHandler
    {
        private CommandState availableCommands;

        public CommandHandler()
        {
            availableCommands = new MovementState();
        }

        public CommandResponse ProcessTurn(String userInput, Player thePlayer)
        {
            availableCommands = availableCommands.Update(thePlayer);
            ParsedInput validInput = parse(userInput);

            Command theCommand = availableCommands.GetCommand(validInput.Command);
            if (theCommand == null)
                return new CommandResponse("Not a valid command");
            return theCommand.Execute(validInput, thePlayer);
        }

        private ParsedInput parse(String userInput)
        {
            Parser theParser = new Parser(availableCommands.GetLabels());
            return theParser.Parse(userInput);
        }
    }
}
