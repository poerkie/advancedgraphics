using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using System.Drawing;
using System.Threading.Tasks;

namespace template
{
    class Ray
    {
        public Vector3 intersectionNormal;
        public Vector3 Direction;
        public Vector3 Origin;
        public double TraveledDistance;
        public Primitive NearestPrimitive;

        public Ray(Vector3 Direction, Vector3 Origin, List<Primitive> shapes)
        {
            TraveledDistance = float.MaxValue;
            this.Direction = Direction;
            this.Origin = Origin;
            foreach (Primitive y in shapes)
            {
                y.Intersect(this);
            }
        }
    }
}