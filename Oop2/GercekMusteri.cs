using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class GercekMusteri  // individual (bireysel müşteri)
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public string TcNo { get; set; }    //genelde işlem yapılmadığı zaman sayılar string tanımlanır

        public string Adi { get; set; }
        public string Soyadi { get; set; }

    }
}
