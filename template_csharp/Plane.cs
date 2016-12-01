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
    }
}
