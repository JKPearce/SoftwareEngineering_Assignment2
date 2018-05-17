using System;
using System.Collections;
using System.Xml.Serialization;
using Mazegame.Boundary;
using Mazegame.Entity;
using MazeGame.Control;

namespace Mazegame.Control
{
    public class DungeonMaster
    {
        private IMazeClient gameClient;
        private IMazeData gameData;
        private Player thePlayer;
        private CommandHandler playerTurnHandler;


        public DungeonMaster()
        {
            this.gameData = GameFactory.GetInstance().TheData;
            this.gameClient = GameFactory.GetInstance().TheClient;
            playerTurnHandler = new CommandHandler();
        }


        public void PrintWelcome()
        {
            gameClient.PlayerMessage(gameData.GetWelcomeMessage());
        }

        public void SetupPlayer()
        {
            String playerName = gameClient.GetReply("What name do you choose to be known by?");
            thePlayer = new Player(playerName);
            thePlayer.CurrentLocation = gameData.GetStartingLocation();
            gameClient.PlayerMessage("Welcome " + playerName + "\n\n");
            gameClient.PlayerMessage("You find yourself looking at ");
            gameClient.PlayerMessage(thePlayer.CurrentLocation.Description);
        }

        public void RunGame()
        {
            PrintWelcome();
            SetupPlayer();
            while (handlePlayerTurn())
            {
                // handle npc logic later here
            } 
            
            gameClient.GetReply("\n\n<<Hit enter to exit>>");
        }

        private bool handlePlayerTurn()
        {
            CommandResponse playerResponse = playerTurnHandler.ProcessTurn(gameClient.GetCommand(), thePlayer);
            gameClient.PlayerMessage(playerResponse.Message);
            return !playerResponse.FinishedGame;
        }
    }
}