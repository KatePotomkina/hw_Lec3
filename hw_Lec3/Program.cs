using System;
using System.Collections.Generic;
using System.Linq;

namespace hw_Lec3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            factorial(5);
            fibonacci(50);
                               }
        public static void factorial(int num)
        {
            IEnumerable<int> query = Enumerable.Range(1, num);
            int factorial = query.Aggregate((a, b) => a * b);
            Console.WriteLine(factorial.ToString());
        }
        public static void fibonacci(int num)
        {
            List<int> query1 = new List<int>();
            Enumerable.Range(0, 200)
                 .ToList()
                 .ForEach(i =>
                     query1.Add(i <= 0 ? 0: i <= 1 ? 1 : query1[i - 2] + query1[i - 1])) ;
            for (int k = 0; k < num; k++)
            {
                Console.Write(query1[k].ToString()+" ");
            }
        }
    }
}
