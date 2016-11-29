using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
namespace template
{
    class Sphere : Primitive
    {
        public double Radius;
        public Sphere (Vector3d Position, Vector3d Color, double Radius)
        {
            this.Position = Position;
            this.Color = Color;
            this.Radius = Radius;
        }
    }
}
