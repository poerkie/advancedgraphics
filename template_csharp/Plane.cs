using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using System.Drawing;
using System.Threading.Tasks;

namespace template
{
    
    class Plane : Primitive
    {
        public Vector3 Normal;
        public float Distance;
        public Plane(Vector3 Normal, float distance, Material mat)
        {
            this.Normal = Normal;
            this.Distance = distance;
            this.Material = mat;

        }
        public override void Intersect(Ray ray)
        {
            
            float notparalel = Vector3.Dot(this.Normal, ray.Direction);
            if (notparalel != 0)
            {
                float bottom = (Vector3.Dot(ray.Direction, this.Normal));
                float top = (-(Vector3.Dot(ray.Origin, this.Normal) + this.Distance));
                float distance = top / bottom;
                if (distance < ray.TraveledDistance && distance > 0)
                {
                    ray.TraveledDistance = distance;
                    ray.NearestPrimitive = this;
                    ray.intersectionNormal = this.Normal;
                    ray.intersectionPosition = distance * ray.Direction + ray.Origin;
                }
            }
        }
    }
}
