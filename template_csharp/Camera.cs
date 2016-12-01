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
        public Matrix4 cameraMatrix;
        public float halftargetsquareheight;
        public float halftargetsquarewidht;
        public float targetsquaredistance;
        public Camera(Vector3 Position)
        {
            targetsquaredistance = 1;
            halftargetsquareheight = 1;
            halftargetsquarewidht = 1;
            cameraMatrix = new Matrix4(new Vector4(1, 0, 0, Position.X), new Vector4(0, 1, 0, Position.Y), new Vector4(0, 0, 1, Position.Z), new Vector4(0, 0, 0, 1));
        }
        public void update()
        {

            if (Keyboard.GetState().IsKeyDown(Key.Right))
            {
                

            }
        }
            
    }
}
