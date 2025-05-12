using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Line : IComponent
    {
        public int leftPoint { get; set; }
        public void move(int x)
        {
            leftPoint = leftPoint+x;
            Console.WriteLine(leftPoint);
        }
    }
}
