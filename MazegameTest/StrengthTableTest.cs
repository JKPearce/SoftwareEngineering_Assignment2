using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mazegame.Entity.Utility;

namespace MazegameTest
{
    [TestClass]
    public class StrengthTableTest
    {
        private StrengthTable strengthLookup;

        [TestInitialize]
        public void Init()
        {
            strengthLookup = StrengthTable.GetInstance();
            strengthLookup.SetModifier(1, -5);
            strengthLookup.SetModifier(2, -4);
            strengthLookup.SetModifier(3, -3);
        }

        [TestMethod]
        public void TestGetModifier()
        {
            Assert.IsTrue(strengthLookup.GetModifier(1) == -5);
            Assert.IsTrue(strengthLookup.GetModifier(200) == -3);
            try
            {
                strengthLookup.GetModifier(-6);
                Assert.Fail("Should have thrown exception");
            }
            catch (StrengthTableException e)
            {
                Assert.IsTrue(e.GetMessage().Contains("Can't find corresponding modifier"));
            }
        }

        [TestMethod]
        public void TestSetModifier()
        {
            strengthLookup.SetModifier(2, -4);
            Assert.IsTrue(strengthLookup.GetModifier(2) == -4);
        }
    }
}
