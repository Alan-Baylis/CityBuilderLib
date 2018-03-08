using System;

using UnityEngine;

namespace CityBuilderLib.Mesh
{
	/// <summary>
	/// 
	/// </summary>
	internal class Vertex
	{
		/// <summary>
		/// 
		/// </summary>
		public Vector3 Position { get; }

		/// <summary>
		/// 
		/// </summary>
		public int Index { get; set; }

		/// <summary>
		/// 
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <param name="z"></param>
		/// <param name="index"></param>
		public Vertex(float x = 0.0f, float y = 0.0f, float z = 0.0f, int index = 0)
		{
			Position = new Vector3(x, y, z);
		}
	}
}
