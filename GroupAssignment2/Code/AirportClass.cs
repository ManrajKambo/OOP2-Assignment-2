using System.Collections.Generic;
using System.IO;

namespace GroupAssignment2.Code
{
    public class AirportClass : CSV
    {
        private static List<Airport> _airportData = new List<Airport>();

        public AirportClass()
        {
            LoadData();
        }

        private void LoadData()
        {
            foreach (string line in base.LoadCSV("airports"))
            {
                string[] split = line.Split(',');
                string airportCode = split[0];
                string airportFull = split[1];
                _airportData.Add(new Airport(airportCode, airportFull));
            }
        }

        public static List<Airport> GetData()
        {
            return _airportData;
        }
    }
}
