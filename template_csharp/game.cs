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
        public DateTime lastframe;

        public void Init()
        {
            lastframe = DateTime.Now;
            screen.Clear(0x000000);
            scene = Scene.Threeballs();
            camera = new Camera(new Vector3(0, 0, 0),new Vector3(0,0,1),screen.width,screen.height,1);
        }
        public void Tick()
        {
            screen.Print((DateTime.Now-lastframe).TotalMilliseconds.ToString(), 2, 30, 0xffffff);
            lastframe = DateTime.Now;
            screen.Print(camera.Position.ToString(), 2, 2, 0xffffff);
            //camera.update();
            if (Keyboard.GetState().IsKeyDown(Key.S))
            {
                camera.Position =camera.Position + new Vector3(0, 0.1f, 0);
            }
            if (Keyboard.GetState().IsKeyDown(Key.W))
            {
                camera.Position = camera.Position + new Vector3(0, -0.1f, 0);
            }
            if (Keyboard.GetState().IsKeyDown(Key.D))
            {
                camera.Position = camera.Position + new Vector3(-0.1f, 0, 0);
            }
            if (Keyboard.GetState().IsKeyDown(Key.A))
            {
                camera.Position = camera.Position + new Vector3(0.1f, 0, 0);
            }
            if (Keyboard.GetState().IsKeyDown(Key.Q))
            {
                camera.Position = camera.Position + new Vector3(0, 0, -0.1f);
            }
            if (Keyboard.GetState().IsKeyDown(Key.E))
            {
                camera.Position = camera.Position + new Vector3(0, 0, 0.1f);
            }
        }
        public void Render()
        {
            for(int wid =0; wid< screen.width;wid++)
            {
                for(int hei = 0; hei <screen.height;hei++)
                {
                    Vector3 direction = ((camera.p0 + wid * camera.p0p1step + hei * camera.p0p2step)-camera.Position).Normalized();
                    screen.pixels[wid + hei * screen.height] = traceRay(direction , camera.Position);
                }
            }
            /*The Raytracer implements a
  method Render, which uses the camera to loop over the pixels of the screen plane and to
  generate a ray for each pixel, which is then used to find the nearest intersection. The result is
  then visualized by plotting a pixel. For one line of pixels (typically line 256 for a 512x512
  window), it generates debug output by visualizing every Nth ray (where N is e.g. 10).*/

        }

        public int traceRay(Vector3 Direction, Vector3 Origin )
        {
            Ray firedRay = new Ray(Direction.Normalized(),Origin,scene.shapes);

            if(firedRay.NearestPrimitive != null)
            {
                return firedRay.NearestPrimitive.Material.color.ToArgb() ;
            }
            return Color.Black.ToArgb();
        }
    }
}
