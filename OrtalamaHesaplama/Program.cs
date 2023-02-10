using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtalamaHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ogrenci ogrenci = new ogrenci();
            string name, surname;
            double not1, not2, not3;
            

            Console.WriteLine("Ortalama hesaplama uygulamasına hoş geldiniz");
            Console.WriteLine("Girmek istediğini öğrencilerin bilgilerini yazın");
            Console.Write("Ad : ");
            name = Console.ReadLine();
            Console.Write("Soyad : ");
            surname = Console.ReadLine();
            Console.Write("Not1 : ");
            not1 =Convert.ToDouble(Console.ReadLine());
            Console.Write("Not2 : ");
            not2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Not3 : ");
            not3 = Convert.ToDouble(Console.ReadLine());
            ogrenci.OrtalamaHesapla(name,surname,not1,not2,not3);
           
            Console.Read();
        }
    }
}
