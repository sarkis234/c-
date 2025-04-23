using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._04._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string a = Console.ReadLine();
            //try
            //{
            //    int a2 = Convert.ToInt32(a);
            //    Console.WriteLine(a2);
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Вы вышли за границу");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Вы ввели не число");

            //}

            //string str = Console.ReadLine();
            //double n = 0;
            //try
            //{
            //    int a2 = Convert.ToInt32(str);
            //    for (int i = 0; i < str.Length; i++)
            //    {
            //        if (str[i] != '0' || str[i] != '1')
            //        {
            //            throw new Exception("Число записано не в двоичной системе исчисления");
            //        }
            //        n += Convert.ToInt32(str[str.Length - 1 - i] - 48) * Math.Pow(2, i);
                    
            //    }
            //    Console.WriteLine(n);

            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Вы вышли за границу");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Вы ввели не число");

            //}

            string str = Console.ReadLine();
            int a;
            try
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if ((Convert.ToInt32(str[i]) < 47 || Convert.ToInt32(str[i]) > 58) && str[i] != '*')
                    {
                        throw new Exception("Строка должна содержать только числа и *");
                    }
                }
                int res = 1;
                string[] nums = str.Split('*');
                for (int i = 0; i < nums.Length; i++)
                {
                    res *= int.Parse(nums[i]);
                }
                Console.WriteLine(res);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
