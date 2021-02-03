using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Doğum Tarihinizi Gün.Ay.Yıl Olacak Şekilde Giriniz: ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Age(birthday);

            Console.ReadLine();
        }

        static void Age(DateTime age)
        {
            int result = DateTime.Today.Year - age.Year;
            Console.WriteLine(result);
        }
        
    }
}
