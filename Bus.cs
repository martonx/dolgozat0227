namespace Dolgozat0227;

public class Bus : Vehicle, IVehicle
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public BusType Type { get; set; }
    public VehicleType VehicleType { get; set; } = VehicleType.Bus;

    public override string ToString()
    {
        return $"Busz tulajdonságai: Id: {Id}, Név: {Name}, Sebesség: {Speed}, Utasok: {Seats}, Típus: {Type}, 1 utas 100 km per liter: {ConsumptionPerPassanger} stb...";
    }
}
