using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.CreationalPattern.SimpleFactory.P42_4
{
    internal class NvWa
    {
        public static Person CreatePerson(string args)
        {
            if (args.Equals("M"))
            {
                return new Man();
            }
            else if (args.Equals("W"))
            {
                return new Woman();
            }
            else
            {
                return null;
            }
        }
    }
}
