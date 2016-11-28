using System;
using System.Collections.Generic;

namespace Core {
	class OrderRepository {
		private Dictionary<int, Order> Orders;
		private int OrderNumbers = 0;

		public int StartOrder(DateTime DeliveryDate) {
			int NewOrderID = this.GetNewID();
			Order order = new Order(NewOrderID, DeliveryDate);
			this.SaveOrder(order);
			return NewOrderID;
		}

		private void SaveOrder(Order order) {
			this.Orders.Add(order.ID, order);
		}

		private int GetNewID() {
			return ++this.OrderNumbers;
		}
	}
}
