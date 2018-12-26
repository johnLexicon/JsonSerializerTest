using System;
using System.Linq;
using JsonSerailizerTest.Vehicles;
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
            Vehicle motorcycle = new Motorcycle("MMM", "Orange", 2, 450);

            Vehicle[] vehicles = { car, airplane, boat, bus, motorcycle };

            JArray array = new JArray(vehicles.Select(v =>
            {
                JObject obj = JObject.FromObject(v);
                obj.AddFirst(new JProperty("Type", v.GetType().Name));
                return obj;
            }));

            //Console.WriteLine(array);
            string json = array.ToString();

            JArray a = JArray.Parse(json);

            Vehicle c = null;
            foreach (var item in a)
            {
                Console.WriteLine(item.First.First);
                if (item.First.First.ToString().Equals("Car"))
                {
                    c = JsonConvert.DeserializeObject<Car>(item.ToString());
                    Console.WriteLine(c);
                }
            }
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
