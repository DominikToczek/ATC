using ATC.Models.Handlers;

namespace ATC.Models.Traffic
{
    public class Traffic : ITraffic
    {
        public string Callsign { get; }
        public Airline Company { get; }
        public Aircraft Aircraft { get; }
        public Destination Destination { get; }
        public int Squwak { get; private set; }
        public string Sid { get; private set; }
        public char WeatherInfo { get; private set; }
        public int AssignedAltitude { get; private set; }

        public Traffic(string callsign, Airline company, Destination destination)
        {
            Callsign = callsign;
            Company = company;
            Destination = destination;
        }

        public void SetSquwak(int assignedSquwak)
        {
            Squwak = assignedSquwak;
        }

        public void SetSid(string assignedSid)
        {
            Sid = assignedSid;
        }

        public void SetWeatherInfo(char assignedWeatherInfo)
        {
            WeatherInfo = assignedWeatherInfo;
        }

        public void SetAssignedAltitude(int assignedAltitude)
        {
            AssignedAltitude = assignedAltitude;
        }
    }
}