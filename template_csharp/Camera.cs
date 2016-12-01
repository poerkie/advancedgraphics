using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Input;

namespace template
{
    // To add screen plane ???
    public class Camera
    {
       // public Matrix4 cameraMatrix;

       /* public Vector3 screencenter ; 
        public Vector3 p0 ;         public Vector3 p1 ;
        public Vector3 p2 ; 
        public Vector3 p0p1step;
        public Vector3 p0p2step;*/
        /// <summary>
        /// 
        /// </summary>
        public Vector3 screencenter {get{return Position + this.ScreenDistance * this.Direction;}}
        public Vector3 p0  { get {return screencenter+new Vector3(-1,1,0);}}
        public Vector3 p1 { get {return screencenter+new Vector3(1,1,0);}}
        public Vector3 p2 { get {return screencenter+new Vector3(-1,-1,0);}}
        public Vector3 p0p1step {get{return (p1 - p0)/screenswidt;}}
        public Vector3 p0p2step { get{return (p2 - p0)/screensheigth;}}
        public Vector3 Direction;
        public Vector3 Position;
        public float ScreenDistance;
        private int screenswidt;
        private int screensheigth;
        public Camera(Vector3 Position, Vector3 Direction, int screenwidt, int screenheight, float screendistance)
        {
            this.screensheigth = screenheight;
            this.screenswidt = screenwidt;
            this.Position = Position;
            this.Direction = Direction;
            this.ScreenDistance = screendistance;
            //Vector3 screencenter = Position + screendistance * Direction;
            //this.p0 = screencenter+new Vector3(-1,1,0);
            //this.p1 = screencenter + new Vector3(1,1,0);
            //this.p2 = screencenter + new Vector3(-1,-1,0);
            //this.p0p1step = (p1 - p0)/screenwidt;
            //this.p0p2step = (p2-p0) /screenheight;

        }
  

     /*   public Camera(Vector3 Position, Camera cam)
        {
            this.Position = Position;
            this.Direction = cam.Direction;
            this.ScreenDistance = cam.ScreenDistance;
            //Vector3 screencenter = Position + this.ScreenDistance * this.Direction;
            //this.p0 = screencenter + new Vector3(-1, 1, 0);
            //this.p1 = screencenter + new Vector3(1, 1, 0);
            //this.p2 = screencenter + new Vector3(-1, -1, 0);
            //this.p0p1step = (p1 - p0) / cam.screenswidt;
            //this.p0p2step = (p2 - p0) / cam.screensheigth;

        }*/


        public void update()
        {
            
          
        }

        
            
    }
}
