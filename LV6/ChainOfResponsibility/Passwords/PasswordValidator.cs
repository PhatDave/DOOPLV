namespace ChainOfResponsibility.Passwords
{
    class PasswordValidator
    {
        private StringChecker first;
        private StringChecker last;

        public PasswordValidator(StringChecker checker)
        {
            first = checker;
            last = checker;
        }
        public void Add(StringChecker checker)
        {
            last.SetNext(checker);
            last = checker;
        }
        public bool IsPasswordGood(string password) => first.Check(password);
    }
}
