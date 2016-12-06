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
    class Ray
    {
        public Vector3 intersectionNormal;
        public Vector3 intersectionPosition;
        public Vector3 Direction;
        public Vector3 Origin;
        public double TraveledDistance;
        public Primitive NearestPrimitive;
        public Color4 FoundColor;
      


        //normal ray
        public Ray(Vector3 Direction, Vector3 Origin, List<Primitive> shapes, List<Light> lights)
        {
            this.FoundColor = new Color4(0,0,0,255);
            TraveledDistance = float.MaxValue;
            this.Direction = Direction;
            this.Origin = Origin;
            foreach (Primitive prim in shapes)
            {
                prim.Intersect(this);
            }
            foreach (Light lampje in lights)
            {
                //als er een hit is en belicht niet de achterkant
                if (NearestPrimitive!=null && Vector3.Dot(intersectionNormal, (lampje.Position - intersectionPosition)) <= 0)
                {
                    //zoek geen match met jezelf :
                    Ray shadowray = new Ray(( lampje.Position- this.intersectionPosition ).Normalized(), this.intersectionPosition, shapes.Where(x =>x != NearestPrimitive ).ToList());
                   
                      //als het niet in de shaduw ligt.
                        if (shadowray.NearestPrimitive == null ||(shadowray.intersectionPosition - this.intersectionPosition).Length > (lampje.Position - this.intersectionPosition).Length)
                        {
                            if (this.NearestPrimitive.Material.matType == TypeofMaterial.Difsuse)
                            {
                              //  this.FoundColor = this.NearestPrimitive.Material.color;
                               // float lightAmp = 0.5f;
                                float lightAmp = Vector3.Dot(-shadowray.Direction,this.intersectionNormal) *lampje.intensity;
                                this.FoundColor.B = Math.Min(this.NearestPrimitive.Material.color.B * lightAmp + this.FoundColor.B,1) ;
                                this.FoundColor.R = Math.Min(this.NearestPrimitive.Material.color.R * lightAmp +this.FoundColor.R,1);
                                this.FoundColor.G = Math.Min(this.NearestPrimitive.Material.color.G * lightAmp+ this.FoundColor.G,1);
                                //this.FoundColor.A += 100;//Vector3.Dot(this.intersectionNormal, shadowray.Direction) * this.NearestPrimitive.Material.color.A;
                                //this.FoundColor.R += Vector3.Dot(this.intersectionNormal, shadowray.Direction) * this.NearestPrimitive.Material.color.R;
                                //this.FoundColor.G += Vector3.Dot(this.intersectionNormal, shadowray.Direction) * this.NearestPrimitive.Material.color.G;
/*
                                // phong-blinn
                                Vector3 blinnDir = (lampje.Position-intersectionPosition).Normalized() - (Origin - intersectionPosition).Normalized();
                                float temp = (float)Math.Sqrt(Vector3.Dot(blinnDir, blinnDir));
                                if (temp != 0.0f)
                                {
                                    blinnDir = (1.0f / temp) * blinnDir;
                                    float blinnTerm = Math.Max(Vector3.Dot(blinnDir, intersectionNormal), 0.0f);
                                    blinnTerm = this.NearestPrimitive.Material.specPower * (float)Math.Pow(blinnTerm, this.NearestPrimitive.Material.specPower) * 0.5f;

                                    this.FoundColor.R += blinnTerm * this.FoundColor.R;
                                    this.FoundColor.G += blinnTerm * this.FoundColor.G;
                                    this.FoundColor.B += blinnTerm * this.FoundColor.B;
                                }*/
                                
                            }
                            else if (this.NearestPrimitive.Material.matType == TypeofMaterial.Glass)
                            {
                                //To be implemented
                            }
                        }                             
                                 
                }
            }
        }

        //Shadowray :)
        public Ray(Vector3 Direction, Vector3 Origin, List<Primitive> shapes)
        {
            TraveledDistance = float.MaxValue;
            this.Direction = Direction;
            this.Origin = Origin;
            foreach (Primitive prim in shapes)
            {
                prim.Intersect(this);
            }
        }
    }
}