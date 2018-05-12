﻿using Mazegame.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mazegame.Control
{
    public class CommandHandler
    {
        private Hashtable availableCommands;
        private Parser theParser;

        public CommandHandler()
        {
            availableCommands = new Hashtable();
            SetupCommands();
            theParser = new Parser(new ArrayList(availableCommands.Keys));
        }

        private void SetupCommands()
        {
            availableCommands.Add("look", new LookCommand());
            availableCommands.Add("go", new MoveCommand());
            availableCommands.Add("quit", new QuitCommand());
            availableCommands.Add("move", new MoveCommand());
        }

        public CommandResponse ProcessTurn(String userInput, Player thePlayer)
        {
            ParsedInput validInput = theParser.Parse(userInput);
            try
            {
                Command theCommand = (Command)availableCommands[validInput.Command];
                return theCommand.Execute(validInput, thePlayer);
            }
            catch (NullReferenceException)
            {
                return new CommandResponse("Not a valid command");
            }
        }
    }

}
