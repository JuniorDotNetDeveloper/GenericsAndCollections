using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollextionTests.Models
{
    enum EngineType : byte
    {
        Diesel,
        Benzin
    }

    class Engine
    {
        public int EngineId { get; set; }
        public EngineType EngType{ get; set; }
        public int Hp { get; private set; }
        public float Volume { get; private set; }
        public int Torque { get; private set; }

        public Engine(EngineType engineType, int horsePower, float volume, int torque)
        {
            EngType = engineType;
            Hp = horsePower;
            Volume = volume;
            Torque = torque;
        }


    }
}
