using System;
using System.Collections.Generic;
using System.Text;

namespace LV2 {
	class RandomGenerator {
		private static Random instance;
		public static Random GetInstance() {
			if (instance == null)
				instance = new Random();
			return instance;
		}
	}
}
