using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{

    //miras :inheritance
    //corporate (tüzel)
    class TuzelMusteri :Musteri //tüzel müşteri miras alır,müşteriden.Tüzelmüşterinin ebeveyni müşteridir.Müşteride olan her şey tüzel müşteride kabul edilir.
    {
       
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
