using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DB06 {
	class Program {
		private static string ConnectionArgs =
			"Server=ealdb1.eal.local; Database=ejl76_db; User Id=ejl76_usr; Password=Baz1nga76;";
		private bool Running = true;
		static void Main(string[] args) {
			Program prog = new Program();
			prog.Run();
		}

		private void Run() {
			while(Running) {
				Console.Clear();

				Console.WriteLine("Please Select your Operation:\n");
				Console.WriteLine("1. Insert Pet");

				Console.WriteLine("\nInsert Option (Eg. 1):");
				string Input = Console.ReadLine();

				switch (Input) {
					case "1": MenuInsertPet(); break;

					case "x":
					case "X": MenuExit(); break;
					default: Console.WriteLine("\n\nInvalid Menu Entry!"); Console.ReadKey(); break;
				}
			}
		}

		private void MenuExit() {
			throw new NotImplementedException();
		}

		private void MenuInsertPet() {
			Console.Clear();
			Console.WriteLine("Inserting a Pet.\n\n");

			Console.WriteLine("Name:");
			string PetName = Console.ReadLine();

			Console.WriteLine("Type:");
			string PetType = Console.ReadLine();

			Console.WriteLine("Breed:");
			string PetBreed = Console.ReadLine();

			Console.WriteLine("Date of Birth (dd/mm/yyyy):");
			string PetDOB_temp = Console.ReadLine();

			Console.WriteLine("Weight:");
			string PetWeight = Console.ReadLine();

			Console.WriteLine("Owners ID:");
			string PetOwnerID = Console.ReadLine();

			DateTime PetDOB = DateTime.Parse(PetDOB_temp);

			using (SqlConnection DB = new SqlConnection(ConnectionArgs)) {
				try {
					DB.Open();

					SqlCommand cmd = new SqlCommand("usp_InsertPet", DB);
					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.Add(new SqlParameter("PetName", PetName));
					cmd.Parameters.Add(new SqlParameter("PetType", PetType));
					cmd.Parameters.Add(new SqlParameter("PetBreed", PetBreed));
					cmd.Parameters.Add(new SqlParameter("PetDOB", PetDOB.ToString("yyyy-MM-dd")));
					cmd.Parameters.Add(new SqlParameter("PetWeight", PetWeight));
					cmd.Parameters.Add(new SqlParameter("OwnerID", PetOwnerID));

					cmd.ExecuteNonQuery();
				} catch (SqlException e) {
					Console.WriteLine("Error: " + e.Message);
				}
			}
		}

		private void function() {
			using (SqlConnection DB = new SqlConnection(ConnectionArgs)) {
				try {
					DB.Open();


				} catch (SqlException e) {
					Console.WriteLine("Error: " + e.Message);
				}
			}
		}
	}
}
