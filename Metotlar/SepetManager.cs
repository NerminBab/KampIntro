using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : "+ urun.Adi);
            Console.WriteLine("sepete eklendi: "+urun.StokAdedi);
           
        }

    }
}
