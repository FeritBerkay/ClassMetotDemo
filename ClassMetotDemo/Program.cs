using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musterı Musteri1 = new Musterı();
            Musteri1.Id = 12345;
            Musteri1.Isim = "Ferit";
            Musteri1.SoyIsim = "Yıldırım";
            Musteri1.cinsiyet = "Erkek";
            Musteri1.KartBilgisi = "Ferit Berkay 1233111";
            Musteri1.adres = "Ankara";
            Musterı Musteri2 = new Musterı();
            Musteri2.Id = 54321;
            Musteri2.Isim = "Mahmut";
            Musteri2.SoyIsim = "YILDIZ";
            Musteri2.cinsiyet = "Belirsiz";
            Musteri2.KartBilgisi = "Mahmut YIldız patatesli kofte";
            Musteri2.adres = "İstanbul";
            Musterı Musteri3 = new Musterı();
            Musteri3.Id = 56789;
            Musteri3.Isim = "Ayşe";
            Musteri3.SoyIsim = "Karahisar";
            Musteri3.cinsiyet = "Kadın";
            Musteri3.KartBilgisi = "Ayşe Karahisar kara olan hisar";
            Musteri3.adres = "İzmir";
            Musterı[] Musteriler = new Musterı[] { Musteri1, Musteri2, Musteri3 };


            MusterıManager musteriManager = new MusterıManager();
            musteriManager.Bilgi(Musteri1);
            musteriManager.Bilgi(Musteri2);
            musteriManager.Bilgi(Musteri3);
        }
    }
}
