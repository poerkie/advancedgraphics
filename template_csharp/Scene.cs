using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using OpenTK;
using OpenTK.Graphics;
using System.Threading.Tasks;

namespace template
{
    class Scene
    {
        public List<Light> lights;
        public List<Primitive> shapes;
        public Scene()
        { }

        public static Scene Multiballs ()
        {
            Scene retScene = new Scene();
            retScene.shapes = new List<Primitive>();
            retScene.lights = new List<Light>();
            retScene.shapes.Add(new Plane(new Vector3(1, 0, 0), -7, Material.witmat()));
            retScene.shapes.Add(new Plane(new Vector3(-1, 0, 0), -7, Material.witmat()));
            retScene.shapes.Add(new Plane(new Vector3(0, -1, 0), -7, Material.witmat()));
            retScene.shapes.Add(new Plane(new Vector3(0, 1, 0), -7, Material.witmat()));
            retScene.shapes.Add(new Plane(new Vector3(0, 0, 1), -10, Material.witmat()));
            retScene.shapes.Add(new Sphere(new Vector3(3, 0, 7), Material.groenmat(), 1));
            retScene.shapes.Add(new Sphere(new Vector3(0, -2, 5), Material.purplemat(), 1));
            retScene.shapes.Add(new Sphere(new Vector3(-4, 4, 8), Material.roodmat(), 1));
            retScene.shapes.Add(new Sphere(new Vector3(-3, 3, 9), Material.orangemat(), 0.2f));
            retScene.lights.Add(new Light(new Vector3(-6, -3, -3), 0.5f));
            retScene.lights.Add(new Light(new Vector3(0, 3, 9),0.5f));
            retScene.shapes.Add(new Sphere(new Vector3(0, 3, 5), Material.geelmat(), 0.2f));
            retScene.shapes.Add(new Sphere(new Vector3(-6, 3, 9), Material.blauwmat(), 1f));
            return retScene;

        }

        public static Scene Walls ()
        {
            Scene retScene = new Scene();
            retScene.shapes = new List<Primitive>();
            retScene.lights = new List<Light>();
            retScene.shapes.Add(new Plane(new Vector3(1, 0, 0), -7, Material.roodmat()));
            retScene.shapes.Add(new Plane(new Vector3(-1, 0, 0), -7, Material.roodmat()));
            retScene.shapes.Add(new Plane(new Vector3(0, -1, 0), -7, Material.roodmat()));
            retScene.shapes.Add(new Plane(new Vector3(0, 1, 0), -7, Material.roodmat()));
            retScene.shapes.Add(new Plane(new Vector3(0, 0, 1), -10, Material.roodmat()));
retScene.lights.Add(new Light(new Vector3(0, 3, 1),0.5f));
             return retScene;

        }

        public static Scene ThreeBalls()
        {
            Scene retScene = new Scene();
            retScene.shapes = new List<Primitive>();
            retScene.lights = new List<Light>();
          //  retScene.shapes.Add(new Plane(new Vector3(1, 0, 0), -7, Material.roodmat()));
            //retScene.shapes.Add(new Plane(new Vector3(-1, 0, 0), -7, Material.roodmat()));
           // retScene.shapes.Add(new Plane(new Vector3(0, -1, 0), -7, Material.roodmat()));
         //   retScene.shapes.Add(new Plane(new Vector3(0, 1, 0), -7, Material.roodmat()));
           // retScene.shapes.Add(new Plane(new Vector3(0, 0, 1), -10, Material.roodmat()));
            retScene.shapes.Add(new Sphere(new Vector3(5, 0, 8), Material.groenmat(), 2));
            retScene.shapes.Add(new Sphere(new Vector3(0, 0, 8), Material.blauwmat(), 2));
            retScene.shapes.Add(new Sphere(new Vector3(-5, 0, 8), Material.roodmat(), 2));
            retScene.lights.Add(new Light(new Vector3(0, 5, 3), 0.5f));
            retScene.lights.Add(new Light(new Vector3(0, 0,0), 0.8f));
            return retScene;

        }
    }
}
