using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bai 1 
            int[] a = new int[100];
            int S = 0;
            int n;
            Console.Write("nhap so luong phan tu: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                S += a[i];
            }
            Console.WriteLine("Tong cua day so la" + S);
            Console.ReadLine();
            //Bai 2
            Console.WriteLine("Nhap so hang va cot ");
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(j + 1 + " ");
                }
                Console.WriteLine(i + 1);
            }
            Console.ReadLine();
            //Bai 3
            Console.WriteLine("Nhap chieu cao cay thong ");
            int h = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < h - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2 * i + 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
