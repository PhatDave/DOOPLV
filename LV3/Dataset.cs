using System.Collections.Generic;
namespace LV3 {
	class Dataset : IPrototype {
		private List<List<string>> data; //list of lists of strings
		public Dataset() {
			this.data = new List<List<string>>();
		}
		public Dataset(string filePath) : this() {
			this.LoadDataFromCSV(filePath);
		}
		public void LoadDataFromCSV(string filePath) {
			using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath)) {
				string line;
				while ((line = reader.ReadLine()) != null) {
					List<string> row = new List<string>();
					string[] items = line.Split(',');
					foreach (string item in items) {
						row.Add(item);
					}
					this.data.Add(row);
				}
			}
		}
		public IList<List<string>> GetData() {
			return
		   new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
		}
		public void ClearData() {
			this.data.Clear();
		}
		public IPrototype Clone() {
			Dataset copy = new Dataset();
			//foreach (var row in this.data) {
			//	List<string> rowCopy = new List<string>();
			//	foreach (var element in row) {
			//		rowCopy.Add(element);
			//	}
			//	copy.data.Add(rowCopy);
			//}

			foreach (var row in this.data)
				copy.data.Add(new List<string>(row));

			//copy.data = this.data;
			return (IPrototype)copy;
		}
		public void ChangeFirstElement() {
			data[0][0] = "kekw";
		}
	}

}