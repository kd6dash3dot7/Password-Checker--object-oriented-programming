/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2014-2015 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: G201210086 
**				ÖĞRENCİ ADI............: SAMET 
**				ÖĞRENCİ NUMARASI.......: GÜZEL
**                         DERSİN ALINDIĞI GRUP...: 2. ÖĞRETİM
****************************************************************************/



using System;

using System;

public static class KarakterSayaci    //Sifrenin karakterlerinin sayıldığı sınıf
{
    public static int BuyukHarf(string sifre)  // Buyuk harf sayma metodu
    {
        int sayi = 0;
        for (int i = 0; i < sifre.Length; i++)
        {
            if (char.IsUpper(sifre[i]))
                sayi++;
        }

        return sayi;
    }

    public static int KucukHarf(string sifre)  // Kucuk harf sayma metodu
    {
        int sayi = 0;
        for (int i = 0; i < sifre.Length; i++)
        {
            if (char.IsLower(sifre[i]))
                sayi++;
        }

        return sayi;
    }

    public static int Rakam(string sifre)   // Rakam sayma metodu
    {
        int sayi = 0;
        for (int i = 0; i < sifre.Length; i++)
        {
            if (char.IsDigit(sifre[i]))
                sayi++;
        }

        return sayi;
    }

    public static int Sembol(string sifre)  // Sembol sayma metodu
    {
        int sayi = 0;
        for (int i = 0; i < sifre.Length; i++)
        {
            if (!char.IsLetterOrDigit(sifre[i]))
                sayi++;
        }

        return sayi;
    }
}


public class Program
{
    public static void Main(string[] args)  // Main fonksiyonunda kullanıcından şifre girilmesi isteniyor ardından şifre uzunluğu alınarak 9 küçük büyük karşılaştırması yapılıyor
    {
        while (true)
        {
            Console.Write("Sifrenizi giriniz: ");
            string sifre = Console.ReadLine();
            if (sifre.Length < 9) // Eğer şifrenin karakter uzunluğu 9 dan küçük ise hata mesajı kullanıcıya iletiliyor.
            {
                Console.WriteLine("Sifreniz 9 karakterden kucuk olamaz!");
                continue;
            }

            int puan = 0;                                       
            int kucukHarf = KarakterSayaci.KucukHarf(sifre); 
            int buyukHarf = KarakterSayaci.BuyukHarf(sifre);  
            int rakam = KarakterSayaci.Rakam(sifre);         
            int sembol = KarakterSayaci.Sembol(sifre);

            for (int i = 0; i < sifre.Length; i++)  // Şifrenin karakter olarak boşluk içermesi durumunda kullanıcıyı uyaran döngü.
            {
                if (char.IsWhiteSpace(sifre[i]))
                {

                    Console.WriteLine("Sifreniz karakter olarak bosluk iceremez.");
                    break;
                }
                continue;
            }
            



            
            if (sifre.Length == 9) // Eğer şifre karakter uzunluğu 9 ise + 10 puan ekleniyor
            {
                puan += 10;
                bool hataliSifre = false;

                if (kucukHarf == 0)
                {
                    Console.WriteLine("Sifreniz 9 karakter yada fazlasıysa bir kucuk harf bulundurmak zorunda!");
                    hataliSifre = true;
                }

                if (buyukHarf == 0)
                {
                    Console.WriteLine("Sifreniz 9 karakter yada fazlasıysa bir buyuk harf bulundurmak zorunda!");
                    hataliSifre = true;
                }

                if (rakam == 0)
                {
                    Console.WriteLine("Sifreniz 9 karakter yada fazlasıysa bir rakam bulundurmak zorunda!");
                    hataliSifre = true;
                }

                if (sembol == 0)
                {
                    Console.WriteLine("Sifreniz 9 karakter yada fazlasıysa bir sembol bulundurmak zorunda!");
                    hataliSifre = true;
                }



                if (hataliSifre)
                    continue;
            }
            else // Şifre karakter uzunluğunun 9dan büyük olduğu durumlar için karakter cinslerine bakıyor.
            {
                bool hataliSifre = false;

                if (kucukHarf == 0) 
                {
                    Console.WriteLine("Sifreniz 9 karakterden buyukse bir kucuk harf bulundurmak zorunda!");
                    hataliSifre = true;
                }

                if (buyukHarf == 0)
                {
                    Console.WriteLine("Sifreniz 9 karakterden buyukse bir buyuk harf bulundurmak zorunda!");
                    hataliSifre = true;
                }

                if (rakam == 0)
                {
                    Console.WriteLine("Sifreniz 9 karakterden buyukse bir rakam bulundurmak zorunda!");
                    hataliSifre = true;
                }

                if (sembol == 0)
                {
                    Console.WriteLine("Sifreniz 9 karakterden buyukse bir sembol bulundurmak zorunda!");
                    hataliSifre = true;
                }

               

                if (hataliSifre) 
                    continue;
            }

            Console.WriteLine($"Buyuk harf sayisi: {buyukHarf}");
            Console.WriteLine($"Kucuk harf sayisi: {kucukHarf}");
            Console.WriteLine($"Rakam sayisi: {rakam}");
            Console.WriteLine($"Sembol sayisi: {sembol}");

            if (kucukHarf > 2)  // Küçük harf sayısı 2den fazla ise maksimum 20 puan alınması için küçük harf sayısı 2ye sabitleniyor. 
                kucukHarf = 2;
            puan += kucukHarf * 10;

            if (buyukHarf > 2)  // Büyük harf sayısı 2den fazla ise maksimum 20 puan alınması için büyük harf sayısı 2ye sabitleniyor. 
                buyukHarf = 2;
            puan += buyukHarf * 10;

            if (rakam > 2)     // Rakam sayısı 2den fazla ise maksimum 20 puan alınması için rakam sayısı 2ye sabitleniyor. 
                rakam = 2;
            puan += rakam * 10;

 
                
            puan += sembol * 10;
            Console.WriteLine("Sifrenizin puani: "+ puan);
            if (puan < 70)     
            {
                Console.WriteLine("70 puandan kucuk sifreler kabul edilemez."  );

                continue;
                
            }
            else if(puan>70 && puan < 90)
            {
                Console.WriteLine("Sifreniz kabul edilebilir guvenlikte.");
                
            }
            else {
                Console.WriteLine("Sifreniz kabul edilebilir ve gucludur.");

            }

            break;
            
        }
        Console.ReadLine();
    }

}
