using System;
using System.Collections.Generic;

namespace homework2
{
    public class Project1
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("请输入一个整数:");
                int num = Convert.ToInt32(Console.ReadLine());
                List<int> factors = Factorize(num);
                Console.Write("素因子有:");
                factors.ForEach(f => Console.Write("\t" + f));
            }
            catch (Exception e)
            {
                Console.WriteLine($"错误:{e.Message}");
            }
        }

        //因数分解
        private static List<int> Factorize(int num)
        {
            if (num <= 1)
            {
                throw new ArgumentException("num必须大于1");
            }

            List<int> factors = new List<int>();

            int n = num;
            for (int i = 2; i * i <= n; i++)//根据老师修改i*i相比于根号更简单
            {
                while (n % i == 0)
                {
                    factors.Add(i);
                    n = n / i;  
                }
            }
            
            if (n != 1)
            {
                factors.Add(n);
            }

            return factors;
        }
    }