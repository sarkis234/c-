using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    public class Num
    {
        private int min;
        private int max;
        public Num(int min, int max)
        {
            if (min > max)
            {
                this.min = max;
                this.max = min;
            }
            else
            {
                this.min = min;
                this.max = max;
            }
        }
        public void printEven()
        {
            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.Write("\n");
        }
        public void printOdd()
        {
            for (int i = min; i <= max; i++)
            {
                if (i % 2 == 1)
                {
                    Console.Write($"{i} ");
                }
            }
            Console.Write("\n");
        }
        public void printSimple()
        {
            for (int i = min; i <= max; i++)
            {
                bool flag = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = false;
                    } 
                }
                if (i == 1)
                {
                    flag = false;
                }
                if (flag == true)
                {
                    Console.Write($"{i} ");

                }
            }
            Console.Write("\n");
        }
        public void printFibo()
        {
            int a = 0;
            int b = 1;
            Console.Write("0 1 ");
            while (true)
            {
                int a2 = b;
                b = b + a;
                a = a2;
                if (b > max)
                {
                    break;
                }
                Console.Write($"{b} ");

            }
            Console.Write("\n");
        }

    }
    internal class number
    {

    }
}
