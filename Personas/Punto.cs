using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
    public class Punto
    {
        private int _x, _y;
        public int X 
        {
            get { return _x; }
            set 
            {
                if (value < 0)
                    throw new Exception();
                _x = value;
            }
        }
        public int Y
        {
            get { return _x; }
            set
            {
                if (value < 0)
                    throw new Exception();
                _y = value;
            }
        }
        public Punto() { }
        public Punto(int x, int y) 
        {
            X = x;
            Y = y;
        }
        public Punto(Punto p) : this(p.X, p.Y) { }
        public override string ToString()
        {
            return $"({_x},{_y})";
        }
        public override bool Equals(object? obj)
        {
            bool igual;

            if (obj == null || !(obj.GetType().Equals(this.GetType())))
                igual = false;
            else
            {
                Punto el_otro = (Punto)obj;
                igual = X == el_otro.X && Y == el_otro.Y;
            }
            return igual;
        }
    }
}
