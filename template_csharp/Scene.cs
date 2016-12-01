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
        public List<Primitive> shapes;
        public Scene()
        { }

        public static Scene Threeballs ()
        {
            Scene retScene = new Scene();
            retScene.shapes = new List<Primitive>();
            retScene.lights = new List<Light>();
            retScene.shapes.Add(new Plane(new Vector3(-1,0, 0), -7, Material.groenmat()));
            retScene.shapes.Add(new Plane(new Vector3(-1, 0, 0), 7, Material.orangemat()));
            retScene.shapes.Add(new Plane(new Vector3(0, -1, 0),7, Material.purplemat()));
            retScene.shapes.Add(new Plane(new Vector3(0, -1, 0), -7, Material.blauwmat()));
            retScene.shapes.Add(new Plane(new Vector3(0, 0, -1), 10, Material.geelmat()));
            retScene.shapes.Add(new Sphere(new Vector3(3, 0, 7),Material.roodmat(), 1));
            retScene.shapes.Add(new Sphere(new Vector3(0, -2, 5), Material.purplemat(),1));
            retScene.shapes.Add(new Sphere(new Vector3(-4, 4, 8), Material.blauwmat(),  1));
            return retScene;

        }

    }
}
