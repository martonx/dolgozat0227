namespace Dolgozat0227;

public abstract class Vehicle
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Speed { get; set; }
    public int Seats { get; set; }
    public decimal FuelConsumption { get; set; }
    public int TankCapacity { get; set; }
    
    public decimal ConsumptionPerPassanger
    {
        get
        {
            return Math.Round(FuelConsumption / Seats, 2);
        }
    }

    public decimal ElapsedHour(int kilometer)
    {
        return kilometer / Speed;
    }
}