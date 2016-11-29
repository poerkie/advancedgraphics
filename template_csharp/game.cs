using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace template
{

    // is Application and raytracer class in one.
    class Game
    {
        public Surface screen;
        public Scene scene;
        public Camera camera;

        public void Init()
        {
            screen.Clear(0x2222ff);
            scene = Scene.Threeballs();
            camera = new Camera(new Vector3d(0, 0, 0), new Vector3d(0, 0, 1));
        }
        public void Tick()
        {
            screen.Print("hello world!", 2, 2, 0xffffff);
            camera.update();

        }
        public void Render()
        {
            /*The Raytracer implements a
  method Render, which uses the camera to loop over the pixels of the screen plane and to
  generate a ray for each pixel, which is then used to find the nearest intersection. The result is
  then visualized by plotting a pixel. For one line of pixels (typically line 256 for a 512x512
  window), it generates debug output by visualizing every Nth ray (where N is e.g. 10).*/

        }

    }
}
