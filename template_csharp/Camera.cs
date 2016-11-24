using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Input;

namespace template
{
    public class Camera
    {
        public float vhh;
        public Camera ()
        { }
        public void update()
        {
            if (Keyboard.GetState().IsKeyDown(Key.Right))
            {
                //rotate to right.

            }
        }
            
    }
}
