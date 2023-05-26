using System.ComponentModel.Design;

namespace Mediator.AirportLibrary
{
    public class CommandCenter
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();
        private Dictionary<string, string> _schedules = new Dictionary<string, string>();

        public void SetAll(List<Runway> runways, List<Aircraft> aircrafts)
        {
            _runways.AddRange(runways);
            _aircrafts.AddRange(aircrafts);
        }

        public void Inform(Aircraft aircraft, Runway runway)
        {
            if (aircraft.State == AircraftState.Landing)
            {
                if (runway.IsBusyWithAircraft == false)
                {
                    runway.HighLightGreen();
                    runway.IsBusyWithAircraft = true;
                    _schedules.Add(aircraft.Name, runway.Id.ToString());
                    Console.WriteLine($"Aircraft {aircraft.Name} has successfully landed.");
                }
                else
                {
                    runway.HighLightRed();
                    Console.WriteLine("Landing not possible, runway is in use.");
                }
               
            }
            else if (aircraft.State == AircraftState.TakingOff)
            {
                if (aircraft.IsTakingOff == true)
                {
                    runway.HighLightGreen();
                    Console.WriteLine($"Aircraft has successfully taken off.");
                   _schedules.Remove(aircraft.Name);
                }
                else
                {
                    runway.HighLightRed();
                    Console.WriteLine($"Aircraft can't take off.");
                }
            }
        }
    }
}
