namespace Dolgozat0227;

public interface IVehicle
{
    int Wheels { get; set; }
    int Doors { get; set; }
    VehicleType VehicleType { get; set; }

    string ToString(); // Kiírja egy konzol sorba a jármű típusát (pl. busz / motor / autó) és az összes adatát 
}
