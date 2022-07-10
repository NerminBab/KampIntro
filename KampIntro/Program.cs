using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            
            if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("ayarlar butonu");
            }
            else
            {
                Console.WriteLine("giriş yap");
            }
            Console.WriteLine(kategoriEtiketi);
        

        }
    }
}
