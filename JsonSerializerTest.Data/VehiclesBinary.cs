using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using JsonSerializer.Biz.Vehicles;

namespace JsonSerializerTest.Data
{
    public class VehiclesBinary : IVehiclesDAO
    {
        public Vehicle RetrieveVehicle()
        {
            IFormatter formatter = new BinaryFormatter();
            Vehicle vehicle = null;
            using (Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.None))
            {
                vehicle = (Vehicle) formatter.Deserialize(stream);
            }

            return vehicle;
        }

        public void SaveVehicle(Vehicle vehicle)
        {
            IFormatter formatter = new BinaryFormatter();
            using(Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, vehicle);
            }
        }
    }
}
