
using System;

namespace Chess
{
	abstract public class ChessFigure
	{
		protected Type type;
		protected string currentCoord;

		public ChessFigure(Type type, string currentCoord)
		{
			this.type = type;
			this.currentCoord = currentCoord;
		}

		public enum Type
		{
			ROOK,
			KNIGHT,
			BISHOP,
			PAWN,
			KING,
			QUEEN
		}

		abstract internal bool Move(string nextCoord);

		internal bool IsCurrentNextCoord(string nextCoord)
		{
			return nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8'
				? true
				: false;
		}
	}
}
