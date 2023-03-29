using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararYapilari_tekli_If_Deyimi
{
    internal class Program
    {
        public void tekliIf()
        {

            //gno 3 ve üzeri ise krediyi 4 artır ve harç tutarını %50 azalt
            double gno = 2.0;
            double harcTutari = 1000;
            int alabilecegiKredi = 24;
            //koşula bağlı olarak yapılacak işlem 1 den fazla ise blok oluşturulur
            if (gno >= 3.0)  //büyük veya eşit
            {
                alabilecegiKredi += 4;
                harcTutari /= 2;  //harcTutari = harcTutari /2;
            }
            Console.WriteLine($"Yeni kredi miktarı : {alabilecegiKredi}\nHarç Tutarı : {harcTutari}");

        }
        public void ikiSartliCoklublok()
        {
            double vergi, brutMaas, netMaas;
            Console.WriteLine("Brüt Maaşı Giriniz");
            brutMaas = double.Parse(Console.ReadLine());
            if (brutMaas <= 2500)
            {
                vergi = brutMaas * 0.10;
                netMaas = brutMaas - vergi;
            }
            else
            {
                vergi = brutMaas * 0.15;
                netMaas = brutMaas - vergi;
            }
            Console.WriteLine($"Brüt Maaş : {brutMaas}\nVergi : {vergi}\nNet Maaş :{netMaas}");
        }
        public void cokluif()
        {
            //girilen 10 tane sayının en büyük, en küçük, ortalama ve toplam değerlerin bulan c# kodunu yazınız
            double sayi, eb = 0, ek = 0, ortalama = 0, toplam = 0;
            int sayac = 1;

        basla:
            Console.WriteLine("Bir sayı Giriniz ");
            sayi = double.Parse(Console.ReadLine());
            if (sayac == 1)
            {
                eb = sayi;
                ek = sayi;
            }
            sayac++;
            if (sayi > eb)
                eb = sayi;
            if (sayi < ek)
                ek = sayi;
            toplam += sayi;
            if (sayac <= 10)
                goto basla;
            ortalama = toplam / 10;
            Console.WriteLine($"En Büyük Sayı :{eb}\nEn Küçük Sayı :{ek}\nToplam : {toplam}\nOrtalama :{ortalama}");

        }
        static void Main(string[] args)
        {
            ifElseifKullanimi();

            Console.ReadKey();

        }

        private static void ifElseifKullanimi()
        {
            double vergi, brutMaas, netMaas;
            Console.WriteLine("Brüt Maaşı Giriniz");
            brutMaas = double.Parse(Console.ReadLine());
            if (brutMaas <= 150000)
            {
                vergi = brutMaas * 0.25;
                netMaas = brutMaas - vergi;
            }
            else if (brutMaas <= 300000)
            {
                vergi = brutMaas * 0.30;
                netMaas = brutMaas - vergi;
            }
            else if (brutMaas <= 600000)
            {
                vergi = brutMaas * 0.35;
                netMaas = brutMaas - vergi;
            }
            else
            {
                vergi = brutMaas * 0.40;
                netMaas = brutMaas - vergi;
            }
            Console.WriteLine($"Brüt Maaş : {brutMaas}\nVergi : {vergi}\nNet Maaş :{netMaas}");
        }

        private static void teksatirdaCokKosullu_IF()
        {
            double vize, final, ortalama;
            Console.Write("Vize Notu:");
            vize = double.Parse(Console.ReadLine());

            Console.Write("final :");
            final = double.Parse(Console.ReadLine());

            ortalama = vize * 0.4 + final * 0.6;

            if (final >= 50 && ortalama >= 60)
                Console.WriteLine($"{ortalama}ortalama ile GEÇTİNİZ");
            else
                Console.WriteLine($"Final notunuz 50'den küçük veya ortalamanız 60'dan küçük olduğundan dolayı\nDersten KALDINIZ");
        }
    }
}
