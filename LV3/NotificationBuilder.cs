using System;

namespace LV3 {
	class NotificationBuilder : IBuilder {
		private string author;
		private string title;
		private DateTime time;
		private Category level;
		private ConsoleColor color;
		private string text;

		public NotificationBuilder() {
			this.author = "Pera";
			this.title = "Title";
			this.time = DateTime.Now;
			this.level = Category.ERROR;
			this.text = "Sample text";
		}

		public ConsoleNotification Build() {
			return new ConsoleNotification(this.author, this.title, this.text, this.time, this.level, this.color);
		}
		public IBuilder SetAuthor(string author) {
			this.author = author;
			return this;
		}
		public IBuilder SetTitle(string title) {
			this.title = title;
			return this;
		}
		public IBuilder SetTime(DateTime time) {
			this.time = time;
			return this;
		}
		public IBuilder SetLevel(Category level) {
			this.level = level;
			return this;
		}
		public IBuilder SetColor(ConsoleColor color) {
			this.color = color;
			return this;
		}
		public IBuilder SetText(string text) {
			this.text = text;
			return this;
		}
	}
}
