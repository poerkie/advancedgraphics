using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using System.Threading.Tasks;

namespace template
{
    public enum TypeofMaterial { Glass, Difsuse }
   
    public class Material
    {
        public static Material roodmat() { return new Material(TypeofMaterial.Difsuse, Color4.Red, 0.2f); }
        public static Material geelmat() { return new Material(TypeofMaterial.Difsuse, Color4.Yellow, 0.2f); }
        public static Material blauwmat() { return new Material(TypeofMaterial.Difsuse, Color4.Blue, 0.2f); }
        public static Material groenmat() { return new Material(TypeofMaterial.Difsuse, Color4.Green, 0.2f); }
        public static Material orangemat() { return new Material(TypeofMaterial.Difsuse, Color4.Orange,0.2f); }
        public static Material purplemat() { return new Material(TypeofMaterial.Difsuse,Color4.Purple,0.2f); }
        public static Material witmat() { return new Material(TypeofMaterial.Difsuse, Color4.WhiteSmoke,0.5f); }



       public TypeofMaterial matType;
       public Color4 color;
       public float coef;
       public float specPower;
        public Material (TypeofMaterial mattype, Color4 color, float coef)
        {
            this.matType = mattype;
            this.color = color;
            this.coef = coef;
            this.specPower = 8;
        }
    }
}
