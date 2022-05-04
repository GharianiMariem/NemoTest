using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Nemo.Market.Kata.Classes
{
    public abstract class Positionable
    {
        private Point _position;

        public Point Position => _position;

        public void SetPosition(Point point)
        {
            _position = point;
        }
    }
}
