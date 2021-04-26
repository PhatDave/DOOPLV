using System;
using System.Collections.Generic;
using System.Text;

namespace LV2 {
	class Logger {
		private string filePath = null;

		public Logger(string filePath) {
			this.filePath = filePath;
		}
		public Logger() { }

		public void Log(string message) {
			if (this.filePath != null)
				using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath, true))
					writer.WriteLine(message);
			else
				Console.WriteLine(message);
		}
	}
}
