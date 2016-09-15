using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop9_interface
{
    interface ISutCekebilable
    {
        //interfacelerde field tanımlanmaz
        //string top;

        float Mesafe { get; set; }

        //metotların gövdeleri yoktur ve başına public yazılmaz 
        bool SutCek(float guc, float aci);
    
    }
}
