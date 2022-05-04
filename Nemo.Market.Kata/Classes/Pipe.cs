using Nemo.Market.Kata.Enums;
using System;
using System.Drawing;

namespace Nemo.Market.Kata.Classes
{
    public class Pipe : Positionable
    {
        public Pipe()
        {
        }
        public int Diameter { get; private set; }

        internal void SetDiameter(PipeDiameter pipeDiameter)
        {
            Diameter = (int)PipeDiameter.Large;
        }
    }
}