
using System;

namespace Chess
{
    public class ChessFigure
    {
        private Type type;
        private string currentCoord;

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

        internal bool Move(string nextCoord)
        {
			if (type == Type.PAWN)
			{
				if (IsCurrentNextCoord(nextCoord))
				{
					if (nextCoord[0] != currentCoord[0] || nextCoord[1] <= currentCoord[1] || (nextCoord[1] - currentCoord[1] != 1 && (currentCoord[1] != '2' || nextCoord[1] != '4')))
						return false;
					else
						return true;
				}
				else return false;

			}

			else if (type == Type.ROOK)
			{
				if (IsCurrentNextCoord(nextCoord))
				{
					if ((nextCoord[0] != currentCoord[0]) && (nextCoord[1] != currentCoord[1]) || ((nextCoord[0] == currentCoord[0]) && (nextCoord[1] == currentCoord[1])))
						return false;
					else
						return true;

				}
				else return false;
			}
			else if (type == Type.KNIGHT)
			{
				if (IsCurrentNextCoord(nextCoord))
				{
					int dx, dy;
					dx = Math.Abs(nextCoord[0] - currentCoord[0]);
					dy = Math.Abs(nextCoord[1] - currentCoord[1]);
					if (!(Math.Abs(nextCoord[0] - currentCoord[0]) == 1 && Math.Abs(nextCoord[1] - currentCoord[1]) == 2 || Math.Abs(nextCoord[0] - currentCoord[0]) == 2 && Math.Abs(nextCoord[1] - currentCoord[1]) == 1))
						return false;
					else
						return true;
				}
				else return false;
			}

			else if (type == Type.BISHOP)
			{
				if (IsCurrentNextCoord(nextCoord))
				{
					if (!(Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1])))
						return false;
					else
						return true;
				}
				else return false;
			}

			else if (type == Type.KING)
			{
				if (IsCurrentNextCoord(nextCoord))
				{
					if (!(Math.Abs(nextCoord[0] - currentCoord[0]) <= 1 && Math.Abs(nextCoord[1] - currentCoord[1]) <= 1))
						return false;
					else
						return true;
				}
				else return false;
			}
			else if (type == Type.QUEEN)
			{
				if (IsCurrentNextCoord(nextCoord))
				{
					if (!(Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1]) || nextCoord[0] == currentCoord[0] || nextCoord[1] == currentCoord[1]))
						return false;
					else
						return true;
				}
				else return false;
			}
			else
				return false;
		}

		internal bool IsCurrentNextCoord(string nextCoord)
		{
			if (nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8')
				return true;
			return false;
		}
    }
}
