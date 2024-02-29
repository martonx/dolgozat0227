namespace Dolgozat0227;

public class Car : Vehicle, IVehicle
{
    public int Wheels { get; set; }
    public int Doors { get; set; }
    public int RackCapacity { get; set; }
    public new VehicleType VehicleType { get; set; }

    public override string ToString()
    {
        return $"Autó tulajdonságai: Id: {Id}, Név: {Name}, Sebesség: {Speed}, Utasok: {Seats}, 1 utas 100 km per liter: {ConsumptionPerPassanger} stb...";
    }
}
