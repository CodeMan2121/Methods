using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Urun urun)//public void ile Ekle adında bir metot tanımladık.Bu metot ekrana "Sepete eklendi" yazdırmaktır. 
        {
            //convention - isimlendirme

            Console.WriteLine("Sepete eklendi : " + urun.Adi);

        }

        public void Ekle2(string Adi, double Fiyat, string Aciklama)
        {//Bu şekilde yapmak zaman kaybı oluyor galiba. Çünkü değişken içindeki parametrelere yeni bir tanesi eklenirse her satırda düzeltmek gerek.
            Console.WriteLine("Sepete eklendi: " + Adi);
        }
    }
}
