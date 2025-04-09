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
            //Console.Read();
            //Console.Write("Hello");
            //Console.WriteLine("World");
            //Console.ReadLine();

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());
            //int d = Convert.ToInt32(Console.ReadLine());
            //int f = Convert.ToInt32(Console.ReadLine());
            //int sum = a + b + c + d + f;
            //int mult = a * b * c * d * f;
            //Console.WriteLine("summ: " + sum.ToString());
            //int max = a;
            //int min = a;
            //if (max < b)
            //{
            //    max = b;
            //}
            //if (max < c)
            //{
            //    max = c;
            //}
            //if (max < d)
            //{
            //    max = d;
            //}
            //if (max < f)
            //{
            //    max = f;
            //}
            //if (min > b)
            //{
            //    min = b;
            //}
            //if (min > c)
            //{
            //    min = c;
            //}
            //if (min > d)
            //{
            //    min = d;
            //}
            //if (min > f)
            //{
            //    min = f;
            //}
            //Console.WriteLine("max num: " + max.ToString());
            //Console.WriteLine("min num: " + min.ToString());
            //Console.WriteLine("multiply: " + mult.ToString());

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = 0;
            //int c = 1;
            //Console.Write(b.ToString() + ", " + c.ToString() + ", ");
            //for (int i = 0; i < a; i++)
            //{
            //    int sum = b + c;
            //    if (sum > a) break;
            //    b = c;
            //    c = sum;
            //    Console.Write(sum.ToString() + ", ");
            //}

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //for (int i = a; i <= b; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        int c = i + j;
            //        Console.Write(c.ToString() + " ");
            //    }
            //    Console.Write("\n");

            //}

            //int a = Convert.ToInt32(Console.ReadLine());
            //char s = Convert.ToChar(Console.ReadLine());
            //Console.Write("Enter direction(0 - horizontal, 1 - vertical): ");
            //int dir = Convert.ToInt32(Console.ReadLine());
            //if (dir == 0)
            //{
            //    for (int i = 0; i < a; i++)
            //    {
            //        Console.Write(s);
            //    }
            //    Console.Write("\n");
            //}
            //else if (dir == 1)
            //{
            //    for (int i = 0; i < a; i++)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}

            //int[] a = new int[4]; // static
            //int[] b = {1, 4, 6};
            //foreach(int i in b)
            //{
            //    Console.WriteLine(i);
            //}
            //List<int> name = new List<int>(); // dinamic
            //int[] name_l = name.ToArray();

            //int[] a = { 1, 6, 4, 5, 4, 34, 34, 3, 23, 10, 1, 1, };
            //int count = 0;
            //Console.Write("Even numbers: ");
            //foreach (int i in a)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i.ToString() + " ");
            //        count++;
            //    }
            //}
            //Console.WriteLine("Even numbers amount: " + count.ToString());
            //count = 0;
            //Console.Write("Odd numbers: ");
            //foreach (int i in a)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.Write(i.ToString() + " ");
            //        count++;
            //    }
            //}
            //Console.WriteLine("Odd numbers amount: " + count.ToString());
            //count = 0;
            //Console.Write("Uniq numbers: ");
            //int uniqCount = 0;
            //foreach (int i in a)
            //{
            //    foreach(int j in a)
            //    {
            //        if (i == j)
            //        {
            //            uniqCount++;
            //        }
            //    }
            //    if (uniqCount == 1)
            //    {
            //        Console.Write(i.ToString() + " ");
            //        count++;
            //    }
            //    uniqCount = 0;
            //}
            //Console.WriteLine("Uniq numbers amount: " + count.ToString());

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int[] arr = { 1, 6, 4, 5, 4, 34, 34, 3, 1, 6, 4, 23, 10, 1, 6, 4};
            for(int i = 0; i < arr.Length - 2; i++)
            {
                if (arr[i] == a && arr[i + 1] == b && arr[i + 2] == c)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
