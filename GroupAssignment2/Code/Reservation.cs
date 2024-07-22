using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupAssignment2.Code
{
    public class Reservation
    {
        public string ReservationCode { get; set; } = string.Empty;
        public string FlightCode { get; set; } = string.Empty;
        public string FlightName { get; set; } = string.Empty;
        public string FlightDayOfWeek { get; set; } = string.Empty;
        public string FlightTime { get; set; } = string.Empty;
        public decimal FlightCost { get; set; } = 0.0m;
        public string Name { get; set; } = string.Empty;
        public string Citizenship { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;


        private static Random _random = new Random();
        private static List<Reservation> _reservations = new List<Reservation>();


        public Reservation(Flight flight, string name, string citizenship)
        {
            ReservationCode = GenerateReservationCode();
            FlightCode = flight.FlightCode;
            FlightName = flight.FlightName;
            FlightDayOfWeek = flight.FlightDayOfWeek;
            FlightTime = flight.FlightTime;
            FlightCost = (decimal)flight.FlightCost;
            Name = name;
            Citizenship = citizenship;
            IsActive = true;
        }

        private static string GenerateReservationCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 5)
                .Select(s => s[_random.Next(s.Length)]).ToArray());
        }

        public static List<Reservation> GetAllReservations(string code, string airline, string name)
        {
            var filteredReservations = new List<Reservation>();

            foreach (var reservation in _reservations)
            {
                if ((!string.IsNullOrEmpty(code) && code != reservation.ReservationCode) ||
                    (!string.IsNullOrEmpty(airline) && airline != reservation.FlightName) ||
                    (!string.IsNullOrEmpty(name) && name != reservation.Name))
                {
                    continue;
                }

                filteredReservations.Add(reservation);
            }

            return filteredReservations;
        }

        public static List<string> GetAllUniqueReservationCodes()
        {
            return _reservations.Select(r => r.ReservationCode).Distinct().ToList();
        }

        public static List<string> GetAllUniqueFlightNames()
        {
            return _reservations.Select(r => r.FlightName).Distinct().ToList();
        }

        public static List<string> GetAllUniqueNames()
        {
            return _reservations.Select(r => r.Name).Distinct().ToList();
        }

        public static void AddReservation(Reservation reservation)
        {
            _reservations.Add(reservation);
        }

        public static void UpdateReservation(Reservation updatedReservation)
        {
            var index = _reservations.FindIndex(r => r.ReservationCode == updatedReservation.ReservationCode);
            if (index != -1)
            {
                _reservations[index] = updatedReservation;
            }
        }

        public static void DeleteReservation(Reservation reservation)
        {
            _reservations.Remove(reservation);
        }

        public static bool IsDuplicate(Reservation newReservation)
        {
            return _reservations.Any(r =>
                r.FlightCode == newReservation.FlightCode &&
                r.Name == newReservation.Name &&
                r.Citizenship == newReservation.Citizenship);
        }
    }
}