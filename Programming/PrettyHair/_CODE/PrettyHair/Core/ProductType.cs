using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core {
	public class ProductType {
		public int ID { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public int Amount { get; set; }

		public void SetPrice(double newPrice) {
			this.Price = newPrice;
		}

		public void SetDescription(string newDesc) {
			this.Description = newDesc;
		}

		public void SetAmount(int newAmount) {
			this.Amount = newAmount;
		}
	}
}
