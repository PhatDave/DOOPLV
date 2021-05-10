namespace ChainOfResponsibility.Passwords
{
    class StringLengthChecker : StringChecker
    {
        public int MinLength { get; private set; }

        public StringLengthChecker(int minLength) => MinLength = minLength;
        protected override bool PerformCheck(string stringToCheck) => stringToCheck.Length >= MinLength;
    }
}
