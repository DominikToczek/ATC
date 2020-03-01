using ATC.Models.Handlers;
using Fare;
using System;
using System.Collections.Generic;

namespace ATC.Models.Traffic
{
    public class TrafficGenerator : ITrafficGenerator
    {
        public void Run()
        {
            GenerateRandomTraffic();
        }

        Traffic GenerateRandomTraffic()
        {
            var airline = GetRandomAirline();
            var destination = GetRandomDestination(airline);
            var callsign = GenerateCallsign(airline);
            return new Traffic(callsign, airline, destination);
        }

        Airline GetRandomAirline()
        {
            var random = new Random();
            var airlinesList = new List<Airline>();
            foreach (var airline in AirportConfig.Airlines)
            {
                for (int i = 0; i < airline.Destinations.Count; i++)
                {
                    airlinesList.Add(airline);
                }
            }

            var index = random.Next(airlinesList.Count);
            return airlinesList[index];
        }

        Destination GetRandomDestination(Airline airline)
        {
            var random = new Random();
            var destinationsList = new List<Destination>();
            foreach (var destination in airline.Destinations)
            {
                for (int i = 0; i < destination.WeeklyFlights; i++)
                {
                    destinationsList.Add(destination);
                }
            }

            var index = random.Next(destinationsList.Count);
            return destinationsList[index];
        }

        public string GenerateCallsign(Airline airline)
        {
            string[] patternsArray = { "[0-9]{3}", "[0-9]{4}", "[0-9]{2}[A-Z]{1}", "[0-9]{2}[A-Z]{2}" };
            var random = new Random();
            var pattern = patternsArray[random.Next(patternsArray.Length)];

            var callsign = new Xeger($"{airline.Icao}{pattern}").Generate();

            return callsign;
        }
    }
}