using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri:Musteri  // individual (bireysel müşteri)
    {
       
        public string TcNo { get; set; }    //genelde işlem yapılmadığı zaman sayılar string tanımlanır
        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
