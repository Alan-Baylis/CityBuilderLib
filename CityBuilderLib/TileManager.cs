using System;

using UnityEngine;

namespace CityBuilderLib
{
	/// <summary>
	/// 
	/// </summary>
	public class TileManager
	{
		private readonly Tile[,] _mapTiles;

		/// <summary>
		/// 
		/// </summary>
		/// <param name="widthAndDepth"></param>
		public TileManager(int widthAndDepth)
		{
			_mapTiles = new Tile[widthAndDepth, widthAndDepth];
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="xLocation"></param>
		/// <param name="zLocation"></param>
		public void InsertTile(int xLocation, int zLocation) { }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="xLocation"></param>
		/// <param name="zLocation"></param>
		/// <param name="type"></param>
		public void SetTileType(int xLocation, int zLocation, int type) { }
	}
}
