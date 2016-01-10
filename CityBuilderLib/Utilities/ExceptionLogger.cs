using System;
using System.IO;

namespace CityBuilderLib.Utilities
{
	/// <summary>
	/// A basic utility for logging exceptions.
	/// </summary>
	internal static class ExceptionLogger
	{
		private const string _filenamePrefix = "Exceptions ";
		private const string _logExtension = ".log";
		private const string _logSubDirectory = "Logs";

		/// <summary>
		/// Logs any System.Exception to a text file.
		/// </summary>
		/// <param name="exception">The exception to log.</param>
		internal static void LogException(Exception exception)
		{
			using (var logWriter = GetLogFileWriter())
			{
				if (logWriter != null)
				{
					logWriter.WriteLine(string.Format("{0}{1}: {2}", DateTime.Now, exception, System.Environment.NewLine)); 
				}
			}
		}

		/// <summary>
		/// Generates a file name consisting of the year, month, day, and hour. If the file already exists, it will be opened; else it will be created.
		/// </summary>
		/// <returns>A valid StreamWriter for the log file to be written to.</returns>
		private static StreamWriter GetLogFileWriter()
		{
			string fileName = (_filenamePrefix + DateTime.Now.ToString("yy-MM-dd-HH") + _logExtension);

			string fullPath = Path.Combine(Directory.GetCurrentDirectory(), _logSubDirectory);
			if (!Directory.Exists(fullPath)) { Directory.CreateDirectory(fullPath); }

			fullPath = Path.Combine(fullPath, fileName);
			if (!File.Exists(fullPath)) { File.Create(fullPath).Close(); }
			
			return new StreamWriter(fullPath, true);
		}
	}
}
