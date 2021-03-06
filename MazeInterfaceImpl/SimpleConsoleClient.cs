///////////////////////////////////////////////////////////
//  SimpleConsoleClient.cs
//  Implementation of the Class SimpleConsoleClient
//  Generated by Enterprise Architect
//  Created on:      28-Apr-2014 10:13:37 PM
//  Original author: Gsimmons
///////////////////////////////////////////////////////////


using System;
using Mazegame.Boundary;

namespace MazeInterfaceImpl
{
    public class SimpleConsoleClient : IMazeClient
    {
        public SimpleConsoleClient()
        {
            Console.Title = "Duke's Mansion";
            Console.WindowWidth = 100;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public String GetReply(String question)
        {
            Console.Out.Write("\n" + question + " ");
            return Console.In.ReadLine();
        }

        public void PlayerMessage(String message)
        {
            Console.Out.Write(message);
        }

        public String GetCommand()
        {
            Console.Out.Write("\n\n>>> ");
            return Console.In.ReadLine();
        }

    }

}//end namespace Mazegame