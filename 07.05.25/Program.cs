using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._05._25
{
    internal class Program
    {
        public interface IMovable
        {
            void move();
        }
        public class Car : IMovable
        {
            public void move()
            {
                Console.WriteLine("Автомобиль движется");
            }
        }
        public class Person : IMovable
        {
            public void move()
            {
                Console.WriteLine("Человек идет");
            }
        }
        public class Product
        {
            private string name;
            private string category;
            private int price;

            public Product(string name, string category, int price)
            {
                this.name = name;
                this.category = category;
                this.price = price;
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public string Category
            {
                get { return category; }
                set { category = value; }
            }
            public int Price
            {
                get { return price; }
                set { price = value; }
            }
            public void print()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Category: {category}");
                Console.WriteLine($"Price: {price}");
            }
            
        }
        static void filtr(Product[] products, Product filtrProduct)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Category == filtrProduct.Category && products[i].Price <= filtrProduct.Price)
                {
                    products[i].print();
                }

            }
        }
        static void sort(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                for (int j = 0; j < products.Length - 1; j++)
                {
                    if (products[j].Price > products[j + 1].Price)
                    {
                        Product buf = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = buf;
                    }
                }
            }
            foreach(Product i in products)
            {
                i.print();
            }
        }
        static Operation square = (x) => x * x;

        delegate int Operation(int x);
        static void Main(string[] args)
        {
            //string equation = Console.ReadLine();
            //List<char> marks = new List<char>();
            //List<string> nums = new List<string>();
            //List<int> numbers = new List<int>();
            //for (int i = 0; i < equation.Length; i++)
            //{
            //    if (i == 0)
            //    {
            //        string a = "";
            //        for (int j = 0; j < equation.Length; j++)
            //        {
            //            if (equation[j] == '+' || equation[j] == '-' || equation[j] == '*' || equation[j] == '/')
            //            {
            //                nums.Add(a);
            //                break;
            //            }
            //            else if (j == equation.Length - 1)
            //            {
            //                a += equation[j];
            //                nums.Add(a);
            //                break;
            //            }
            //            a += equation[j];

            //        }
            //    }
            //    else if (equation[i] == '+' || equation[i] == '-' || equation[i] == '*' || equation[i] == '/')
            //    {
            //        string a = "";
            //        marks.Add(equation[i]);
            //        for (int j = i + 1; j < equation.Length; j++)
            //        {
            //            if (equation[j] == '+' || equation[j] == '-' || equation[j] == '*' || equation[j] == '/')
            //            {
            //                nums.Add(a);
            //                break;
            //            }
            //            else if (j == equation.Length - 1)
            //            {
            //                a += equation[j];
            //                nums.Add(a);
            //                break;
            //            }
            //            a += equation[j];

            //        }
            //    }

            //}
            //foreach(string i in nums)
            //{
            //    numbers.Add(int.Parse(i));
            //}
            //while (numbers.Count!= 1)
            //{
            //    for (int i = 0; i < marks.Count; i++)
            //    {
            //        if (marks[i] == '*')
            //        {
            //            numbers[i + 1] = numbers[i] * numbers[i + 1];
            //            numbers.RemoveAt(i);
            //            marks.RemoveAt(i);

            //        }
            //        else if (marks[i] == '/')
            //        {
            //            numbers[i + 1] = numbers[i] / numbers[i + 1];
            //            numbers.RemoveAt(i);
            //            marks.RemoveAt(i);

            //        }
            //    }
            //    for (int i = 0; i < marks.Count; i++)
            //    {
            //        if (marks[i] == '+')
            //        {
            //            numbers[i + 1] = numbers[i] + numbers[i + 1];
            //            numbers.RemoveAt(i);
            //            marks.RemoveAt(i);


            //        }
            //        else if (marks[i] == '-')
            //        {
            //            numbers[i + 1] = numbers[i] - numbers[i + 1];
            //            numbers.RemoveAt(i);
            //            marks.RemoveAt(i);

            //        }
            //    }
            //} 
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //Product p1 = new Product("Dima", "Electronic", 3500);
            //Product p2 = new Product("Mathew", "Electronic", 2000);
            //Product p3 = new Product("BMW", "Car", 1000);
            //Product fp = new Product("Test", "Electronic", 2000);
            //Product[] prs = { p1, p2, p3 };

            //filtr(prs, fp);
            //Console.WriteLine();
            //sort(prs);

            //Car c1 = new Car();
            //Person p1 = new Person();
            //c1.move();
            //p1.move();
            int a = square(-4);
            Console.WriteLine(a);
        }
    }
}
