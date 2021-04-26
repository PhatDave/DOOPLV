using System;
using System.Collections.Generic;

namespace LV4 {
	class Program {
		static void Main(string[] args) {
			//Dataset dataset           = new Dataset("set.csv");
			//Analyzer3rdParty analyzer = new Analyzer3rdParty();
			//Adapter adapter           = new Adapter(analyzer);

			//adapter.CalculateAveragePerColumn(dataset);



			//RentingConsolePrinter rentingConsolePrinter = new RentingConsolePrinter();

			//List<IRentable> list = new List<IRentable>();
			//list.Add(new HotItem(new Book("mujo")));
			//list.Add(new HotItem(new Video("pero")));

			//List<IRentable> flashSale = new List<IRentable>();
			//list.ForEach(e => flashSale.Add(new DiscountedItem(e, 0.33)));

			//rentingConsolePrinter.PrintTotalPrice(list);
			//rentingConsolePrinter.DisplayItems(list);
			//rentingConsolePrinter.PrintTotalPrice(flashSale);
			//rentingConsolePrinter.DisplayItems(flashSale);



			IEmailValidatorService emailValidator = new EmailValidator(10);
			IPasswordValidatorService passwordValidator = new PasswordValidator(10);
			UserEntry entry;
			do {
				entry = UserEntry.ReadUserFromConsole();
			} while (!emailValidator.IsValidAddress(entry.Email) | !passwordValidator.IsValidPassword(entry.Password));
		}
	}
}
