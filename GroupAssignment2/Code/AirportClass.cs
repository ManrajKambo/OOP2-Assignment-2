namespace GroupAssignment2.Code
{
	public class AirportClass : Assignment
	{
		private static List<Airport> __airportData = new List<Airport>();

		public AirportClass() {
			this.LoadData();
		}

		private void LoadData()
		{
			foreach (string __line in base.LoadCSV("airports"))
			{
				string[] __split = __line.Split(',');
				string __airportCode = __split[0];
				string __airportFull = __split[1];
				__airportData.Add(new Airport(
					__airportCode,
					__airportFull
				));
			}
		}

		public static List<Airport> GetData()
		{
			return __airportData;
		}
	}
}