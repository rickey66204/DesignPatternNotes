using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern.SimpleFactory.P42_4
{
    internal class Woman : Person
    {
        public void Eat()
        {
            Console.WriteLine("Woamn Eat");
        }

        public void Speak()
        {
            Console.WriteLine("I am Woamn");
        }
    }
}
