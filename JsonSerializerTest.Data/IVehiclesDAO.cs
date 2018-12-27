using System;
using JsonSerializer.Biz.Vehicles;

namespace JsonSerializerTest.Data
{
    public interface IVehiclesDAO
    {
        void SaveVehicle(Vehicle vehicle);
        Vehicle RetrieveVehicle();
        void SaveAllVehicles(Vehicle[] vehicles);
        Vehicle[] RetrieveAllVehicles();
    }
}
