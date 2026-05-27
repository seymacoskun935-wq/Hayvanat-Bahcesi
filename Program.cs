using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP 
{
    internal class Program 
    {
       static  List<Hayvan> hayvanlar = new List<Hayvan>();

        static void Main(string[] args) 
        {

            Hayvan t = new Dinozor("trex", "roarrrr");
            Hayvan p = new Dinozor("pterosour", "kırrrr");


            hayvanlar.Add(new Kus("Kartal", "Kiii"));
            hayvanlar.Add(new Kus("Serçe", "Ciik ciikk"));
            hayvanlar.Add(t);
            hayvanlar.Add(p);

          Console.WriteLine("Hayvanat bahçesi oyununa hoş geldiniz...Ne yapmak istersiniz?");
            Secim();

          
        }

       
        public static void Secim()
        {
            while (true)
            {

                Console.WriteLine("1- Hayvan ekle");
                Console.WriteLine("2- Hayvanları listele");
                Console.WriteLine("3- Ses çıkar");
                Console.WriteLine("4- Yemek ver");
                Console.WriteLine("5- Hayvan sil");
                Console.WriteLine("6- Listeyi temizle");
                Console.WriteLine("7- Hayvan ara");
                Console.WriteLine("8- Tüm hayvanları besle");
                Console.WriteLine("9- Dinozorları tanı");
                Console.WriteLine("10- Uçabilen canlıları gör");

                int sec;
                if (!int.TryParse(Console.ReadLine(), out sec))
                {
                    Console.WriteLine("Lütfen sayı girin");
                    return;
                }
                if (sec > 10 || sec <= 0)
                {
                    Console.WriteLine("Geçersiz numara");
                }
                switch (sec)
                {
                    case 1:
                        Console.Clear();
                        HayvanEkle();
                        break;
                    case 2:
                        Console.Clear();
                        HayvanListele();
                        break;
                    case 3:
                        Console.Clear();
                        SesCikar();
                        break;
                    case 4:
                      
                        Besle();
                        break;
                    case 5:                     
                        HayvanSil();
                        break;
                    case 6:
                        hayvanlar.Clear();
                        break;
                    case 7:
                        HayvanAra();
                        break;
                    case 8:
                        HayvanlarıBesle();
                        break;
                    case 9:
                        Dinozorlar();
                        break;
                    case 10:
                        Ucan();
                        break;
                       


                }
            }
        }

       

        public  static void HayvanEkle() 
        {
            Console.WriteLine("Eklemek istediğiniz hayvanı girin:  ");
        
           string   isim = Console.ReadLine();
            isim = isim.ToLower();
            Console.WriteLine("Çıkardığı sesi girin: ");
            string  ses = Console.ReadLine();

            Console.WriteLine("Eklediğiniz hayvan uçabilir mi? (1- evet , 2- hayır)");
            int sec;

            if (!int.TryParse(Console.ReadLine(), out sec))
            {
                Console.WriteLine("Geçersiz giriş");
                return;
            }


            if(sec == 1)
            {
                hayvanlar.Add(new Kus(isim, ses));
            }
             else if(sec == 2)
            {
                hayvanlar.Add(new Hayvan(isim, ses));
            }
            else
            {
                Console.WriteLine("Geçersiz giriş");
            }
          
         
          

           
          

        }
        public static void HayvanListele() 
        {
            if(hayvanlar.Count== 0)
            {
                Console.WriteLine("Liste boş");
            }


            for (int i = 0; i < hayvanlar.Count; i++)
            {               
              Console.WriteLine( (i+1) + "- " + "Adı: " +hayvanlar[i].Ad + " aç mı: "  + hayvanlar[i].AcMi); 
            }
           
        }
        public static void SesCikar()
        {
            foreach (Hayvan hayvan in hayvanlar)
            {
                hayvan.SesCikar();
            }

        }
        public static void Besle()
        {
            HayvanListele();
            Console.WriteLine("Hangi hayvanı beslemek istiyorsunuz? ");
            int ymk;
            if(int.TryParse(Console.ReadLine (), out ymk))
            {
               if (ymk > 0 && ymk <= hayvanlar.Count)
                {
                    hayvanlar[ymk - 1].AcMi = false;
                    Console.WriteLine($"{hayvanlar[ymk-1].Ad} doydu");
                }
               else
                {
                    Console.WriteLine("Geçersiz aralık");
                    return;

                }
            }
            else
            {
                Console.WriteLine("Geçersiz değer");
                return;
            }
         
        }
        public static void HayvanSil()
        {
            Console.WriteLine("Silmek istediğiniz hayvanın numarasını girin: ");
            int sil;
            if (int.TryParse(Console.ReadLine(), out sil))
            {
                if (sil > 0 && sil <= hayvanlar.Count)
                {
                    hayvanlar.RemoveAt(sil - 1);
                }
                else
                {
                    Console.WriteLine("Geçersiz aralık");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz değer");
                return;
            }

        }
        public static void HayvanAra()
        {
            bool bulunduMu = false;
            Console.WriteLine("Aradığınız hayvanı girin");
            string  ara = Console.ReadLine();
            ara = ara.ToLower();
            foreach (Hayvan hayvan in hayvanlar)
            {
                if(ara == hayvan.Ad.ToLower())
                {
                    Console.WriteLine("Aradığınız hayvan bulundu.. İşte bilgileri: ");
                    Console.WriteLine( "Adı: " +hayvan.Ad+ "  Çıkardığı ses: "+hayvan.Ses+ " "+"Aç mı: "+ hayvan.AcMi);
                    bulunduMu = true;
                    break;
                }
            }
            if (!bulunduMu)
            {
                Console.WriteLine("Aradığınız hayvan bulunamadı");
            }
            
        }
        public static void HayvanlarıBesle()
        {
            Console.WriteLine("Tüm hayvanlar beslendiiii");
            foreach (Hayvan hayvan in hayvanlar )
            {
                if (hayvan.AcMi == true)
                {
                    hayvan.AcMi = false;
                }
            }
        }
        public static  void Dinozorlar()
        {  
            foreach (Hayvan trexx in hayvanlar)
            {
                if(trexx is Dinozor)
                {
                    Console.WriteLine($"{trexx.Ad} bir dinozor türüdür");
                }
            }

          

        }
        public static void Ucan()
        {
            foreach (Hayvan u in hayvanlar)
            {
                if(u is IUcabilenCanlilar ucan)
                {
                    ucan.Ucan();
                }
            }
        }
        
    }

}
 