using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Chess
    {
        protected ChessFigure.Type type;
        protected string currentCoord;
        protected string nextCoord;
        public ChessFigure ChessFigure { private get; set; }

        public Chess(ChessFigure.Type type, string currentCoord)
        {
            if (type == ChessFigure.Type.PAWN)
                ChessFigure = new ChessPawn(type, currentCoord);

            if (type == ChessFigure.Type.BISHOP)
                ChessFigure = new ChessBishop(type, currentCoord);

            if (type == ChessFigure.Type.KING)
                ChessFigure = new ChessKing(type, currentCoord);

            if (type == ChessFigure.Type.KNIGHT)
                ChessFigure = new ChessKnight(type, currentCoord);

            if (type == ChessFigure.Type.QUEEN)
                ChessFigure = new ChessQueen(type, currentCoord);

            if (type == ChessFigure.Type.ROOK)
                ChessFigure = new ChessRook(type, currentCoord);
        }
        public bool Move(string nextCoord)
        {
            return ChessFigure.Move(nextCoord);
        }
    }
}
