using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Prime_Answer
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int temp = 0;
            int sum = 0;
            int count = 0;
            bool check = false;
            while (check != true)
            {
                if (isPrime(b)==1)
                {
                    Console.Write(b + " + ");
                    sum = sum + b;
                    count = count + 1;
                    if (count == 8)
                    {
                        Console.WriteLine("");

                        Console.WriteLine(sum);
                        check = true;
                    }
                }
                temp = b;
                b = a + b;
                a = temp;

            }

            Console.ReadLine();
        }

        //Prime Number Check

        public static int isPrime(int n)
        {
            int i;
            int check = 0;
            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    check = 1;
                    break;
                }
            }
            if (check == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }           
        }
    }
}
