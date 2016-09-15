using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop9_interface
{
    class Arda:FutbolcuBase,ISutCekebilable,IOyunKurabilable
    {

        public float Mesafe
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool SutCek(float guc, float aci)
        {
            //şutu çektir çekebildiyse true dönder
            return true;
        }

        public bool CalimAt(float hiz, float aci)
        {
            return true;
        }
    }
}
