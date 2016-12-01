using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using OpenTK;
using System.Threading.Tasks;

namespace template
{
    class Scene
    {
        public List<Light> lights;
        public List<Sphere> shapes;
        public Scene()
        { }

        public static Scene Threeballs ()
        {
            Scene retScene = new Scene();
            retScene.shapes = new List<Sphere>();
            retScene.lights = new List<Light>();
          //  retScene.shapes.Add(new Plane(new Vector3d(0, 0, 0), new Vector3d(0, 1, 0), new Vector3d(20, 30, 40)));
            retScene.shapes.Add(new Sphere(new Vector3(-3, 1, 5), Color.Yellow, 1));
            retScene.shapes.Add(new Sphere(new Vector3(0, -4, 5), Color.Red,1));
            retScene.shapes.Add(new Sphere(new Vector3(3, 1, 5), Color.Blue, 1));
            return retScene;

        }

    }
}
