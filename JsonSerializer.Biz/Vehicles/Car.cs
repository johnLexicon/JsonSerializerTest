﻿using System;
namespace JsonSerializer.Biz.Vehicles
{
    [Serializable]
    public class Car : Vehicle
    {
        private string fuelType;

        public Car(string regNr, string color, byte wheelsNr, string fuelType) : base(regNr, color, wheelsNr) => FuelType = fuelType;

        public string FuelType { get => fuelType; set => fuelType = value; }

        public override string ToString()
        {
            return $"{base.ToString()} Fuel type: {FuelType}";
        }
    }
}
