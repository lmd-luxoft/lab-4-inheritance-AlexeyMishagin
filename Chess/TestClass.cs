// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Chess
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void RookShouldBeCorrectMove()
        {
            Chess figure = new Chess(ChessFigure.Type.ROOK, "E2");
            Assert.AreEqual(true,figure.Move("C2"));
        }
        [Test]
        public void RookShouldBeIncorrectMove()
        {
            Chess figure = new Chess(ChessFigure.Type.ROOK, "E2");
            Assert.AreEqual(false,figure.Move("C5"));
        }
        [Test]
        public void KnightShouldBeCorrectMove()
        {
            Chess figure = new Chess(ChessFigure.Type.KNIGHT, "B1");
            Assert.AreEqual(true,figure.Move("C3"));
        }
        [Test]
        public void KnightShouldBeIncorrectMove()
        {
            Chess figure = new Chess(ChessFigure.Type.KNIGHT, "B1");
            Assert.AreEqual(false,figure.Move("C5"));
        }
        [Test]
        public void BishopShouldBeCorrectMove()
        {
            Chess figure = new Chess(ChessFigure.Type.BISHOP, "C1");
            Assert.AreEqual(true,figure.Move("E3"));
        }
        [Test]
        public void BishopShouldBeIncorrectMove()
        {
            Chess figure = new Chess(ChessFigure.Type.BISHOP, "C1");
            Assert.AreEqual(false,figure.Move("C3"));
        }
        [Test]
        public void PawnShouldBeCorrectMove0()
        {
            Chess figure = new Chess(ChessFigure.Type.PAWN, "E2");
            Assert.AreEqual(true,figure.Move("E3"));
        }
        [Test]
        public void PawnShouldBeCorrectMove1()
        {
            Chess figure = new Chess(ChessFigure.Type.PAWN, "E2");
            Assert.AreEqual(true,figure.Move("E4"));
        }
        [Test]
        public void PawnShouldBeCorrectMove2()
        {
            Chess figure = new Chess(ChessFigure.Type.PAWN, "E4");
            Assert.AreEqual(true,figure.Move("E5"));
        }   
        [Test]
        public void PawnShouldBeIncorrectMove()
        {
            Chess figure = new Chess(ChessFigure.Type.PAWN, "E2");
            Assert.AreEqual(false,figure.Move("C5"));
        }
        [Test]
        public void KingShouldBeCorrectMove()
        {
            Chess figure = new Chess(ChessFigure.Type.KING, "E1");
            Assert.AreEqual(true,figure.Move("E2"));
        }
        [Test]
        public void KingShouldBeIncorrectMove()
        {
            Chess figure = new Chess(ChessFigure.Type.KING, "E1");
            Assert.AreEqual(false,figure.Move("E8"));
        }
        [Test]
        public void QueenShouldBeCorrectMoveVertical()
        {
            Chess figure = new Chess(ChessFigure.Type.QUEEN, "D1");
            Assert.AreEqual(true,figure.Move("D8"));
        }
        [Test]
        public void QueenShouldBeCorrectMoveDiagonal()
        {
            Chess figure = new Chess(ChessFigure.Type.QUEEN, "D1");
            Assert.AreEqual(true,figure.Move("H5"));
        }
        [Test]
        public void QueenShouldBeIncorrectMove()
        {
            Chess figure = new Chess(ChessFigure.Type.QUEEN, "D1");
            Assert.AreEqual(false,figure.Move("E3"));
        }
    }
}
