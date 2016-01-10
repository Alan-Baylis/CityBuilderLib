using System;

using UnityEngine;

using CityBuilderLib.Mesh;

namespace CityBuilderLib
{
	/// <summary>
	/// A base tile.
	/// </summary>
	internal class Tile
	{
		protected Vertex[] _vertices;
	}

	/// <summary>
	/// A flat tile that buildings and roads can be placed on.
	/// </summary>
	internal class BuildableTile : Tile
	{
		internal MapChunk ParentChunk { get; }

		internal Vertex TopLeftVertex { get { return _vertices[0]; } }
		internal Vertex TopRightVertex { get { return _vertices[1]; } }
		internal Vertex BottomLeftVertex { get { return _vertices[0]; } }
		internal Vertex BottomRightVertex { get { return _vertices[3]; } }
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="parent"></param>
		/// <param name="originRelativeToParent"></param>
		/// <param name="tileSize"></param>
		internal BuildableTile(MapChunk parent, Vector3 originRelativeToParent, float tileSize)
		{
			_vertices = new Vertex[4];

			float halfTileSize = (tileSize / 2);

		}
	}
}
