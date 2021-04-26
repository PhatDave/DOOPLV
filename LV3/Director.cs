using System;

namespace LV3 {
	class Director {
		private IBuilder builder;
		public Director(IBuilder builder) {
			this.builder = builder;
		}
		public ConsoleNotification CreateINFONotification(string author) {
			builder.SetAuthor(author)
				.SetColor(ConsoleColor.Cyan)
				.SetTime(DateTime.Now)
				.SetLevel(Category.INFO)
				.SetTitle("INFO")
				.SetText("Info");
			return builder.Build();
		}
		public ConsoleNotification CreateALERTNotification(string author) {
			builder.SetAuthor(author)
				.SetColor(ConsoleColor.DarkYellow)
				.SetTime(DateTime.Now)
				.SetLevel(Category.INFO)
				.SetTitle("ALERT")
				.SetText("Alert");
			return builder.Build();
		}
		public ConsoleNotification CreateERRORNotification(string author) {
			builder.SetAuthor(author)
				.SetColor(ConsoleColor.Red)
				.SetTime(DateTime.Now)
				.SetLevel(Category.INFO)
				.SetTitle("ERROR")
				.SetText("Error");
			return builder.Build();
		}
	}
}
