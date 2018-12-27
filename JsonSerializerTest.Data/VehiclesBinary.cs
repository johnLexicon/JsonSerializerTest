using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using JsonSerializer.Biz.Vehicles;

namespace JsonSerializerTest.Data
{
    public class VehiclesBinary : IVehiclesDAO
    {
        private readonly string fileName = "MyFile.bin";

        public Vehicle[] RetrieveAllVehicles()
        {
            IFormatter formatter = new BinaryFormatter();
            Vehicle[] vehicles;
            using(Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None)){
                vehicles = (Vehicle[]) formatter.Deserialize(stream);
            }

            return vehicles;
        }

        public Vehicle RetrieveVehicle()
        {
            IFormatter formatter = new BinaryFormatter();
            Vehicle vehicle = null;
            using (Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None))
            {
                vehicle = (Vehicle) formatter.Deserialize(stream);
            }

            return vehicle;
        }

        public void SaveAllVehicles(Vehicle[] vehicles)
        {
            IFormatter formatter = new BinaryFormatter();
            using(Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, vehicles);
            }
        }

        public void SaveVehicle(Vehicle vehicle)
        {
            IFormatter formatter = new BinaryFormatter();
            using(Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                formatter.Serialize(stream, vehicle);
            }
        }

    }
}
