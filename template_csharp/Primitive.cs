using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using OpenTK;
using System.Threading.Tasks;

namespace template
{
    
    abstract class Primitive
    {
        public Material Material;
        public abstract void Intersect(Ray ray);
    }
}
