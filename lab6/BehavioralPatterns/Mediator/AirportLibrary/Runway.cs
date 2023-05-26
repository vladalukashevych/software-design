namespace Mediator.AirportLibrary
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public bool IsBusyWithAircraft { get; set; } = false;

        public Runway()
        {
        }

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {this.Id} red light!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {this.Id} green light!");
        }
    }
}
