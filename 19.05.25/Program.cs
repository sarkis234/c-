using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _19._05._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string a = "<asas>kasdko-akdpoasd</p>";
            //string c = Regex.Replace(a, @"<[^>]*>", "");
            //Console.WriteLine(c);
            //foreach(Match i in b)
            //{
            //    Console.WriteLine(i);
            //}

            //string p = "U1#assassdsd";
            //MatchCollection b = Regex.Matches(p, @"\W");
            //MatchCollection c = Regex.Matches(p, @"\d");
            //MatchCollection d = Regex.Matches(p, @"[A-Z]");

            //bool flag = true;
            //if (p.Length < 8 || b.Count == 0 || c.Count == 0 || d.Count == 0)
            //{
            //    flag = false;
            //}
            //Console.WriteLine(flag);

            //string a = "Hello  World  !";
            //string b = Regex.Replace(a, "  ", " ");
            //Console.WriteLine(b);

            //string a = "+7 (989) 788-99-11";
            //MatchCollection b = Regex.Matches(a, @"\+7 \(\d{3}\) \d{3}-\d{2}-\d{2}");
            //if (b.Count== 1 && a.Length == 18)
            //{
            //    Console.WriteLine("right");
            //}
            //else
            //{
            //    Console.WriteLine("not right");

            //}

            //string a = "podkkd@gmail.com@";
            //string[] b = a.Split('@');
            //if (b.Length != 2) Console.WriteLine("not valid");
            //else if (b[1] == "gmail.com" || b[1] == "yandex.ru" || b[1] == "mail.ru")
            //{
            //    Console.WriteLine("valid");
            //}
            //else Console.WriteLine("not valid");

            string a = Console.ReadLine();
            string[] b = a.Split('@');
            if (b.Length != 2) Console.WriteLine("not valid");
            else if (b[1] == "gmail.com" || b[1] == "yandex.ru" || b[1] == "mail.ru")
            {
                Console.WriteLine("valid");
            }
            else Console.WriteLine("not valid");
            a = Console.ReadLine();
            MatchCollection b2 = Regex.Matches(a, @"\+7 \(\d{3}\) \d{3}-\d{2}-\d{2}");
            if (b2.Count == 1 && a.Length == 18)
            {
                Console.WriteLine("valid");
            }
            else
            {
                Console.WriteLine("not valid");

            }

            a = Console.ReadLine();
            MatchCollection b3 = Regex.Matches(a, @"\W");
            MatchCollection c = Regex.Matches(a, @"\d");
            MatchCollection d = Regex.Matches(a, @"[A-Z]");

            if (a.Length < 8 || b3.Count == 0 || c.Count == 0 || d.Count == 0)
            {
                Console.WriteLine("not valid");
            }
            else
            {
                Console.WriteLine("valid");
            }

            a = Console.ReadLine();
            MatchCollection b4 = Regex.Matches(a, @"\d{2}-\d{2}-\d{4}");
            if (b4.Count == 1 && a.Length == 10)
            {
                Console.WriteLine("valid");
            }
            else Console.WriteLine("not valid");
        }
    }
}
