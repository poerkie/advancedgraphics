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
        public Vector3 Position;
        public Sphere (Vector3 Position, Material mat, double Radius)
        {
            this.Position = Position;
            this.Material = mat;
            this.Radius = Radius;
        }

    }
}
