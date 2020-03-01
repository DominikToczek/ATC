using System.Collections.Generic;

namespace ATC.Models.Handlers
{
    public class Airline
    {
        public string Name { get; }
        public string Icao { get; }
        public string Iata { get; }
        public string Callsign { get; }
        public List<Destination> Destinations { get; } = new List<Destination>();

        public Airline(string name, string icao, string iata, string callsign, List<Destination> destinations)
        {
            Name = name;
            Icao = icao;
            Iata = iata;
            Callsign = callsign;
            Destinations = destinations;
        }
    }
}