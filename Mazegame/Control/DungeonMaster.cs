///////////////////////////////////////////////////////////
//  DungeonMaster.cs
//  Implementation of the Class DungeonMaster
//  Generated by Enterprise Architect
//  Created on:      28-Apr-2014 10:13:36 PM
//  Original author: Gsimmons
///////////////////////////////////////////////////////////


using System;
using System.Collections;
using Mazegame.Boundary;
using Mazegame.Entity;

namespace Mazegame.Control
{
    public class DungeonMaster
    {
        private IMazeClient gameClient;
        private IMazeData gameData;
        private Player thePlayer;
        private CommandHandler playerTurnHandler;


        public DungeonMaster(IMazeData gameData, IMazeClient gameClient)
        {
            this.gameData = gameData;
            this.gameClient = gameClient;
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
            while (HandlePlayerTurn())
            {
                // handle npc logic later here
            }

            gameClient.GetReply("\n\n<<Hit enter to exit>>");
        }

        private bool HandlePlayerTurn()
        {
            CommandResponse playerResponse = playerTurnHandler.ProcessTurn(gameClient.GetCommand(), thePlayer);
            gameClient.PlayerMessage(playerResponse.Message);
            return !playerResponse.FinishedGame;
        }
    } //end DungeonMaster
} //end namespace Control