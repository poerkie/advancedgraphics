using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using System.Threading.Tasks;

namespace template
{
    
    class Plane : Primitive
    {
        public Vector3d Normal;
        public Plane(Vector3d Normal, Vector3d Position, Vector3d Color)
        {
            this.Normal = Normal;
            this.Position = Position;
            this.Color = Color;

        }
    }
}
