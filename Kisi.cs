using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DegiskenlerVeVeriTipleri
{
    public class Kisi
    {
        int TcKimlikNo { get; set; }
        public string Ad { get; set; }

        public string SoyAd { get; set; }

        public string TamAd => Ad+SoyAd ;
    }
}