namespace ATC.Models.Handlers
{
    public class Frequency
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Value { get; set; }

        public Frequency(string name, string shortName, string value)
        {
            Name = name;
            ShortName = shortName;
            Value = value;
        }
    }
}