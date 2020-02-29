using System.Collections.Generic;

namespace ATC.Models.Handlers
{
    public static class AirportConfig
    {
        public static string AirportIcao { get; set; } = string.Empty;
        public static string AirportName { get; set; } = string.Empty;
        public static List<Runway> Runways { get; set; } = new List<Runway>();
        public static List<Frequency> Frequencies { get; set; } = new List<Frequency>();
        public static List<Airline> Airlines { get; set; } = new List<Airline>();
    }
}