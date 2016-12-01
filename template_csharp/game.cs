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
            screen.Clear(0x000000);
            scene = Scene.Threeballs();
            camera = new Camera(new Vector3(0, 0, 0),new Vector3(0,0,1),screen.width,screen.height,1);
        }
        public void Tick()
        {
            //screen.Print("hello world!", 2, 2, 0xffffff);
            //camera.update();

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
            Intersection inter = new Intersection(Direction.Normalized(),Origin,scene.shapes);

            if(inter.nearestShape != null)
            {
                return inter.nearestShape.Material.color.ToArgb() ;
            }
            return Color.Black.ToArgb();
        }
    }
}
