using System;
using System.Collections.Generic;
using System.Text;

namespace LV2 {
	class FileLogger : ILogger {
		private string filePath;

		public FileLogger(string fileName) {
			this.filePath = fileName;
		}

		public void Log(ILoggable message) {
			using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath, true))
				writer.Write(message.GetStringRepresentation() + "\n");
		}
	}
}
