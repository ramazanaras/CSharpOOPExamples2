using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop9_interface
{
    class Sabri:FutbolcuBase,IOyunKurabilable
    {
        public bool CalimAt(float hiz, float aci)
        {
            return true;
        }
    }
}
