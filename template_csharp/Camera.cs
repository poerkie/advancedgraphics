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
        public Vector3d Position;
        public Vector3d Direction;
        public Camera(Vector3d Position, Vector3d Direction)
        {
            this.Position = Position;
            this.Direction = Direction;
        }
        public void update()
        {

            if (Keyboard.GetState().IsKeyDown(Key.Right))
            {
                //rotate to right.

            }
        }
            
    }
}
