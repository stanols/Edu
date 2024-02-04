namespace Edu.DesignPatterns.Creational.Builder.Interfaces
{
	public interface IAircraftBuilder
	{
		AircraftBuilder BuildFuselage();
		AircraftBuilder BuildWings();
		AircraftBuilder BuildStabilazers();
		AircraftBuilder BuildCockpit();
	}
}
