namespace ATC.Models.Handlers
{
    public class Frequency
    {
        public string Name { get; }
        public string ShortName { get; }
        public string Value { get; }

        public Frequency(string name, string shortName, string value)
        {
            Name = name;
            ShortName = shortName;
            Value = value;
        }
    }
}