using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class ChessKnight : ChessFigure
	{
		public ChessKnight(Type type, string currentCoord) : base(type, currentCoord)
		{
		}

		internal override bool Move(string nextCoord)
		{
			return IsCurrentNextCoord(nextCoord)
				? Math.Abs(nextCoord[0] - currentCoord[0]) == 1 && Math.Abs(nextCoord[1] - currentCoord[1]) == 2 || Math.Abs(nextCoord[0] - currentCoord[0]) == 2 && Math.Abs(nextCoord[1] - currentCoord[1]) == 1
				: false;
		}
	}
}
