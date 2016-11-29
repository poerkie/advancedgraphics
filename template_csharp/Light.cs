using System;
using System.Collections.Generic;
using System.Linq;
using OpenTK;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    class Light
    {
        public Vector3d Position;
        public double intensity;
        public Light (Vector3d Position,double intensity)
        {
            this.Position = Position;
            this.intensity = intensity;
        }
    }
}
