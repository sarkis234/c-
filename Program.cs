using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._04._25
{
    internal class Program
    {
        public class Dima
        {
            private string name;
            private string country;
            private int population;
            private int phoneCode;
            private string districts;
            public void name1(string a)
            {
                this.name = a;
            }
            public void country1(string a)
            {
                this.country = a;
            }
            public void population1(int a)
            {
                this.population = a;
            }
            public void phoneCode1(int a)
            {
                this.phoneCode = a;
            }
            public void districts1(string a)
            {
                this.districts = a;
            }
            public void writer()
            {
                Console.WriteLine($"Город {name}");
                Console.WriteLine($"Страна {country}");
                Console.WriteLine($"Население {population}");
                Console.WriteLine($"Телефонный код {phoneCode}");
                Console.WriteLine($"Район {districts}");
            }

        }
        static int[] func3(int[] arr)
        {
            int[] arr2 = arr;
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr2.Length - 1; j++)
                {
                    if (arr2[j] > arr2[j + 1])
                    {
                        int b = arr2[j];
                        arr2[j] = arr2[j + 1];
                        arr2[j + 1] = b;
                    }
                }
            }
            return arr2;
        }
        static int func1(int a, int b)
        {
            int mult = 1;
            for(int i = a; i <= b; i++)
            {
                mult *= i;
            }
            return mult;
        }

        static bool func2(int a)
        {
            int b = 0;
            int c = 1;
            if (a == b || a == c) return true;
            while (true)
            {
                int a2 = b;
                b = b + c;
                c = a2;
                if (a == b)
                {
                    return true;
                }
                if (b > a)
                {
                    return false;
                }
            }
        }
        static bool func2n2(int a)
        {
            for (int i = 2; i < a; i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine(func1(1, 5));
            //Console.WriteLine(func2(10));
            //Console.WriteLine(func2n2(5));

            //int[] arr = { 1, 234, 342, 11, 32 };
            //arr = func3(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //int[,] a = { { 1, 8, 11 }, { 24, 0, 6 } };
            //int row = a.GetLength(0);
            //int column = a.GetLength(1);
            //int min = a[0, 0];
            //int max = a[0, 0];
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        if (a[i, j] < min) min = a[i, j];
            //        if (a[i, j] > max) max = a[i, j];
            //    }
            //}
            //Console.WriteLine(max);
            //Console.WriteLine(min);

            //string b = Console.ReadLine();
            //int count = 1;
            //for (int i = 0; i < b.Length; i++)
            //{
            //    if (b[i] == ' ') count++;
            //}
            //Console.WriteLine(count);

            //string c = Console.ReadLine();
            //int count = 0;
            //c = c.ToLower();
            //for (int i = 0; i < c.Length; i++)
            //{
            //    if (c[i] == 'a' || c[i] == 'e' || c[i] == 'i' || c[i] == 'o' || c[i] == 'u' || c[i] == 'y')
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);

            //string c = (Console.ReadLine()).ToLower();
            //string d = Console.ReadLine().ToLower();
            //int count = 0;
            //for (int i= 0; i < c.Length; i++)
            //{
            //    bool flag = false;
            //    if (c[i] == d[0])
            //    {
            //        for (int j = 0; j < d.Length; j++)
            //        {
            //            if (i + j > c.Length)
            //            {
            //                flag = false;
            //                break;
            //            }
            //            if (c[i + j] != d[j])
            //            {
            //                flag = false;
            //                break;
            //            }
            //            else flag = true;
            //        }
            //    }
            //    if (flag) count++;
            //}
            //Console.WriteLine(count);

            Dima a = new Dima();
            a.name1("Москва");
            a.country1("Россия");
            a.population1(121312);
            a.phoneCode1(1010);
            a.districts1("Centr");
            a.writer();
        }


    }

}
