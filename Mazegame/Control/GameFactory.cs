using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Mazegame.Boundary;

namespace MazeGame.Control
{
    public class GameFactory
    {
        Dictionary<string, string> config = new Dictionary<string, string>();
        private IMazeClient theClient;
        private IMazeData theData;
        private static GameFactory instance;

        private GameFactory()
        {
            ReadConfigFile();
            theClient = (IMazeClient)DynamicLoad(config["ui_assembly"], config["ui"]);
            theData = (IMazeData)DynamicLoad(config["data_assembly"], config["data"]);
        }

        public IMazeClient TheClient
        {
            get { return theClient; }
            set { theClient = value; }
        }

        public IMazeData TheData
        {
            get { return theData; }
            set { theData = value; }
        }

        private void ReadConfigFile()
        {
            StreamReader reader = new StreamReader("config.txt");
            while (!reader.EndOfStream)
            {
                string[] items = reader.ReadLine().Split('=');
                config.Add(items[0], items[1]);
            }
            reader.Close();
        }

        private Object DynamicLoad(string assemblyName, string className)
        {
            Assembly assembly = Assembly.LoadFrom(assemblyName);

            // Walk through each type in the assembly
            foreach (Type type in assembly.GetTypes())
            {
                if (type.IsClass == true)
                {
                    // doing it this way means that you don't have
                    // to specify the full namespace and class (just the class)
                    if (type.FullName.EndsWith("." + className))
                    {
                        return Activator.CreateInstance(type);
                    }
                }
            }
            throw (new Exception("could not instantiate class"));
        }

        public static GameFactory GetInstance()
        {
            if (instance == null)
                instance = new GameFactory();
            return instance;
        }
    }
}
