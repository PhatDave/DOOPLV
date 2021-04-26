using System;
using System.Collections.Generic;
using System.Text;

namespace LV4 {
	class DiscountedItem : RentableDecorator {
		protected double discount { get; set; }
		private readonly double CheapItem = 0.99;
		public DiscountedItem(IRentable rentable, double discount) : base(rentable) {
			this.discount = discount;
			this.CheapItem = base.CalculatePrice() - base.CalculatePrice() * discount;
		}
		public override double CalculatePrice() {
			return this.CheapItem;
		}
		public override String Description {
			get {
				return base.Description + " now discounted by " + discount * 100 + "%!";
			}
		}
	}
}
