using System;

namespace LV3 {
	class Program {
		static void Main(string[] args) {
			// 1. toboze
			//Dataset data = new Dataset("csv.txt");
			//IList<List<string>> fileData = data.GetData();
			//foreach (var row in fileData) {
			//	foreach (var element in row) {
			//		Console.Write(element + " ");
			//	}
			//	Console.WriteLine();
			//}
			//Console.WriteLine();

			//Dataset dataCopy = (Dataset)data.Clone();
			//dataCopy.ChangeFirstElement();
			//IList<List<string>> fileDataCopy = dataCopy.GetData();
			//foreach (var row in fileDataCopy) {
			//	foreach (var element in row) {
			//		Console.Write(element + " ");
			//	}
			//	Console.WriteLine();
			//}


			// ko bajage 2.
			//MatrixGenerator generator = MatrixGenerator.GetInstance();
			//double[][] matrix = generator.CreateMatrix(6, 9);
			//foreach (var row in matrix) {
			//	foreach (var element in row)
			//		Console.Write(element + " ");
			//	Console.WriteLine("");
			//}


			// 3. kao
			//FileLogger logger = FileLogger.GetInstance();
			//logger.Log("XDDDDDDDDDD");
			//logger.filePath = "log2.txt";
			//logger.Log("XDDDDDDD");


			// idemo malo gradit i enumat
			//ConsoleNotification consoleNotification = new ConsoleNotification("ja", "prvi", "bogec", DateTime.Now, Category.ALERT, ConsoleColor.Cyan);
			//NotificationManager manager = new NotificationManager();
			//manager.Display(consoleNotification);

			NotificationManager manager = new NotificationManager();

			NotificationBuilder builder = new NotificationBuilder();
			Director director = new Director(builder);
			manager.Display(director.CreateINFONotification("XDDDDDDDDDDDDDDDDDDD"));
			manager.Display(director.CreateALERTNotification("XDDDDDDDDDDDDDDDDDDD"));
			manager.Display(director.CreateERRORNotification("XDDDDDDDDDDDDDDDDDDD"));

			builder.SetAuthor("ivan")
				.SetColor(ConsoleColor.Red)
				.SetTime(DateTime.Now)
				.SetLevel(Category.INFO);
			manager.Display(builder.Build());

			builder.SetAuthor("Pero")
				.SetColor(ConsoleColor.Green);
			manager.Display(builder.Build());

		}
	}
}
