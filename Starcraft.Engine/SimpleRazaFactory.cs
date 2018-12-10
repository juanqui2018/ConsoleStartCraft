using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft.Engine
{
    public class SimpleRazaFactory
    {
        public Raza CreateRaza(string type)
        {
            Raza raza = null;
            if(type.Equals("T"))
            {
                raza = new Terran();
            }
            else if (type.Equals("Z"))
            {
                raza = new Zerg();
            }
            else if (type.Equals("P"))
            {
                raza = new Protoss();
            }
            return raza;
        }
    }
}
