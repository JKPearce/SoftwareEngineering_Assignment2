using System;
using Mazegame.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MazegameTest
{
    [TestClass]
    public class LocationTest
    {
        private Location t127;
        private Location gregsoffice;

        [TestInitialize]
        public void init()
        {
            t127 = new Location("a lecture theatre", "T127", new NonPlayerCharacter("Johnny", "heyo", false));
            gregsoffice = new Location("a spinning vortex of terror", "Greg's Office", new NonPlayerCharacter("Johnny", "heyo", false));    
        }

        [TestMethod]
        public void TestAddExit()
        {
            // add some exits should return true
            Assert.IsTrue(t127.GetExitCollection().AddExit("south", new Exit("you see a mound of paper to the south", gregsoffice)));
            Assert.IsTrue(gregsoffice.GetExitCollection().AddExit("north", new Exit("you see a bleak place to the north", t127)));
            //should already have an exit south so cant add another one
            Assert.IsFalse(t127.GetExitCollection().AddExit("south", new Exit("desc", gregsoffice)));
        }

        [TestMethod]
        public void TestGetExit()
        {
            Exit myExit = new Exit("you see a mound of paper to the south", gregsoffice);
            t127.GetExitCollection().AddExit("south", myExit);
            Assert.AreSame(myExit,t127.GetExitCollection().GetExit("south"));
            Assert.IsNull(t127.GetExitCollection().GetExit("north"));
        }
    }
}
