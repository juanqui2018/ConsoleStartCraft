using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starcraft.Engine
{
    public abstract class Raza
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string Sound { get; set; }
        public string Recollect { get; set; }
        public virtual void Attack()
        {
            Console.WriteLine($"Attack  {Name} ");
        }
    }
    public class Terran : Raza
    {
        public Terran()
        {
            Name = "Terran";
            Color = "Skin";
            Sound = "TalkTerran";
            Recollect = "Mineral";
        }
    }
    public class Zerg : Raza
    {
        public Zerg()
        {
            Name = "Zerg";
            Color = "Red";
            Sound = "TalkZerg";
            Recollect = "Gas";
        }
    }
    public class Protoss : Raza
    {
        public Protoss()
        {
            Name = "Protoss";
            Color = "Green";
            Sound = "TalkProtoss";
            Recollect = "GasMineral";
        }
    }
}
