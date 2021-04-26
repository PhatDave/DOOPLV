using System;
using System.Collections.Generic;
using System.Text;

namespace LV4 {
	class Adapter : IAnalytics {
		private Analyzer3rdParty analyticsService;
		public Adapter(Analyzer3rdParty service) {
			this.analyticsService = service;
		}
		private double[][] ConvertData(Dataset dataset) {
			IList<List<double>> originalData = dataset.GetData();
			Console.WriteLine(originalData);

			double[][] transformedData = new double[originalData.Count][];

			for (int i = 0; i < originalData.Count; i++) {
				transformedData[i] = new double[originalData[i].Count];
				originalData[i].CopyTo(transformedData[i]);
			}
			return transformedData;
		}

		public double[] CalculateAveragePerColumn(Dataset dataset) {
			double[][] data = this.ConvertData(dataset);
			return this.analyticsService.PerColumnAverage(data);
		}
		public double[] CalculateAveragePerRow(Dataset dataset) {
			double[][] data = this.ConvertData(dataset);
			return this.analyticsService.PerRowAverage(data);
		}
	}
}
