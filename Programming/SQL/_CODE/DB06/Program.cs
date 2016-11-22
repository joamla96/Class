using System;
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
			while (Running) {
				Console.Clear();

				Console.WriteLine("Please Select your Operation:\n");
				Console.WriteLine("1. Insert new Pet");
				Console.WriteLine("2. Show All Pets");
				Console.WriteLine("3. Insert new Pet OWner");

				Console.WriteLine("\nInsert Option (Eg. 1):");
				string Input = Console.ReadLine();

				switch (Input) {
					case "1": MenuInsertPet(); break;
					case "2": MenuShowAllPets(); break;
					case "3": MenuInsertNewOwner(); break;

					case "x":
					case "X": MenuExit(); break;
					default: Console.WriteLine("\n\nInvalid Menu Entry!"); Console.ReadKey(); break;
				}
			}
		}

		private void MenuInsertNewOwner() {
			Console.WriteLine("Write Firstname:");
			string Firstname = Console.ReadLine();

			Console.WriteLine("Write Lastname:");
			string Lastname = Console.ReadLine();

			Console.WriteLine("Write Phone Number:");
			string Phone = Console.ReadLine();

			Console.WriteLine("Write Email:");
			string Email = Console.ReadLine();


			using (SqlConnection DB = new SqlConnection(ConnectionArgs)) {
				SqlCommand cmd = new SqlCommand("usp_InsertOwner", DB);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add(new SqlParameter("OwnerFirstName", Firstname));
				cmd.Parameters.Add(new SqlParameter("OwnerLastName", Lastname));
				cmd.Parameters.Add(new SqlParameter("OwnerPhone", Phone));
				cmd.Parameters.Add(new SqlParameter("OwnerEmail", Email));

				try {
					DB.Open();
					cmd.ExecuteNonQuery();
					Console.WriteLine("\nSuccess!");
				} catch (SqlException e) {
					Console.WriteLine("Error: " + e.Message);
				} finally {
					DB.Close();
				}
			}
			Console.ReadKey();
		}

		private void MenuShowAllPets() {
			using (SqlConnection DB = new SqlConnection(ConnectionArgs)) {
				try {
					DB.Open();

					SqlCommand cmd = new SqlCommand("usp_GetPets", DB);
					cmd.CommandType = CommandType.StoredProcedure;

					SqlDataReader reader = cmd.ExecuteReader();

					Console.WriteLine("ID	Name	Type	Breed	DOB	Weight	OwnerID");
					if (reader.HasRows) {
						while (reader.Read()) {
							string ID = reader["PetID"].ToString();
							string Name = reader["PetName"].ToString();
							string Type = reader["PetType"].ToString();
							string Breed = reader["PetBreed"].ToString();
							string DOB = reader["PetDOB"].ToString();
							string Weight = reader["PetWeight"].ToString();
							string OwnerID = reader["OwnerID"].ToString();

							Console.Write(ID + "\t" + Name + "\t" + Type + "\t" + Breed + "\t" + DOB + "\t" + Weight + "\t" + OwnerID + "\n");
						}
					} else {
						Console.WriteLine("No Records Found.");
					}

				} catch (SqlException e) {
					Console.WriteLine("Error: " + e.Message);
				} finally {
					DB.Close();
				}


				Console.WriteLine("\n\nClick any key, to return to menu.");
				Console.ReadKey();
			}
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
				SqlCommand cmd = new SqlCommand("usp_InsertPet", DB);
				cmd.CommandType = CommandType.StoredProcedure;

				cmd.Parameters.Add(new SqlParameter("PetName", PetName));
				cmd.Parameters.Add(new SqlParameter("PetType", PetType));
				cmd.Parameters.Add(new SqlParameter("PetBreed", PetBreed));
				cmd.Parameters.Add(new SqlParameter("PetDOB", PetDOB.ToString("yyyy-MM-dd")));
				cmd.Parameters.Add(new SqlParameter("PetWeight", PetWeight));
				cmd.Parameters.Add(new SqlParameter("OwnerID", PetOwnerID));

				try {
					DB.Open();
					cmd.ExecuteNonQuery();
				} catch (SqlException e) {
					Console.WriteLine("Error: " + e.Message);
				} finally {
					DB.Close();
				}
			}
		}

		private void MenuExit() {
			throw new NotImplementedException();
		}

		private void function() {
			using (SqlConnection DB = new SqlConnection(ConnectionArgs)) {
				try {
					DB.Open();


				} catch (SqlException e) {
					Console.WriteLine("Error: " + e.Message);
				} finally {
					DB.Close();
				}
			}
		}
	}
}
