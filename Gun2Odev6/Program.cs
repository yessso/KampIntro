using System;

namespace Gun2Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun piercing = new Urun();
            piercing.ID = 01;
            piercing.Adi = "Tragus Piercing";
            piercing.Fiyati = 17.99;
            piercing.Aciklama = "6 mm cerrahi çelik tragus piercing";
            piercing.StokAdedi = 87;

            Urun yuzuk = new Urun();
            yuzuk.ID = 02;
            yuzuk.Adi = "7'li Yüzük Seti";
            yuzuk.Fiyati = 49.46;
            yuzuk.Aciklama = "Antik gümüş renkli 7 adet mor taşlı yüzük seti";
            yuzuk.StokAdedi = 33;

            Urun[] takilar = new Urun[] { piercing, yuzuk };

            // Buraya kadar takılar kategorisinde iki adet ürün tanıttım.

            Urun bluz = new Urun();
            bluz.ID = 03;
            bluz.Adi = "Siyah Kadın Bluz";
            bluz.Fiyati = 50.99;
            bluz.Aciklama = "Sırt dekolteli, uzun kollu siyah bluz";
            bluz.StokAdedi = 57;

            Urun bustiyer = new Urun();
            bustiyer.ID = 04;
            bustiyer.Adi = "Halter Yaka Büstiyer";
            bustiyer.Fiyati = 72;
            bustiyer.Aciklama = "Gümüş parıltılı, halter yaka büstiyer";
            bustiyer.StokAdedi = 25;

            Urun[] ustGiyim = new Urun[] { bluz, bustiyer };

            // Buraya kadar üst giyim kategorisinde iki adet ürün tanıttım.

            Urun sehpa = new Urun();
            sehpa.ID = 05;
            sehpa.Adi = "Laptop Sehpası";
            sehpa.Fiyati = 43.90;
            sehpa.Aciklama = "Ceviz renkli çok amaçlı laptop sehpası";
            sehpa.StokAdedi = 13;

            Urun raf = new Urun();
            raf.ID = 06;
            raf.Adi = "Ahşap 3'lü Raf";
            raf.Fiyati = 39.90;
            raf.Aciklama = "Dekoratif halatllı 3'lü raf kitaplık";
            raf.StokAdedi = 5;

            Urun[] evEsyalari = new Urun[] { sehpa, raf };

            // Buraya kadar ev eşyalari kategorisinde iki adet ürün tanıttım.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(takilar);
                Console.WriteLine("-----------------");
                Console.WriteLine(ustGiyim);
                Console.WriteLine("-----------------");
                Console.WriteLine(evEsyalari);
                Console.WriteLine("-----------------");

            }

            foreach (var item in collection)
            {

            }
        }
    }
}
