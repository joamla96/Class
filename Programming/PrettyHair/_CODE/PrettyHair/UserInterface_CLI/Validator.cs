using System.Text.RegularExpressions;

namespace UserInterface_CLI {
	class Validator {
		public bool text(string input) {
			return Regex.IsMatch(input, @"^[a-zA-Z]+$");
		}

		public bool number(string input) {
			return Regex.IsMatch(input, @"^[0-9]+$");
		}

		public bool alphanum(string input) {
			return Regex.IsMatch(input, @"^[a-zA-Z0-9]+$");
		}

		public bool phone(string input) { // This might not be right...
			return Regex.IsMatch(input, @"^[(+||00)\d{10}]+S");
		}
	}
}
