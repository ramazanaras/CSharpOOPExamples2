using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5_polymorhism
{
    public class Insan
    {
        public string TCKN { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        /*
         override:her yiğidin bir yoğurt yiyişi vardırı sağlar. :)
         */

        public virtual void YogurtYe() //ezilebilmesini(override edilebilmesini) sağladık
        {
        //hapur hupur ye
        
        }
    }
}
