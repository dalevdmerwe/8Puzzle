using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace _8Puzzle
{
    [TestFixture]
    class BoardLayoutTest
    {
        [Test]
        public void TwoBoardLayoutAreEqual()
        {
            var board1 = new BoardLayout();
            var board2 = new BoardLayout();
            Assert.That(board1.Equals(board2));
            
        }

    }
}
