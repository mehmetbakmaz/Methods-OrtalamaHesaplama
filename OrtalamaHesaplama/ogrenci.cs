using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtalamaHesaplama
{
    internal class ogrenci
    {
        public void OrtalamaHesapla(string ad,string soyad,double not1,double not2,double not3)
        {
            Console.WriteLine(ad+" "+soyad+ " adlı kişinin not ortalaması bilgileri aşağıdaki gibidir ");
            double ort = ortalama(not1, not2, not3);
            ortalamaDegerlendir(ort);
            //ortalamaDegerlendir(ortalama(not1,not2,not3));
        }
        void ortalamaDegerlendir(double ortalama) 
        {
            if (ortalama < 45)
            {
                Console.WriteLine("Ortalama değeriniz {0} : Maalesef kaldınız", ortalama);
            }
            else
            {
                Console.WriteLine("Ortalama değeriniz {0} : Tebrikler geçtiniz", ortalama);
            }
        }
        private double ortalama(double ogrencinot1, double ogrencinot2, double ogrencinot3) 
        {
            double ort = (ogrencinot1 + ogrencinot2 + ogrencinot3) / 3;
            return ort;
        }
    }
}
