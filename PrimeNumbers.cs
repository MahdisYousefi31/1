using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeTest
{
    class One
    {
        static void Main(String[] args)
    {
            int n = 2;
            int m = 40;
            bool isPrime = true;

            for (int j = n; j < m; j++)
            {
                for (int i = j - 1; i > 1; i--)
                {
                    if (j % i == 0)
                        isPrime = false;
                }
                if (isPrime) Console.WriteLine(j);
                 
                isPrime = true;
            }
           Console.ReadLine();
       }
   }
}


     