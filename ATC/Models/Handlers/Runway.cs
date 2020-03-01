namespace ATC.Models.Handlers
{
    public class Runway
    {
        public string Name { get; }
        public int Heading { get; }
        public int Length { get; }
        public int Width { get; }

        public Runway(string name, int heading, int length, int width)
        {
            Name = name;
            Heading = heading;
            Length = length;
            Width = width;
        }
    }
}