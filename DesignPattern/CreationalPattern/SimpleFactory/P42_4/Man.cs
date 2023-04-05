using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern.SimpleFactory.P42_4
{
    internal class Man : Person
    {
        public void Eat()
        {
            Console.WriteLine("Man Eat");
        }

        public void Speak()
        {
            Console.WriteLine("I am Man");
        }
    }
}
