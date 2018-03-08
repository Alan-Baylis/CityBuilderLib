using System;

namespace CityBuilderLib.Mesh
{
	/// <summary>
	/// 
	/// </summary>
	internal class HalfEdge
	{
		internal Vertex PointsTo { get; set; }
		internal HalfEdge NextEdge { get; set; }
		internal HalfEdge OppositeEdge { get; set; }
		internal Face Face { get; set; }
	}
}
