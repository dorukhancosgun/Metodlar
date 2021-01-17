using System;

namespace Metodlar
{
    class Program
    {
        //DO NOT REPEAT YOURSELF - DRY - CLEAN CODE
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double Fiyat = 15;
            string aciklama = "Amasya elmasi";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Armut";
            urun3.Fiyat = 10;
            urun3.Aciklama = "Iyi armut";

            //Array istedigimiz kadar veriyi tutmamiza yarar
            Urun[] urunler = new Urun[] {urun1, urun2, urun3};

            //type-safe -- tip guvenli
            foreach (Urun urun in urunler)

            {
               
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------");

            }
            {

                Console.WriteLine("----------METOTLAR--------------");
                //instance - ornek
                //encapsulation

                SepetManager sepetManager = new SepetManager();
                sepetManager.Ekle(urun1);
                sepetManager.Ekle(urun2);

                sepetManager.Ekle2("Armut", "Yesil armut", 12, 10);
                sepetManager.Ekle2("Elma", "Eksi elma", 12, 10);
                sepetManager.Ekle2("Karpuz", "Diyarbakir", 12, 10);
            }

        }
    }
}
