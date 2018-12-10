using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft.Engine
{
    public class RazaStore
    {
        SimpleRazaFactory factory;
        public RazaStore(SimpleRazaFactory factory)
        {
            this.factory = factory;
        }
        public Raza OrderRaza(string type)
        {
            Raza raza;
            raza = factory.CreateRaza(type);
            //raza.Attack();

            return raza;
        }
    }
}
