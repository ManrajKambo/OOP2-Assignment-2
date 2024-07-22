namespace GroupAssignment2.Code
{
    public class Flight
    {
        public string? FlightCode { get; private set; }
        public string? FlightName { get; private set; }
        public string? FromAirportCode { get; private set; }
        public string? ToAirportCode { get; private set; }
        public string? FlightDayOfWeek { get; private set; }
        public string? FlightTime { get; private set; }
        public int? SeatsAvailable { get; private set; }
        public double? FlightCost { get; private set; }

        public Flight() { }

        public Flight(string code, string name, string fromCode, string toCode, string day, string time, int seats, double cost)
        {
            FlightCode = code;
            FlightName = name;
            FromAirportCode = fromCode;
            ToAirportCode = toCode;
            FlightDayOfWeek = day;
            FlightTime = time;
            SeatsAvailable = seats;
            FlightCost = cost;
        }
    }
}