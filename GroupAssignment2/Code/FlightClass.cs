using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupAssignment2.Code
{
    public class FlightClass : CSV
    {
        private static List<Flight>? _flightData;

        private string _from;
        private string _to;
        private string _day;

        public FlightClass(string from, string to, string day)
        {
            _from = from;
            _to = to;
            _day = day;

            LoadData();
        }

        private void LoadData()
        {
            _flightData = new List<Flight>();

            foreach (string line in base.LoadCSV("flights"))
            {
                string[] split = line.Split(',');

                string flightCode = split[0];
                string flightName = split[1];
                string fromAirportCode = split[2];
                string toAirportCode = split[3];
                string flightDayOfWeek = split[4];
                string flightTime = split[5];
                int seatsAvailable = Convert.ToInt32(split[6]);
                double flightCost = Convert.ToDouble(split[7]);

                if ((!string.IsNullOrEmpty(_from) && _from != fromAirportCode) ||
                    (!string.IsNullOrEmpty(_to) && _to != toAirportCode) ||
                    (!string.IsNullOrEmpty(_day) && _day != flightDayOfWeek))
                {
                    continue;
                }

                _flightData.Add(new Flight(
                    flightCode,
                    flightName,
                    fromAirportCode,
                    toAirportCode,
                    flightDayOfWeek,
                    flightTime,
                    seatsAvailable,
                    flightCost
                ));
            }
        }

        public static List<Flight> GetData()
        {
            return _flightData ?? new List<Flight>();
        }
    }
}