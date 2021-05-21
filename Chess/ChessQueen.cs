using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class ChessQueen : ChessFigure
	{
		public ChessQueen(Type type, string currentCoord) : base(type, currentCoord)
		{
		}

		internal override bool Move(string nextCoord)
		{
			return IsCurrentNextCoord(nextCoord)
				? Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1]) || nextCoord[0] == currentCoord[0] || nextCoord[1] == currentCoord[1]
				: false;
		}
	}
}
