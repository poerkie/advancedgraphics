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

        public Intersection(Vector3 Direction, Vector3 Origin, List<Primitive> shapes)
        {


            intersectiondistance = float.MaxValue;
            foreach (Primitive y in shapes)
            {
                if (y is Sphere) // Intersection with planes.
                {
                    Sphere x = (Sphere)y;
                    float a = Vector3.Dot(Direction, Direction);
                    float b = Vector3.Dot(2 * Direction, (Origin - x.Position));
                    float c = Vector3.Dot((Origin - x.Position), (Origin - x.Position)) - (float)Math.Pow(x.Radius, 2);
                    double answer1;
                    double answer2;
                    double det = Abcformula(a, b, c, out answer1, out answer2);
                    if (det == 0)
                    {
                        if (answer1 < intersectiondistance)
                        {
                            intersectiondistance = answer1;
                            nearestShape = x;
                        }
                    }
                    else if (det > 0)
                    {
                        if (answer1 < intersectiondistance && answer1 >= 0)
                        {
                            intersectiondistance = answer1;
                            nearestShape = x;
                        }
                        else if (answer2 < intersectiondistance && answer2 >= 0)
                        {
                            intersectiondistance = answer2;
                            nearestShape = x;
                        }
                    }
                }
                else if (y is Plane) // Intersection on plane 
                {
                    Plane plane = (Plane)y;
                    float notparalel = Vector3.Dot(plane.Normal, Direction);
                    if ( notparalel!= 0)
                    {
                        float bottom = (Vector3.Dot(Direction, plane.Normal));
                        float top = (-(Vector3.Dot(Origin, plane.Normal)+plane.Distance));
                        float distance = top / bottom;
                        if (distance < intersectiondistance && distance >= 0)
                        {
                            intersectiondistance = distance;
                            nearestShape = plane;
                        }
                    }
                }
            }
        }



        private double Abcformula(double a, double b, double c, out double answer1, out double answer2)
            {
                
               double determinant = Math.Sqrt(b*b - 4*a*c);
                answer1 = (-b + determinant) / (2 *a);
                answer2 = (-b - determinant) / (2 * a);
                return determinant;
             }
        }
}
