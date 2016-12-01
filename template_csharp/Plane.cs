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
        public Plane(Vector3 Normal, Vector3 Position, Color color)
        {
            this.Normal = Normal;
            this.Position = Position;
            this.Color = color;

        }
    }
}
