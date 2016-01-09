using System;
using System.Collections.Generic;

using UnityEngine;

using CityBuilderLib.Utilities;

namespace CityBuilderLib
{
	public class TerrainGenerator
	{
		private const float _tileSizeInUnityUnits = 10.0f;

		public void GenerateTerrain()
		{
			try
			{
				GenerateMapChunk();
			}
			catch (Exception ex)
			{
				ExceptionLogger.LogException(ex);
			}

		}

		public void GenerateTerrain(PresetMapSize mapSizeInTiles, GameObject parentObject)
		{
			//GameObject NorthQuadrant = GenerateQuadrant((ushort)mapSizeInTiles, "North Quadrant", AxisDirection.Positive, AxisDirection.Positive);
			//GameObject SouthQuadrant = GenerateQuadrant((ushort)mapSizeInTiles, "South Quadrant", AxisDirection.Negative, AxisDirection.Negative);
			//GameObject EastQuadrant = GenerateQuadrant((ushort)mapSizeInTiles, "East Quadrant", AxisDirection.Positive, AxisDirection.Negative);
			//GameObject WestQuadrant = GenerateQuadrant((ushort)mapSizeInTiles, "West Quadrant", AxisDirection.Negative, AxisDirection.Positive);

			//NorthQuadrant.transform.SetParent(parentObject.transform);
			//SouthQuadrant.transform.SetParent(parentObject.transform);
			//EastQuadrant.transform.SetParent(parentObject.transform);
			//WestQuadrant.transform.SetParent(parentObject.transform);
		}

		[Obsolete("The generator now generates meshes in a different manner. This method exists for reference only.", true)]
		private GameObject GenerateQuadrant(ushort size, string name, AxisDirection xDirection, AxisDirection zDirection)
		{
			GameObject quadrant = new GameObject();
			quadrant.name = name;
			var meshFilter = quadrant.AddComponent<MeshFilter>();
			meshFilter.mesh = GenerateQuadrantSubMesh(size, xDirection, zDirection);
			quadrant.AddComponent<MeshRenderer>();
			return quadrant;
		}

		[Obsolete("The generator now generates meshes in a different manner. This method exists for reference only.", true)]
		private Mesh GenerateQuadrantSubMesh(float startingPositionX, float startingPositionZ, int squareSizeInTiles)
		{
			var vertices = new List<Vector3>();
			var indices = new List<int>();

			for (int z = 0; z < (squareSizeInTiles + 1); z++)
			{
				for (int x = 0; x < (squareSizeInTiles + 1); x++)
				{
					vertices.Add(new Vector3((startingPositionX + (x * _tileSizeInUnityUnits)), 0, (startingPositionZ - (z * _tileSizeInUnityUnits))));

					// Indices and UVs
					if (x > 0 && z > 0)
					{
						int indexA = ((squareSizeInTiles + 1) * z) + x;
						int indexB = ((squareSizeInTiles + 1) * z) + (x - 1);
						int indexC = ((squareSizeInTiles + 1) * (z - 1)) + (x - 1);
						int indexD = ((squareSizeInTiles + 1) * (z - 1)) + x;

						indices.Add(indexB);
						indices.Add(indexC);
						indices.Add(indexD);
						indices.Add(indexB);
						indices.Add(indexD);
						indices.Add(indexA);
					}
				}
			}
			
			var mesh = new Mesh();
			mesh.vertices = vertices.ToArray();
			mesh.triangles = indices.ToArray();

			return mesh;
		}

		[Obsolete("The generator now generates meshes in a different manner. This method exists for reference only.", true)]
		private Mesh GenerateQuadrantSubMesh(ushort size, AxisDirection xDirection, AxisDirection zDirection)
		{
			if (size > 0)
			{
				var vertices = new List<Vector3>();
				var indices = new List<int>();

				var step = 0;
				for (var z = 0; z < (size + 1); z++)
				{
					for (var x = 0; x < ((size + 1) - step); x++)
					{
						var xPosition = (x * _tileSizeInUnityUnits * (int)xDirection);
						var zPosition = (z * _tileSizeInUnityUnits * (int)zDirection);
						vertices.Add(new Vector3(xPosition, 0, zPosition));

						if (z > 0 && x > 0)
						{
							// Wire up triangle indices

						}
					}

					if (z > 0) { step++; }
				}

				var mesh = new Mesh()
				{
					vertices = vertices.ToArray(),
					triangles = null
				};

				return mesh;
			}
			else
			{
				throw new ArgumentException("Map size must be greater than zero.");
			}
		}

		private GameObject GenerateMapChunk(byte size = 32)
		{
			for (int z = 0; z < size; z++)
			{
				float zPosition = ((z * _tileSizeInUnityUnits) - ((((float)(size - 1)) / 2) * _tileSizeInUnityUnits));
				for (int x = 0; x <= size; x++)
				{
					int place = x;
				}
			}

			throw new Exception("Test Exception.");
			return null;
		}
	}
}
