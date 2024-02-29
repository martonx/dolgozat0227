namespace Dolgozat0227;

public class MotorBike : Vehicle, IVehicle
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public BikeType Type { get; set; }
    public VehicleType VehicleType { get; set; } = VehicleType.Motor;

    public override string ToString()
    {
        return $"Busz tulajdonságai: Id: {Id}, Név: {Name}, Sebesség: {Speed}, Utasok: {Seats}, Típus: {Type}, 1 utas 100 km per liter: {ConsumptionPerPassanger} stb...";
    }
}
