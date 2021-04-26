using System;
using System.Collections.Generic;
using System.Text;

namespace LV2 {
	class Die {
		public int numberOfSides { get; set; }

		private Random randomGenerator = RandomGenerator.GetInstance();
		public Die(int numberOfSides) {
			this.numberOfSides = numberOfSides;
		}
		public int Roll() { return randomGenerator.Next(1, numberOfSides + 1); }
	}

}
