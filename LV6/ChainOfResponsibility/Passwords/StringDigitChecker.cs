using System.Linq;

namespace ChainOfResponsibility.Passwords
{
    class StringDigitChecker : StringChecker
    {
        protected override bool PerformCheck(string stringToCheck)
        {
            return stringToCheck.Any(it => char.IsDigit(it));
        }
    }
}
