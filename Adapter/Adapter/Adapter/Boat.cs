using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Boat : ISeaworthy
    {
        public void Swim()
        {
            Console.WriteLine("Лодка плывет по воде");
        }
    }
}
