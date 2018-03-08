
namespace CityBuilderLib
{
	/// <summary>
	/// Map size presets for convenience.
	/// </summary>
	public enum PresetMapSize
	{
		/// <summary>
		/// Specifies a size of 64x64 tiles.
		/// </summary>
		Tiny = 64,
		/// <summary>
		/// Specifies a size of 96x96 tiles.
		/// </summary>
		Small = 96,
		/// <summary>
		/// Specifies a size of 128x128 tiles.
		/// </summary>
		Medium = 128,
		/// <summary>
		/// Specifies a size of 192x192 tiles.
		/// </summary>
		Large = 192,
		/// <summary>
		/// Specifies a size of 256x256 tiles.
		/// </summary>
		Huge = 256
	}

	/// <summary>
	/// Specifies which direction of an axis to travel in, when looping.
	/// </summary>
	public enum AxisDirection
	{
		/// <summary>
		/// Specifies the negative direction (*-1).
		/// </summary>
		Negative = -1,
		/// <summary>
		/// Specifies the positive direction (*1).
		/// </summary>
		Positive = 1
	}
}
