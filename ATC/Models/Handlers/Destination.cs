namespace ATC.Models.Handlers
{
    public class Destination
    {
        public string Icao { get; }
        public string City { get; }
        public int WeeklyFlights { get; }

        public Destination(string icao, string city, int weeklyFlights)
        {
            Icao = icao;
            City = city;
            WeeklyFlights = weeklyFlights;
        }
    }
}