using System;
namespace Generic_List
{
    class Program
    {
        static void Main(string[]args)
        {
        //List<T>class
        //System.Collecitons.Generic
        //T=>object türündedir

        List<int> sayiListesi=new List<int>();
        sayiListesi.Add(10);
        sayiListesi.Add(17);
        sayiListesi.Add(20);
        sayiListesi.Add(38);
        sayiListesi.Add(77);
        sayiListesi.Add(1);

        List<string> renkListesi=new List<string>();
        renkListesi.Add("kırmızı");
        renkListesi.Add("siyah");
        renkListesi.Add("beyaz");
        renkListesi.Add("sarı");
        renkListesi.Add("mor");

        //count (eleman sayısını yazdırır)
        Console.WriteLine(renkListesi.Count);
        Console.WriteLine(sayiListesi.Count);

        foreach (var sayi in sayiListesi)
            Console.WriteLine(sayi);
        foreach (var renk in renkListesi)
            Console.WriteLine(renk);
            
            Console.WriteLine("*****************************");
            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));
            
            //Listeden eleman çıkarma
            sayiListesi.Remove(77);
            sayiListesi.RemoveAt(1);
            renkListesi.Remove("mor");
            renkListesi.RemoveAt(1);
            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            //Liste içinde arama
            if(sayiListesi.Contains(20))
            Console.WriteLine("20 liste içinde bulundu.");

            //Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("sarı"));

            //Diziyi List'e çevirme
            string[] hayvanlar={"kedi","köpek","maymun","kurt"};
            List<string> hayvanListesi=new List<string>(hayvanlar);
            hayvanListesi.ForEach(hayvan=>Console.WriteLine(hayvan));

            //Liste nasıl temizlenir
            hayvanListesi.Clear();

            //Lise içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi=new List<Kullanicilar>();
            Kullanicilar kullanici1=new Kullanicilar();
            kullanici1.Isim="alper";
            kullanici1.Soyisim="saçmaözü";
            kullanici1.Yas=25;

            Kullanicilar kullanici2=new Kullanicilar();
            kullanici2.Isim="mert";
            kullanici2.Soyisim="yıldız";
            kullanici2.Yas=36;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);
            

            List<Kullanicilar> yeniListe=new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar(){
                Isim="ali",
                Soyisim="veli",
                Yas=49
            });
            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("ismi: " +kullanici.Isim);
                Console.WriteLine("soyismi: " +kullanici.Soyisim);
                Console.WriteLine("yaşı: " +kullanici.Yas);
            }
            yeniListe.Clear();  
        }
    }
    public class Kullanicilar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
