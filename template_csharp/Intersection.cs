using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using OpenTK.Graphics;
using System.Drawing;
using System.Threading.Tasks;

namespace template
{
    class Intersection
    {
        public Vector3 intersectNormal;
       
        public double intersectiondistance;
        public Primitive nearestShape;

        public Intersection(Vector3 Direction, Vector3 Origin, List<Sphere> circles)
        {
            
            intersectiondistance = float.MaxValue;
        foreach (Sphere x in circles){
            float a = Vector3.Dot(Direction,Direction);
            float b = Vector3.Dot(2 *Direction, (Origin - x.Position));
            float c = Vector3.Dot((Origin - x.Position), (Origin - x.Position)) - (float) Math.Pow(x.Radius, 2);
            double answer1;
            double answer2;
            double det = Abcformula(a, b, c, out answer1, out answer2);
            if( det==0)
            {
                if( answer1 < intersectiondistance)
                {
                    intersectiondistance = answer1;
                    nearestShape = x;
                    
                }
            }
            else if( det >0 )
            {
                if( answer1 < intersectiondistance && answer1 >=0)
                {
                    intersectiondistance = answer1;
                    nearestShape = x;
                  
                }
                else if(answer2 < intersectiondistance && answer2 >=0 )
                {
                    intersectiondistance = answer2;
                    nearestShape = x;
          
                }
            }
        }


        }
         //Direction.


        private double Abcformula(double a, double b, double c, out double answer1, out double answer2)
            {
                
               double determinant = Math.Sqrt(b*b - 4*a*c);
                answer1 = (-b + determinant) / (2 *a);
                answer2 = (-b - determinant) / (2 * a);
                return determinant;
             }
        }
        /*Intersection, which stores the result of an intersection. Apart from the intersection distance,
you will at least want to store the nearest primitive, but perhaps also the normal at the
intersection pointSphere: 𝑝 − 𝐶 ∙ 𝑝 − 𝐶 − 𝑟
2 = 0
Substituting for 𝑝(𝑡), we get
𝑂 + 𝑡𝐷 − 𝐶 ∙ 𝑂 + 𝑡𝐷 − 𝐶 − 𝑟
2 = 0
𝐷 ∙ 𝐷 𝑡
2 + 2𝐷 ∙ 𝑂 − 𝐶 𝑡 + (𝑂 − 𝐶)
2−𝑟
2 = 0
𝑎𝑡
2 + 𝑏𝑡 + 𝑐 = 0 → 𝑡 =
−𝑏 ± 𝑏
2 − 4𝑎𝑐
2𝑎
𝑎 = 𝐷 ∙ 𝐷
𝑏 = 2𝐷 ∙ (𝑂 − 𝐶)
𝑐 = 𝑂 − 𝐶 ∙ 𝑂 − 𝐶 − 𝑟
2.*/ 
    
}
