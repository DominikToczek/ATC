namespace ATC.Models.Handlers
{
    public class Frequency
    {
        public string Name { get; set; }
        public string ShortName { get; set; }
        public decimal Value { get; set; }

        public Frequency(string name, string shortName, decimal value)
        {
            Name = name;
            ShortName = shortName;
            Value = value;
        }
    }
}