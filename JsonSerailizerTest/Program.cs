﻿using System;
using System.Linq;
using JsonSerializer.Biz.Vehicles;
using JsonSerializerTest.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonSerailizerTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car("ABC123", "Green", 4, "Diesel");
            Vehicle airplane = new Airplane("FFF123", "Blue", 2, 4);
            Vehicle boat = new Boat("BBB345", "Black", 0, 450);
            Vehicle bus = new Bus("BUS098", "red", 8, 89);
            Vehicle motorcycle = new Motorcycle("MMM012", "Orange", 2, 450);

            Vehicle[] vehicles = { car, airplane, boat, bus, motorcycle };

            IVehiclesDAO vehiclesDAO = new VehiclesBinary();
            vehiclesDAO.SaveAllVehicles(vehicles);

            Vehicle[] binVehicles = vehiclesDAO.RetrieveAllVehicles();
            foreach (var item in binVehicles)
            {
                Console.WriteLine(item);
            }

            //JArray array = new JArray(vehicles.Select(v =>
            //{
            //    JObject obj = JObject.FromObject(v);
            //    obj.AddFirst(new JProperty("Type", v.GetType().Name));
            //    return obj;
            //}));

            //string json = array.ToString();

            //JArray a = JArray.Parse(json);

            //Vehicle c = null;
            //foreach (var item in a)
            //{
            //    Console.WriteLine(item.First.First);
            //    if (item.First.First.ToString().Equals("Car"))
            //    {
            //        c = JsonConvert.DeserializeObject<Car>(item.ToString());
            //        Console.WriteLine(c);
            //    }
            //}

            //IVehiclesDAO vehiclesDAO = new VehiclesBinary();
            //vehiclesDAO.SaveVehicle(car);

            //Vehicle binCar = vehiclesDAO.RetrieveVehicle();
            //Console.WriteLine(binCar);

            //var obj = JObject.FromObject(car);
            //obj.AddFirst(new JProperty("Type", nameof(car)));

            //Console.WriteLine(obj);


            //string json = JsonConvert.SerializeObject(car);
            //Console.WriteLine(json);

            //Vehicle car2 = JsonConvert.DeserializeObject<Car>(json);
            //Console.WriteLine(car2);
        }
    }
}
