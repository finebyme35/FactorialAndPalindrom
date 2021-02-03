using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfDraughtTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Dama Tahtası İçin Bir sayı Giriniz: ");
            string number = Console.ReadLine();
            Console.Write("Lütfen Satır Ve Sütun Sayılarını Giriniz: ");
            string rowcolumn = Console.ReadLine();
            int number1 = int.Parse(number);
            int number2 = int.Parse(rowcolumn);
            
            if ( number1 > 0 )
            {
                
                for (int r = 1; r <= number1; r++) 
                {
                    for (int c = 1; c <= number2; c++)
                    {
                        Console.Write("*" + " ");
                       
                    } 
                    Console.WriteLine();
                    for (int a = 1; a <= number2; a++)
                    {
                        Console.Write(" " + "*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Lütfen Pozitif Bir Sayı Giriniz!!");
            }
            Console.ReadLine();
        }

        

    }
}
