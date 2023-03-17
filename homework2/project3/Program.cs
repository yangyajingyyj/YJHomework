﻿using System;
namespace homework2
{
    class PrimeApp
    {
        const int N = 100;

        static void Main(string[] args)
        {
            bool[] primes = new bool[N + 1];
            for (int i = 2; i < N + 1; i++)
            {
                primes[i] = true;
            }

            Filter(primes);

            for (int num = 2; num < N + 1; num++)
            {
                if (primes[num])
                {
                    Console.Write($"\t{num}");
                }
            }
        }

        // 在数组中过滤出素数
        private static void Filter(bool[] a)
        {
            if (a == null || a.Length == 0) return;
            for (int i = 2; i * i < 51; i++)
            {
                //非素数的倍数不用再次过滤
                if (!a[i]) continue;
                //筛掉i的i倍、i+1倍、i+2倍...
                for (int j = i * i; j < 51; j += i)
                {
                    a[j] = false;
                }
            }
        }
    }
}