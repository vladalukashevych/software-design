using Mediator.AirportLibrary;

CommandCenter commandCenter = new CommandCenter();

List<Runway> runways = new List<Runway>() { new Runway(), new Runway() };
List<Aircraft> aircrafts = new List<Aircraft> {
    new Aircraft("La La Land", commandCenter), 
    new Aircraft("Blue Lagoon", commandCenter),
    new Aircraft("Barbie International", commandCenter) };


commandCenter.SetAll(runways, aircrafts);

aircrafts[0].TakeOff(runways[0]);
Console.WriteLine();
aircrafts[0].Land(runways[0]);
Console.WriteLine();
aircrafts[1].Land(runways[0]);
Console.WriteLine();
aircrafts[2].Land(runways[1]);

