using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //classın instance'ı ( örneği)
            Musteri musteri1 = new Musteri();
            //Engin Demiroğ 
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demiroğ";
            musteri1.Id = 1;
            musteri1.TcNo = "2222222222";
            musteri1.MusteriNo = "12345";
            musteri1.SirketAdi = "?"; // şirket adı müşteri ile alakalı değil


            //Gerçek Müşteri - Tüzel Müşteri iki nesne ve ikisi de müşteridir.Birbirine benziyor diye birbirinin yerine kullanılamazlar.
            //SOLID 

               
                    
        }
    }
}
