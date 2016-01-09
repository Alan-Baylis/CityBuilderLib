using System;


namespace CityBuilderLib
{
	internal class Tile
	{
		protected Vertex[] _vertices;
	}

	internal class BuildableTile : Tile
	{

		internal BuildableTile()
		{
			_vertices = new Vertex[4];
		}
	}
}
