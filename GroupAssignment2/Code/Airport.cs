namespace GroupAssignment2.Code
{
	public class Airport
	{
		public string? airportCode { get; private set; }
		public string? airportFull { get; private set; }

		public Airport() { }

		public Airport(string code, string full)
		{
			this.airportCode = code;
			this.airportFull = full;
		}
	}
}
