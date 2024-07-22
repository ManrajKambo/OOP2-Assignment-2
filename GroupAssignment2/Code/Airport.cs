namespace GroupAssignment2.Code
{
    public class Airport
    {
        public string? AirportCode { get; private set; }
        public string? AirportFull { get; private set; }

        public Airport() { }

        public Airport(string code, string full)
        {
            AirportCode = code;
            AirportFull = full;
        }
    }
}
