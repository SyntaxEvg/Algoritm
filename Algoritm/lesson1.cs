using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritm
{
    public static class lesson1
    {
        //Напишите на C# функцию согласно блок-схеме/
        /// <summary>
        /// Определить четность число
        /// </summary>
        /// <param name="n"></param>
        public static void  MainAlgoritm(int n)
        {
            int i = 2;
            int d = 0;
            while (i < n)
            {
                if (n % i == 0)//четное нечетно))
                {
                    d++;                  
                    break;
                }
                i++;
            }
            string str= d == 0 ? "простое" : "не простое";
            Console.WriteLine($"Число {n} {str}");
        }
        /// <summary>
        ///Cложность функции подсчитываем простые операции 
        /// 1 + 8 * raz ^ 3,
        /// сложность (n^3)
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static int StrangeSum(int[] inputArray)
        {
            int sum = 0; //1
            for (int i = 0; i < inputArray.Length; i++) // * raz
            {
                for (int j = 0; j < inputArray.Length; j++) // * raz
                {
                    for (int k = 0; k < inputArray.Length; k++) // * raz
                    {
                        int y = 0;

                        if (j != 0)
                        {
                            y = k / j;
                        }

                        sum += inputArray[i] + i + k + j + y; 
                    }
                }
            }

            return sum;
        }
        /// <summary>
        /// Числа FIbo method FOR
        /// </summary>
       public static void FiboNumFor(ref int n)
        {
            int a = 1;
            int b = 0;
            int f;
            while (true)
            {
                f = a + b; b = a;  a = f;
                if (f <= n) Console.WriteLine(f);
                else
                    break;
            }
        }
        /// <summary>
        /// RecMethod Fibo
        /// </summary
       public static void FiboNumRec(ref int n, int a = 1, int b = 0, int Fibo = 0)
        {
            Fibo = a + b; b = a;  a = Fibo;
            if (Fibo <= n)
            {
                Console.WriteLine(Fibo);
                FiboNumRec(ref n, a, b,Fibo);
            }
        }
    }
}
