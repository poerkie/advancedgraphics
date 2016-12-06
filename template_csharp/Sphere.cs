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

        public override void Intersect(Ray ray)
        {
            Vector3 c = this.Position - ray.Origin;
            float t = Vector3.Dot(c, ray.Direction);
            Vector3 q = c - t * ray.Direction;
            float p2 = Vector3.Dot(q, q);
            if (p2 > this.Radius * this.Radius) { return; }// r2 = r * r
            t -= (float)Math.Sqrt(this.Radius * this.Radius - p2);
            if ((t < ray.TraveledDistance) && (t > 0)) { 
                ray.TraveledDistance = t; 
                ray.NearestPrimitive = this;

                ray.intersectionPosition = (t * ray.Direction + ray.Origin);
                ray.intersectionNormal = (this.Position - ray.intersectionPosition).Normalized();
            }
        }
    }
}
