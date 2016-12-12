using System;
using Core;

namespace UserInterface_CLI {
	internal class Program {
		ProductTypeRepository RepoPT = new ProductTypeRepository();

		static void Main(string[] args) {
			Program a = new Program();
			a.Run();
		}

		private void Run() {
			bool running = true;
			while (running) {
				Console.Clear();
				Console.WriteLine("1. List all Product Types");
				Console.WriteLine("2. Update a Product");

				string Menu = GetInput("number");
				switch (Menu) {
					case "1":
						ListAllPT();
						Console.ReadKey();
						break;

					case "2":
						UpdateProduct();
						break;
				}
			}
		}

		private void ListAllPT() {
			foreach (ProductType PT in RepoPT.GetProductTypes()) {
				Console.WriteLine(PT.Description);
				Console.WriteLine("ID: " + PT.ID);
				Console.WriteLine("Amount: " + PT.Amount);
				Console.WriteLine("Price: " + PT.Price);
			}

		}

		private void UpdateProduct() {
			FindAProduct();
		}

		private void FindAProduct() {
			ProductType PT;
			ListAllPT();

			Console.WriteLine("Type Product ID");
			int ProductID = int.Parse(GetInput("number"));
			PT = RepoPT.GetProduct(ProductID);

			Console.WriteLine("1. Update Description");
			Console.WriteLine("X. Update Amount");
			Console.WriteLine("X. Update Price");

			string Menu = GetInput("number");

			switch(Menu) {
				case "1":
					Console.WriteLine("New Description:");
					string newText = GetInput("text");
					RepoPT.AdjustDescription(PT, newText);
					Console.WriteLine("Done");
					Console.ReadKey();
					break;

				case "2":
					throw new NotImplementedException();
					break;

				case "3":
					throw new NotImplementedException();
					break;
			}
		}

		internal string GetInput(string rule = "", string err = "") {
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
