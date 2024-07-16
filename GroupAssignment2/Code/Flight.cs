namespace GroupAssignment2.Code
{
	public class Flight
	{
		public string? flightCode { get; private set; }
		public string? flightName { get; private set; }
		public string? fromAirportCode { get; private set; }
		public string? toAirportCode { get; private set; }
		public string? flightDayOfWeek { get; private set; }
		public string? flightTime { get; private set; }
		public int? seatsAvailable { get; private set; }
		public double? flightCost { get; private set; }

		public Flight() { }

		public Flight(string code, string name, string fromCode, string toCode, string day, string time, int seats, double cost)
		{
			this.flightCode = code;
			this.flightName = name;
			this.fromAirportCode = fromCode;
			this.toAirportCode = toCode;
			this.flightDayOfWeek = day;
			this.flightTime = time;
			this.seatsAvailable = seats;
			this.flightCost = cost;
		}
	}
}
