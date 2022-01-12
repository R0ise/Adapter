using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class BoatToTransportAdapter : ITransport
    {
        Boat boat;
        public BoatToTransportAdapter(Boat c)
        {
            boat = c;
        }

        public void Drive()
        {
            boat.Swim();
        }
    }
}
