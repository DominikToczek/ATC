namespace ATC.Models.Handlers
{
    public class Destination
    {
        public string Icao { get; set; }
        public string City { get; set; }

        public Destination(string icao, string city)
        {
            Icao = icao;
            City = city;
        }
    }
}