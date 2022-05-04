using Nemo.Market.Kata.Enums;
using System;

namespace Nemo.Market.Kata.Classes
{
    internal class PipeDiameterCalculator
    {
        public PipeDiameterCalculator()
        {
        }

        internal PipeDiameter ProcessDiameter( int v )
        {
            if (v <= 0 || v >= 21)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (v < 6)
            {
                return PipeDiameter.Small;
            }
           else if(v < 11)
            {
                return PipeDiameter.Medium;
            }
            else if(v < 16)
            {
                return PipeDiameter.Large;
            } 
            else
            {
                return PipeDiameter.ExtraLarge;
            }
        }
    }
}