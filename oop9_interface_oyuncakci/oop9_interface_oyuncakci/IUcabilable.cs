using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop9_interface_oyuncakci
{
    interface IUcabilable:ISurulebilable
    {
        void Yuksel(float miktar);
        void Alcal(float miktar);

    }
}
