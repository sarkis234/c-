using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._05._25
{
    interface shape
    {
        void print();
    }
    class Rectangle : shape
    {
        int a;
        int b;
        public Rectangle(int a, int b)
        {
            this.a = b;
            this.b = a;
        }
        public void print()
        {
            for (int i = 0; i < this.a; i++)
            {
                for (int j = 0; j < this.b; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
    class Triangle : shape
    {
        int bottom;
        public Triangle(int a)
        {
            this.bottom = a;
        }
        public void print()
        {
            for (int i = this.bottom; i > 0; i--)
            {
                if (i % 2 == 1)
                {
                    Console.Write(" ");

                }
                for (int j = (this.bottom - (this.bottom - i)) / 2; j > 0; j--)
                {

                    Console.Write("  ");
                }
                for (int j = 0; j < this.bottom - i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
    class Diamond : shape
    {
        int middle;
        public Diamond(int a)
        {
            this.middle = a;
        }
        public void print()
        {
            for (int i = this.middle; i > 0; i--)
            {
                if (i % 2 == 1)
                {
                    Console.Write(" ");

                }
                for (int j = (this.middle - (this.middle - i)) / 2; j > 0; j--)
                {

                    Console.Write("  ");
                }
                for (int j = 0; j < this.middle - i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < this.middle; i++)
            {
                Console.Write("  ");
                if (i % 2 == 1)
                {
                    Console.Write(" ");

                }
                for (int j = 0; j < (this.middle - (this.middle - i)) / 2; j++)
                {

                    Console.Write("  ");
                }
                for (int j = this.middle - i - 1; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
    class Trapezoid : shape
    {
        int top;
        int bottom;
        public Trapezoid(int a, int b)
        {
            this.top = a;
            this.bottom = b;
        }
        public void print()
        {
            for (int i = this.bottom + 1; i > this.top; i--)
            {
                if (i % 2 == 1)
                {
                    Console.Write(" ");

                }
                for (int j = (this.bottom - (this.bottom - i)) / 2; j > 0; j--)
                {

                    Console.Write("  ");
                }
                for (int j = 0; j < top; j++)
                {
                    Console.Write("* ");
                }
                for (int j = 0; j < this.bottom - i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в тёмном чулане хранится В доме, Который построил Джек. А это весёлая птица-синица, Которая часто ворует пшеницу, Которая в тёмном чулане хранится В доме, Который построил Джек.";
            string newText = "";
            foreach(char i in text)
            {
                if (i != '.' && i != ',')
                {
                    newText += i;
                }
            }
            string[] words = newText.Split(new char[] { ' ' });
            var wordsCount = new Dictionary<string, int>();
            foreach (string i in words)
            {
                if (wordsCount.ContainsKey(i) == true)
                {
                    wordsCount[i]++;
                }
                else
                {
                    wordsCount.Add(i, 1);
                }
            }
            int keyCount = 0;
            int valCount = 0;
            Console.WriteLine($"\t\tСлова: \t\t\t   Кол-во: ");
            foreach (var i in wordsCount)
            {
                keyCount++;
                if(i.Key.Length >= 6)
                {
                    Console.WriteLine($"{keyCount}- \t\t  {i.Key}\t\t\t{i.Value}");

                }
                else if (i.Key.Length == 5)
                {
                    Console.WriteLine($"{keyCount}- \t\t  {i.Key}\t\t\t\t{i.Value}");

                }
                else
                {
                    Console.WriteLine($"{keyCount}- \t\t  {i.Key} \t\t\t\t{i.Value}");

                }
                valCount += i.Value;
            }
            Console.WriteLine($"Всего слов: {valCount} из них уникальны: {keyCount}");
        }
    }
    
}
