using System;

using CityBuilderLib;

namespace TestConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			var terrainGenerator = new TerrainGenerator();
			terrainGenerator.GenerateTerrain();
		}
	}
}
