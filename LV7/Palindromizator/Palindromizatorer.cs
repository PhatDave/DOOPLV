using System;
using System.Linq;

namespace Palindromizator {
    public class Palindromizatorer {
        private string GetReverseString(string input) {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void RemoveWhitespace(ref string input) {
            input = String.Concat(input.Where(c => !Char.IsWhiteSpace(c)));
        }

        private void RemoveSpecialCharacters(ref string input) {
            input = String.Concat(input.Where(c => !Char.IsPunctuation(c)));
            input = String.Concat(input.Where(c => !Char.IsSymbol(c)));
        }

        private void RemoveDigits(ref string input) {
            input = String.Concat(input.Where(c => !Char.IsDigit(c)));
        }

        public bool IsPalindrom(string message) {
            if (message.Length < 1)
                throw new ArgumentException($"Invalid entry ({message} - string might be empty)");

            message = message.ToLower();
            RemoveWhitespace(ref message);
            RemoveSpecialCharacters(ref message);
            // Brojevi?
            // RemoveDigits(ref message);
            var messageReverse = GetReverseString(message);

            return String.Equals(message, messageReverse);
        }

        public static void Main() {
        }
    }
}
