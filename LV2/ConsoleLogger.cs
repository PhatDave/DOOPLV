using System;
using System.Collections.Generic;
using System.Text;

namespace LV2 {
	class ConsoleLogger : ILogger {
		public ConsoleLogger() {}

		public void Log(ILoggable message) {
			Console.WriteLine(message.GetStringRepresentation());
		}
	}
}
