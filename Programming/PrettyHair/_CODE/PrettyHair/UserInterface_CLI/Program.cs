using System;

namespace UserInterface_CLI {
	class Program {
		static void Main(string[] args) {
			Program a = new Program();
			a.Run();
		}

		private void Run() {

		}

		private string GetInput(string rule = "", string err = "") {
			if (err != "") {
				Console.WriteLine("\n" + err);
			}
			string Input = Console.ReadLine();
			Validator Valid = new Validator();
			switch (rule) {
				case "text":
					if (!Valid.text(Input)) return GetInput(rule, "Text Only!");
					break;

				case "number":
					if (!Valid.number(Input)) return GetInput(rule, "Numbers Only!");
					break;


				default:
					if (rule != "") throw new Exception("Invalid Validation Parameter");
					break;
			}
			return Input;
		}
	}
}
