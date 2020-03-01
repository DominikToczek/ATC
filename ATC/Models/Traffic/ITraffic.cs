namespace ATC.Models.Traffic
{
    public interface ITraffic
    {
        void SetSquwak(int assignedSquwak);

        void SetSid(string assignedSid);

        void SetWeatherInfo(char assignedWeatherInfo);

        void SetAssignedAltitude(int assignedAltitude);
    }
}