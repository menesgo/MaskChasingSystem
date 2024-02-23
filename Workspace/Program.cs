using System;
using Entities.Concrete;
using Business.Concrete;

namespace Workspace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();
            //Vatandas vatandas1 = new Vatandas();

            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Mustafa");
            SelamVer(isim: "Enes");
            SelamVer();

            int sonuc = Topla(6,58);

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0]= "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "Mustafa Enes";
            person1.LastName = "Güzelordu";
            person1.DateOfBirthYear = 1900;
            person1.NationalId = 50;

            Person person2 = new Person();
            person2.FirstName = "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            //MyList (koleksiyon yazma)
            List<string> yenisehirler = new List<string> { "Ankara 1","İstanbul 1","İzmir 1"};
            yenisehirler.Add("Adana 1");
            foreach(var sehir in yenisehirler)
            {
                Console.WriteLine(sehir);
            }


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
                    

            Console.ReadLine();
        }

        static void SelamVer(string isim = "İsimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 5, int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam " + sonuc);
            return sonuc;
        }

        //    private static void Degiskenler()
        //    {
        //        string mesaj = "Selam";
        //        double tutar = 100000; //db den gelir
        //        int sayi = 100;
        //        bool girisYapmisMi = false;

        //        string ad = "Mustafa";
        //        string soyad = "Güzelordu";
        //        int dogumYili = 1998;
        //        long tcNo = 12345678910;

        //        Console.WriteLine(mesaj);
        //    }
    }
    //public class Vatandas
    //{
    //    public string Ad { get; set; }
    //    public string Soyad { get; set; }
    //    public int DogumYili { get; set;}
    //    public long TcNo { get; set;}
    //}
}
