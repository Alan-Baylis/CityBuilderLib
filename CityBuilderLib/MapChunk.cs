using System;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilderLib
{
	internal class MapChunk
	{
		private const byte _chunkSize = 32;
		private readonly float _tileSizeInUnityUnits;
		private readonly Tile[][] _tiles;

		private MapChunk _west_Neighbor;
		private MapChunk _east_Neighbor;
		private MapChunk _northwest_Neighbor;
		private MapChunk _northeast_Neighbor;
		private MapChunk _southwest_Neighbor;
		private MapChunk _southeast_Neighbor;

		internal MapChunk(float tileSizeInUnityUnits)
		{
			_tileSizeInUnityUnits = tileSizeInUnityUnits;
		}

		private void Generate()
		{
			var vertices = new List<Vertex>();
			var indices = new List<int>();

			float halfSize = (((float)_chunkSize + 1) / 2);
			int prevRowFaceCount = 0;
			for (int z = 0; z <= (_chunkSize + 1); z++)
			{
				int currRowFaceCount = (int)(2 * (-Mathf.Abs(z - halfSize) + halfSize));
				if (currRowFaceCount > 0)
				{
					for (int x = 0; x < (currRowFaceCount + 1); x++)
					{
						float xPosition = ((x) - (currRowFaceCount / 2) * _tileSizeInUnityUnits);
						float zPosition = 0.0f;

						var vertex = new Vertex(xPosition, 0, zPosition);
						vertices.Add(vertex);
						int indexOfCurrentVertex = vertices.IndexOf(vertex);


					}
				}
				prevRowFaceCount = currRowFaceCount;
			}
		}
	}
}
