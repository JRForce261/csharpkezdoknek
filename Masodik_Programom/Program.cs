using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Masodik_Programom
{
    class Program
    {
        static void Main()
        {
            double sum = 0;
            double atlag = 0.00;
            double szorzata = 1;
            for (int i = 0; i <= 10; i++)
            {
                sum += i;
            }
            atlag = sum / 10;
            int j = 1;
            while(j<=10)
            {
                szorzata = szorzata * j;
                j++;
            }    
            Console.WriteLine("Számok öszege:");
            Console.WriteLine(sum);
            Console.WriteLine("Számok átlaga:");
            Console.WriteLine(atlag);
            Console.WriteLine("Számok szorzata:");
            Console.WriteLine(szorzata);
            Console.ReadKey();
        }
    }
}
