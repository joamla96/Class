using System;

namespace Core {
	public class Order {
		public int ID { get; set; }
		public DateTime Date { get; set; }
		public DateTime DeliveryDate { get; set; }
		public bool Picked { get; set; }

		public Order(int ID, DateTime DeliveryDate) {
			this.ID = ID;
			this.Date = DateTime.Now;
			this.DeliveryDate = DeliveryDate;
			this.Picked = false;
		}

	}
}
