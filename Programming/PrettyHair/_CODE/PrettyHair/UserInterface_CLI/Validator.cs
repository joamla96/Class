using System.Text.RegularExpressions;

namespace UserInterface_CLI {
	class Validator {
		public bool text(string input) {
			return Regex.IsMatch(input, @"^[a-zA-Z]+$");
		}

		public bool number(string input) {
			return Regex.IsMatch(input, @"^[0-9]+$");
		}
	}
}
