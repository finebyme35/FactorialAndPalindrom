using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //FAKTÖRİYEL HESABI ÖDEVİ
            Console.Write("Pozitif TamSayi Giriniz: ");
            string sayi = Console.ReadLine();
            int son = 0;
            int sayi1 = Convert.ToInt32(sayi);
            int result = 1;

            if (sayi1 < son)
            {
                Console.WriteLine("Pozitif TamSayi Girmediniz!!.Lütfen Pozitif Tamsayı Giriniz.");
            }
            else if (sayi1 == son)
            {

                Console.WriteLine("Girdiğiniz TamSayı Değeri Sıfır' a eşittir.0'ın Faktöriyel Değeri 1'dir.");
            }
            else
            {

                for (int i = 1; i <= sayi1; i++)
                {
                    result = i * result;

                }
                Console.WriteLine(result);
            }
        }
    }
}
