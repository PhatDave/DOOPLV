using System;
using System.Collections.Generic;
using System.Text;

namespace LV4 {
	class EmailValidator : IEmailValidatorService {
		public int MinLength { get; private set; }
		public EmailValidator(int minLength) {
			this.MinLength = minLength;
		}
		public bool IsValidAddress(String candidate) {
			return !String.IsNullOrEmpty(candidate) && candidate.Length >= this.MinLength && candidate.Contains('@') && candidate.EndsWith(".com");
		}
	}
}
