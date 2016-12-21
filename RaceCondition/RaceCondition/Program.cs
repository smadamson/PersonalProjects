using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RaceCondition
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(CallPrimes);
            t1.Start();
            //PrintPrimes();
            t1.Join();
            Console.WriteLine(AllPrimes().First());
            Console.WriteLine(AllPrimes().First());
            Console.Read();
        }
        public static void PrintPrimes()
        {
            foreach (int value in AllPrimes())
            {
                Console.WriteLine(value);
            }
            Console.Read();
        }

        public static void CallPrimes()
        {
            foreach (int value in AllPrimes())
            {
            }
        }

        public static IEnumerable<int> AllPrimes()
        {
            /*
            yield return 2;
            for (int i = 3; i < 100; i += 2)
            {
                if (isPrime(i))
                {
                    yield return i;
                }
            }*/
            for (int i = 1; i < 100; i++)
            {
                yield return i;
            }
        }

        public static bool isPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 2; i <= boundary; ++i)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
    }
}
