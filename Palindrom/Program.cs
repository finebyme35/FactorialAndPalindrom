using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            //Palindrom Ödevi
            string giris;
            string giristersi;
            Console.Write("Palindrom için iki harfden oluşan kelime giriniz (çıkış: q): ");
            giris = Console.ReadLine();
            
            while (giris != "q")
            {
                if (giris.Length >= 2)
                {
                    giristersi = "";
                    for (int i = giris.Length - 1; i >= 0; i--)
                    {
                        giristersi += giris[i];
                    }
                    if (giris == giristersi)
                        Console.Write($"{giris} palindromdur.");
                    else
                        Console.Write($"{giris} palindrom değildir.");
                }
                
                else
                {
                    
                    Console.WriteLine("Kelime en az iki harfden oluşmalıdır.Lütfen Tekrar Deneyiniz.");
                }
                Console.WriteLine();
                Console.Write("Palindrom için iki harfden oluşan kelime giriniz (çıkış: q):");
                giris = Console.ReadLine();
            }
            
            Console.ReadLine();
        }

       
    }
}
