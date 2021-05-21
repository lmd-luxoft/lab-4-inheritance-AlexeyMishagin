namespace Chess
{
    public class ChessPawn : ChessFigure
	{
		public ChessPawn(Type type, string currentCoord) : base(type, currentCoord)
		{
		}

		internal override bool Move(string nextCoord)
		{
			return IsCurrentNextCoord(nextCoord)
				? !(nextCoord[0] != currentCoord[0] || nextCoord[1] <= currentCoord[1] || (nextCoord[1] - currentCoord[1] != 1 && (currentCoord[1] != '2' || nextCoord[1] != '4')))
				: false;
		}
	}
}
