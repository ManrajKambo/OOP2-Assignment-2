using System.Xml.Linq;

namespace GroupAssignment2.Code
{
	public class FlightClass : Assignment
	{
		private static List<Flight>? __flightData;

		private string __From;
		private string __To;
		private string __Day;


		public FlightClass(string from, string to, string day)
		{
			this.__From = from;
			this.__To = to;
			this.__Day = day;

			this.LoadData();
		}

		private void LoadData()
		{
			__flightData = new List<Flight>();

			foreach (string __line in base.LoadCSV("flights"))
			{
				string[] __split = __line.Split(',');

				string __flightCode = __split[0];
				string __flightName = __split[1];
				string __fromAirportCode = __split[2];
				string __toAirportCode = __split[3];
				string __flightDayOfWeek = __split[4];
				string __flightTime = __split[5];
				int __seatsAvailable = Convert.ToInt32(__split[6]);
				double __flightCost = Convert.ToDouble(__split[7]);

				if ((!string.IsNullOrEmpty(this.__From)) && (this.__From != __fromAirportCode))
				{
					continue;
				}

				if ((!string.IsNullOrEmpty(this.__To)) && (this.__To != __toAirportCode))
				{
					continue;
				}

				if ((!string.IsNullOrEmpty(this.__Day)) && (this.__Day != __flightDayOfWeek))
				{
					continue;
				}

				__flightData.Add(new Flight(
					__flightCode,
					__flightName,
					__fromAirportCode,
					__toAirportCode,
					__flightDayOfWeek,
					__flightTime,
					__seatsAvailable,
					__flightCost
				));
			}
		}

		public static List<Flight> GetData()
		{
			return __flightData;
		}
	}
}