using System;

using UnityEngine;

namespace CityBuilderLib
{
	internal class Vertex
	{
		public Vector3 Position { get; }
		public int Index { get; set; }

		public Vertex(float x = 0.0f, float y = 0.0f, float z = 0.0f, int index = 0)
		{
			Position = new Vector3(x, y, z);
		}
	}
}
