using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace odevKitapSonsuzDizi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap[] kitapDizi = new Kitap[0];
            string exit="e";

            while (exit=="e")
            {
                Kitap[] gecici = new Kitap[kitapDizi.Length+1];
                Array.Copy(kitapDizi, gecici, kitapDizi.Length);

                Kitap ktp = new Kitap();
                Console.WriteLine("Kitap Adı giriniz: ");
                ktp.kitapAdi = Console.ReadLine();
                Console.WriteLine("Yazar Adı giriniz: ");
                ktp.yazar = Console.ReadLine();
                Console.WriteLine("Yayınevi giriniz: ");
                ktp.yayinEvi = Console.ReadLine();
                Console.WriteLine("Basım yılını giriniz: ");
                ktp.basimYili = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Fiyat giriniz: ");
                ktp.fiyat = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Stok adedi giriniz: ");
                ktp.stok = Convert.ToInt32(Console.ReadLine());

                gecici[gecici.Length - 1] = ktp;
                kitapDizi = gecici;
                Console.WriteLine("Devam edilsin mi?");
                exit = Console.ReadLine();
            }
            Console.Clear();
            for (int i = 0; i < kitapDizi.Length; i++)
            {
                if (kitapDizi[i].stok>0)
                {
                    Console.WriteLine((i + 1) + ". KİTAP \nAdı: " + kitapDizi[i].kitapAdi + "\nYazarı: " + kitapDizi[i].yazar + "\nFiyatı: " + kitapDizi[i].fiyat + "\n------------------------------------");

                }
            }
        }
    }
}
