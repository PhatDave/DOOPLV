using System;
using ChainOfResponsibility.Logging;
using ChainOfResponsibility.Passwords;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            RunLoggingDemo();
            RunPasswordDemo();
        }

        private static void RunPasswordDemo()
        {
            PasswordValidator passwordValidator = new PasswordValidator(new StringLengthChecker(9));
            passwordValidator.Add(new StringDigitChecker());

            Console.WriteLine(passwordValidator.IsPasswordGood("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"));
        }

        private static void RunLoggingDemo()
        {
            AbstractLogger logger = new FileLogger(MessageType.ALL, "boba.txt");
            ConsoleLogger allConsoleLogger = new ConsoleLogger(MessageType.ALL);

            FileLogger errorFileLogger = new FileLogger(MessageType.ERROR, "boba.txt");
            ConsoleLogger errorConsoleLogger = new ConsoleLogger(MessageType.ERROR | MessageType.WARNING);

            logger.SetNextLogger(errorConsoleLogger);
            errorConsoleLogger.SetNextLogger(allConsoleLogger);
            allConsoleLogger.SetNextLogger(errorFileLogger);

            logger.Log("XDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD", MessageType.WARNING);
            logger.Log("XDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD I N F O", MessageType.INFO);
        }
    }
}
