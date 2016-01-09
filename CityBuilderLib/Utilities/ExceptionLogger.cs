using System;
using System.IO;

namespace CityBuilderLib.Utilities
{
	internal static class ExceptionLogger
	{
		private const string _filenamePrefix = "Exceptions ";
		private const string _logExtension = ".log";
		private const string _logSubDirectory = "Logs";

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
