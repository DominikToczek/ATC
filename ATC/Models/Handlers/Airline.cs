using System.Collections.Generic;

namespace ATC.Models.Handlers
{
    public class Airline
    {
        public string Name { get; set; }
        public string Icao { get; set; }
        public string Iata { get; set; }
        public string Callsign { get; set; }
        public List<Destination> Destinations { get; set; } = new List<Destination>();

        public Airline (string name, string icao, string iata, string callsign, List<Destination> destinations)
        {
            Name = name;
            Icao = icao;
            Iata = iata;
            Callsign = callsign;
            Destinations = destinations;
        }
    }
}