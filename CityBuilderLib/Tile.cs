using System;
using UnityEngine;

namespace CityBuilderLib
{
	internal class Tile
	{
		protected Vertex[] _vertices;
	}

	internal class BuildableTile : Tile
	{
		internal MapChunk ParentChunk { get; }

		internal Vertex TopLeftVertex { get { return _vertices[0]; } }
		internal Vertex TopRightVertex { get { return _vertices[1]; } }
		internal Vertex BottomLeftVertex { get { return _vertices[0]; } }
		internal Vertex BottomRightVertex { get { return _vertices[3]; } }
		
		internal BuildableTile(MapChunk parent, Vector3 originRelativeToParent, float tileSize)
		{
			_vertices = new Vertex[4];

			float halfTileSize = (tileSize / 2);

		}
	}
}
