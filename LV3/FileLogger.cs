using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LV3 {
	class FileLogger {
		private static FileLogger logger;
		public string filePath {get; set;}
		private FileLogger() {
			filePath = "bogec.txt";
		}
		public static FileLogger GetInstance() {
			if (logger == null)
				logger = new FileLogger();
			return logger;
		}
		public void Log(string message) {
			using (StreamWriter sw = new StreamWriter(filePath, true))
				sw.Write(message);
		}
	}
}
