using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mazegame.Entity;

namespace Mazegame.Control
{
    public class CommandResponse
    {
        private bool finishedGame;
        private string message;
        private Item item;

        public CommandResponse(string message)
        {
            Message = message;
            FinishedGame = false;
        }

        public CommandResponse(Item item)
        {
            this.item = item;
        }

        public CommandResponse(string message, bool quitFlag)
        {
            Message = message;
            FinishedGame = quitFlag;
        }

        public bool FinishedGame
        {
            get { return finishedGame; }
            set { finishedGame = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }
        }
    }
}
