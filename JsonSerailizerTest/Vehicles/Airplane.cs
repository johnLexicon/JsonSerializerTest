﻿using System;

namespace JsonSerailizerTest.Vehicles
{
    public class Airplane : Vehicle
    {

        private byte enginesNr;

        public Airplane(string regNr, string color, byte wheelsNr, byte enginesNr) : base(regNr, color, wheelsNr)
        {
            EnginesNr = enginesNr;
        }

        public byte EnginesNr { get => enginesNr; set => enginesNr = value; }
    }
}
