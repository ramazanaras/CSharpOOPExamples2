using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_classes
{
    static class Tools  //içinde static olmayan eleman tanımlanmaz
    {
        public static string ConnectionString { get { return "server=.Database=northwind;Integrated Security=true;"; } }
    }
}
