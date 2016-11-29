using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using System.Threading.Tasks;

namespace template
{
    class Scene
    {
        public List<Light> lights;
        public List<Primitive> shapes;
        public Scene()
        { }

        public static Scene Threeballs ()
        {
            Scene retScene = new Scene();
            retScene.shapes = new List<Primitive>();
            retScene.lights = new List<Light>();
            retScene.shapes.Add(new Plane(new Vector3d(0, 0, 0), new Vector3d(0, 1, 0), new Vector3d(20, 30, 40)));
            retScene.shapes.Add(new Sphere(new Vector3d(1, 0, 5), new Vector3d(80, 80, 80), 1));
            retScene.shapes.Add(new Sphere(new Vector3d(4, 0, 5), new Vector3d(80, 80, 80), 1));
            retScene.shapes.Add(new Sphere(new Vector3d(8, 0, 5), new Vector3d(80, 80, 80), 1));
            return retScene;

        }

    }
}
