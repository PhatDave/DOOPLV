using System;
using System.Collections.Generic;
using System.Text;

namespace LV4 {
	class Analyzer3rdParty {
		public double[] PerRowAverage(double[][] data) {
			int rowCount = data.Length;
			double[] results = new double[rowCount];
			for (int i = 0; i < rowCount; i++) {
				results[i] = data[i][i];
			}
			return results;
		}
		public double[] PerColumnAverage(double[][] data) {
			int rowCount     = data.Length;
			int columnCount  = data[0].Length;
			double[] results = new double[data[0].Length];

			for (int i = 0; i < columnCount; i++) {
				double sum = 0;
				for (int j = 0; j < rowCount; j++)
					sum += data[j][i];
				results[i]   = sum /= rowCount;
			}
			return results;
		}
	}

}
