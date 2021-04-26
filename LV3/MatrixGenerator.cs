using System;

namespace LV3 {
	class MatrixGenerator {
		private Random randomGenerator = new Random();
		private static MatrixGenerator generator;
		private MatrixGenerator() {
		}
		public static MatrixGenerator GetInstance() {
			if (generator == null)
				generator = new MatrixGenerator();
			return generator;
		}
		public double[][] CreateMatrix(int rows, int columns) {
			double[][] matrix = new double[rows][];
			for (int i = 0; i < rows; i++)
				matrix[i] = new double[columns];

			for (int i = 0; i < rows; i++) {
				for (int j = 0; j < columns; j++) {
					matrix[i][j] = randomGenerator.NextDouble();
				}
			}

			return matrix;
		}
	}
}
