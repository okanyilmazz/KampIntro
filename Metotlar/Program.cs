using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {


            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Aciklama = "Amasya Elması";
            urun1.Fiyati = 15;
            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.Fiyati = 80;
            //instance
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
    }
}


//dont repeat yourself - DRY - Clean Code - Best Practice
