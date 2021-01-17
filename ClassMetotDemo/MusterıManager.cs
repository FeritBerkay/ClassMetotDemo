using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusterıManager
    {
        public void Bilgi(Musterı bilgi)
        {
            Console.WriteLine("MusteriIdsi = " + bilgi.Id + "/ " + "MusteriAdı = " + bilgi.Isim + "/ " + "MusteriSoyadı = " + bilgi.SoyIsim + "/ " + "Musteri cinsiyeti = " + bilgi.cinsiyet + "/ " + "Musteriadresi = " + bilgi.adres + "/ " + "MusteriKartBilgisi = " + bilgi.KartBilgisi);
        }
    }
}
