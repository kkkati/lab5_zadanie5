using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array_i = new int[n,n];
            


            Random random = new Random();

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    array_i[i,j] = random.Next(0, 2);
                    Console.Write("{0} ", array_i[i,j]);
                }
                Console.WriteLine();
            }
            


       
            Console.ReadKey();
        }
    }
}
