using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern.SimpleFactory.P42_5
{
    internal class Rectangle : Shape
    {
        public void Draw()
        {
            Console.WriteLine(this.GetType().Name + "Draw");
        }

        public void Easer()
        {
            Console.WriteLine(this.GetType().Name + "Easer");
        }
    }
}
