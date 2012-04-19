using Bowling;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BowlingTest
{
    
    
    /// <summary>
    ///这是 ProgramTest 的测试类，旨在
    ///包含所有 ProgramTest 单元测试
    ///</summary>
    [TestClass()]
    public class ProgramTest
    {
        private Game game = new Game();
               
        
        [TestMethod]
        public void FirstThrow()
        {   
            game.Throw(5);
            Assert.AreEqual(5,game.Score);
        }

        [TestMethod]
        public void TestThrowallzore()
        {
            TestThrowmany(20, 0);
            Assert.AreEqual(0, game.score());
        }

        [TestMethod]
        public void TestThrowallone()
        {
            TestThrowmany(20, 1);
            Assert.AreEqual(20, game.score());
        }

        [TestMethod]
        public void TestThrowOneSpare()
        {
            game.roll(5);
            game.roll(5); 
            game.roll(3);
            TestThrowmany(17, 0);
            Assert.AreEqual(16, game.score());
        }
   
   

        
        public void TestThrowmany(int n, int pins)
        {
           
            for (int i = 0; i < n; i++)
               game.roll(pins);
        }


        private void rollSpare()
        {
            game.roll(5);
            game.roll(5);
        }


      
    }
}
