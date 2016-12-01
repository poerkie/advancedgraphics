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
        public Vector3 p0;
        public Vector3 p1;
        public Vector3 p2;
        public Vector3 p0p1step;
        public Vector3 p0p2step;
        public Vector3 Direction;
        public Vector3 Position;
        public float ScreenDistance;
        public Camera(Vector3 Position, Vector3 Direction, int screenwidt, int screenheight, float screendistance)
        {
            this.Position = Position;
            this.Direction = Direction;
            this.ScreenDistance = screendistance;
            Vector3 screencenter = Position + screendistance * Direction;
            this.p0 = screencenter+new Vector3(-1,1,0);
            this.p1 = screencenter + new Vector3(1,1,0);
            this.p2 = screencenter + new Vector3(-1,-1,0);
            this.p0p1step = (p1 - p0)/screenwidt;
            this.p0p2step = (p2-p0) /screenheight;

        }


        public void update()
        {


        }

        
            
    }
}
