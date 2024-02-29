// See https://aka.ms/new-console-template for more information
using Dolgozat0227;

Console.WriteLine("Hello, World!");

var vehicles = new List<IVehicle>
{
    new Car
    {
        Doors = 4,
        FuelConsumption = 6,
        Id = 1,
        Name = "Suzuki Vitara",
        RackCapacity = 400,
        Seats = 5,
        Speed = 150,
        TankCapacity = 50,
        Wheels = 4,
        VehicleType = VehicleType.Car
    },
    new Car
    {
        Doors = 5,
        FuelConsumption = 7,
        Id = 2,
        Name = "Suzuki Swift",
        RackCapacity = 300,
        Seats = 5,
        Speed = 150,
        TankCapacity = 50,
        Wheels = 4,
        VehicleType = VehicleType.Car
    },
    new Bus
    {
        Doors = 2,
        FuelConsumption = 30,
        Id = 3,
        Name = "Bus One",
        Type = BusType.LowFloor,
        Seats = 40,
        Speed = 110,
        TankCapacity = 200,
        Wheels = 4,
        VehicleType = VehicleType.Bus
    },
    new Bus
    {
        Doors = 0,
        FuelConsumption = 25,
        Id = 4,
        Name = "Bus Two",
        Type = BusType.Normal,
        Seats = 30,
        Speed = 110,
        TankCapacity = 100,
        Wheels = 4,
        VehicleType = VehicleType.Bus
    },
    new MotorBike
    {
        Doors = 0,
        FuelConsumption = 6,
        Id = 5,
        Name = "Naked bike",
        Type = BikeType.Naked,
        Seats = 2,
        Speed = 200,
        TankCapacity = 15,
        Wheels = 2,
        VehicleType = VehicleType.Motor
    },
    new MotorBike
    {
        Doors = 0,
        FuelConsumption = 10,
        Id = 6,
        Name = "Cross bike",
        Type = BikeType.Cross,
        Seats = 1,
        Speed = 100,
        TankCapacity = 10,
        Wheels = 2,
        VehicleType = VehicleType.Motor
    },
};


foreach (var vehicle in vehicles)
    Console.WriteLine(vehicle.ToString());

var vehicleTypes = vehicles.GroupBy(vehicle => vehicle.VehicleType)
    .Select(group => new { Type = group.Key, MinConsumption = group.Min(vehicle => ((Vehicle)vehicle).ConsumptionPerPassanger)})
    .ToList();

var lowest = vehicleTypes.OrderBy(vt => vt.MinConsumption).First();

Console.WriteLine(lowest.ToString());