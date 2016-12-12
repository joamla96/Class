using System.Collections.Generic;
using System.Linq;

namespace Core {
	public class ProductTypeRepository {
		private Dictionary<int, ProductType> Repository = new Dictionary<int, ProductType>();
		// TODO: Update Diagram ^^
		public bool AdjustPrice(ProductType productType, double price) {	
			productType.SetPrice(price);
			return true;
		}

		public bool AdjustDescription(ProductType productType, string desc) {
			productType.SetDescription(desc);
			return true;
		}

		public bool AdjustAmount(ProductType productType, int amount) {
			productType.SetAmount(amount);
			return true;
		}

		public List<ProductType> GetProductTypes() {
			return Repository.Values.ToList();
		}

		public ProductType GetProduct(int ID) {
			return Repository[ID];
		}

		ProductTypeRepository() { // Initialize for debug
								 // NOTE: Remove before production

			ProductType A = new ProductType();
			A.ID = 1;  A.Amount = 10;  A.Description = "Test 1"; A.Price = 5.99;

			ProductType B = new ProductType();
			B.ID = 2;  B.Amount = 50; B.Description = "Test 2"; B.Price = 4.99;

			ProductType C = new ProductType();
			C.ID = 3;  C.Amount = 25; C.Description = "Test 3"; C.Price = 2;

			Repository.Add(A.ID, A);
			Repository.Add(B.ID, B);
			Repository.Add(C.ID, C);
		}
	}
}
