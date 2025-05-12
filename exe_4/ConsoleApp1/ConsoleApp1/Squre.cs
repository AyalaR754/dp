using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Squre : IComponent
    {
        public List<IComponent> components { get; set; }
        public int leftPoint { get; set; }
        public Squre()
        {
            components = new List<IComponent>();
        }
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }
        public void move(int x)
        {
            //leftPoint = leftPoint + x;

            foreach (var component in components)
            {
                component.move(x);
            }
            
        }
    }
}
