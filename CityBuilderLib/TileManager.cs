using System;

using UnityEngine;

namespace CityBuilderLib
{
	public class TileManager
	{
		private readonly Tile[,] _mapTiles;

		public TileManager(int widthAndDepth)
		{
			_mapTiles = new Tile[widthAndDepth, widthAndDepth];
		}

		public void InsertTile(int xLocation, int zLocation) { }

		public void SetTileType(int xLocation, int zLocation, int type) { }
	}
}
