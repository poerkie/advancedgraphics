using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
namespace template
{
    class Sphere : Primitive
    {
        public double Radius;
        public Sphere (Vector3 Position, Color color, double Radius)
        {
            this.Position = Position;
            this.Color = color;
            this.Radius = Radius;
        }
    }
}
