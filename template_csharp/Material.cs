using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace template
{
    public enum TypeofMaterial { Glass, Difsuse }
   
    public class Material
    {
        public static Material roodmat() { return new Material(TypeofMaterial.Difsuse, Color.Red); }
         public static  Material geelmat() {return new Material(TypeofMaterial.Difsuse, Color.Yellow);}
         public static  Material blauwmat() {return new Material(TypeofMaterial.Difsuse, Color.Blue);}
         public static Material groenmat() { return new Material(TypeofMaterial.Difsuse, Color.Green); }
         public static Material orangemat() { return new Material(TypeofMaterial.Difsuse, Color.Orange); }
         public static Material purplemat() { return new Material(TypeofMaterial.Difsuse, Color.Purple); }


       public TypeofMaterial matType;
       public Color color;

        public Material (TypeofMaterial mattype, Color color)
        {
            this.matType = mattype;
            this.color = color;
        }
    }
}
