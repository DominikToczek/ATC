namespace ATC.Models.Handlers
{
    public class Runway
    {
        public string Name { get; set; }
        public int Heading { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }

        public Runway(string name, int heading, int length, int width)
        {
            Name = name;
            Heading = heading;
            Length = length;
            Width = width;
        }
    }
}