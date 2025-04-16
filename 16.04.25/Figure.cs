using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fig
{
    public class Figure { 
        public void triangle(int a)
        {
            int c = 1;
            if (a % 2 == 1) c = 0;
            for (int i = c; i <= a; i+=2)
            {
                for (int j = 0; j <= (a - i) / 2; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        public void rectangle(int a, int b)
        {
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        public void square(int a)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
    internal class task2
    {
    }
}
