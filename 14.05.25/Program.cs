using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace _14._05._25
{
    internal class Program
    {
        static void create(string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("Файл уже создан");
            }
            else
            {
                File.Create(path);
            }
        }
        static string read(string path)
        {
            string a = File.ReadAllText(path);
            return a;
        }

        static void write(string path, string surname, string name, string FatherName, string date, int[,] arrNums, double[,] arrDoubleNums)
        {
            File.AppendAllText(path, $"{surname} {name} {FatherName} {date} \n");
            File.AppendAllText(path, $"{ arrDoubleNums.GetLength(0) } { arrDoubleNums.GetLength(1) }\n");
            foreach(double a in arrDoubleNums)
            {
                File.AppendAllText(path, $"{a}, ");
            }
            File.AppendAllText(path, $"\n { arrNums.GetLength(0) } { arrNums.GetLength(1) } \n");
            foreach (int a in arrNums)
            {
                File.AppendAllText(path, $"{a}, ");
            }
            File.AppendAllText(path, $"\n{DateTime.Now.ToString("dd.mm.yy")}");
        }

        static void Main(string[] args)
        {
            string path = "C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\14.05.25\\text.txt";
            ////File.Create(path)
            //create(path);
            //double[,] arr = { { 21.2, 12 }, { 1212, 12 }, { 121, 121 } };
            //int[,] arr2 = { { 100, 12 }, { 16, 12 }, { 121, 127 } };
            //write(path, "name", "surname", "fatherName", "12.12.1988", arr2, arr);
            //Console.WriteLine(read(path));

            string a = File.ReadAllText(path);
            string b = "";
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] != ' ' || a[i + 1] != ' ')
                {
                    b += a[i];
                }
            }
            Console.WriteLine(b);

        }
    }
}
