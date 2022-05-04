using Nemo.Market.Kata.Enums;
using System;
using System.Drawing;

namespace Nemo.Market.Kata.Classes
{
    public class Building : Positionable
    {
        public Building()
        {
        }

       
        public int Consumption { get; set; }


        internal void SetConsumption(int consumption)
        {
            if(consumption < 1 || consumption > 20)
            {
                throw new ArgumentOutOfRangeException(nameof(consumption));
            }
           
            this.Consumption = consumption;
        }
    }
}