using System;
using System.Collections.Generic;
using System.Linq;
using OpenTK;
using OpenTK.Graphics;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    class Light
    {
        public Vector3 Position;
        public float intensity;
        public Light (Vector3 Position,float intensity)
        {
            this.Position = Position;
            this.intensity = intensity;
        }
    }
}
