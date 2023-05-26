namespace Mediator.AirportLibrary
{
    public class Aircraft
    {
        public string Name;
        public AircraftState State { get; set; }
        public bool IsTakingOff { get; set; }
        private CommandCenter _commandCenter;

        public Aircraft(string name, CommandCenter commandCenter)
        {
            Name = name;
            _commandCenter = commandCenter;
        }
        public void Land(Runway runway)
        {
            Console.WriteLine($"Aircraft {Name} is landing.");
            Console.WriteLine($"Checking runway.");
            State = AircraftState.Landing;
            IsTakingOff = false;
            _commandCenter.Inform(this, runway);                        
        }
        public void TakeOff(Runway runway)
        {
            Console.WriteLine($"Aircraft {Name} is taking off.");
            Console.WriteLine($"Checking runway.");
            IsTakingOff = true;
            State = AircraftState.TakingOff;
            _commandCenter.Inform(this, runway);
        }
    }
}
