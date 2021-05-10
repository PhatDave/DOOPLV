namespace ChainOfResponsibility.Passwords
{
    abstract class StringChecker
    {
        private StringChecker next;
        public void SetNext(StringChecker next)
        {
            this.next = next;
        }
        public bool Check(string stringToCheck)
        {
            bool result = PerformCheck(stringToCheck);
            if (next != null && result == true)
            {
                return next.Check(stringToCheck);
            }
            return result;
        }
        protected abstract bool PerformCheck(string stringToCheck);
    }
}
