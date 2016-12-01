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
       //     retScene.shapes.Add(new Plane(new Vector3d(0, 0, 0), new Vector3d(0, 1, 0), Material.groenmat));
            retScene.shapes.Add(new Sphere(new Vector3(-3, 1, 5),Material.roodmat(), 1));
            retScene.shapes.Add(new Sphere(new Vector3(0, -4, 5), Material.geelmat(),1));
            retScene.shapes.Add(new Sphere(new Vector3(3, 1, 5), Material.blauwmat(), 1));
            return retScene;

        }

    }
}
