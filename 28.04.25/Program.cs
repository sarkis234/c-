using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28._04._25
{
    internal class Program
    {
        public class Human 
        {
            private string name;
            private int age;
            private string surname;

            public Human(string name, int age, string surname)
            {
                this.age = age;
                this.name = name;
                this.surname = surname;
            }
            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }
            public string Surname
            {
                get { return this.surname; }
                set { this.surname = value; }
            }
            public int Age
            {
                get { return this.age; }
                set { this.age = value; }
            }
            public void print()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Surname: {surname}");
                Console.WriteLine($"Age: {age}");
            }
        }

        public class Builder : Human
        {
            private int salary;
            private string adress;
            public Builder(string name, int age, string surname, int salary, string adress) : base(name, age, surname)
            {
                this.salary = salary;
                this.adress = adress;
            }
            public int Salary
            {
                get { return this.salary; }
                set { this.salary = value; }
            }
            public string Adress
            {
                get { return this.adress; }
                set { this.adress = value; }
            }
            public void printBuilder()
            {
                this.print();
                Console.WriteLine($"Salary: {salary}");
                Console.WriteLine($"House adress: {adress}");
            }
        }

        public class Passport
        {
            private string name;
            private string surname;
            private int age;
            private string country;
            private int seria;
            private int number;

            public Passport(string name, int age, string surname, string country, int seria, int number)
            {
                this.age = age;
                this.name = name;
                this.surname = surname;
                this.country = country;
                this.seria = seria;
            }
            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }
            public string Surname
            {
                get { return this.surname; }
                set { this.surname = value; }
            }
            public int Age
            {
                get { return this.age; }
                set { this.age = value; }
            }
            public string Country
            {
                get { return this.country; }
                set { this.country = value; }
            }
            public int Seria
            {
                get { return this.seria; }
                set { this.seria = value; }
            }
            public int Number
            {
                get { return this.number; }
                set { this.number = value; }
            }
            public void print()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Surname: {surname}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Country: {country}");
                Console.WriteLine($"Seria: {seria}");
                Console.WriteLine($"Number: {number}");
            }
        }
        public class ForeignPassport : Passport
        {
            private string visa;
            private int forNumber;
            public ForeignPassport(string name, int age, string surname, string country, int seria, int number, string visa, int forNumber) : base(name, age, surname, country, seria, number)
            {
                this.forNumber = forNumber;
                this.visa = visa;
            }
            public string Visa
            {
                get { return this.visa; }
                set { this.visa = value; }
            }
            public int ForNumber
            {
                get { return this.forNumber; }
                set { this.forNumber = value; }
            }
            public void printFor()
            {
                this.print();
                Console.WriteLine($"Visa: {visa}");
                Console.WriteLine($"Foreign passport number: {forNumber}");
            }
        }

        public class Animal
        {
            private string name;
            private string type;
            private int height;
            private int age;
            
            public Animal(string name, string type, int height, int age)
            {
                this.name = name;
                this.type = type;
                this.height = height;
                this.age = age;
            }
            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }
            public string Type
            {
                get { return this.type; }
                set { this.type = value; }
            }
            public int Age
            {
                get { return this.age; }
                set { this.age = value; }
            }
            public int Height
            {
                get { return this.height; }
                set { this.height = value; }
            }
            public void print()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Type: {type}");
                Console.WriteLine($"Age: {age}");
                Console.WriteLine($"Height: {height}");
            }
        }
        public class Tiger : Animal
        {
            private string color;
            public Tiger(string name, string type, int height, int age, string color) : base(name, type, height, age)
            {
                this.color = color;
            }
            public string Color
            {
                get { return this.color; }
                set { this.color = value; }
            }
            public void printTiger()
            {
                this.print();
                Console.WriteLine($"Color: {color}");
            }
        }
        public class Crocodile : Animal
        {
            private int toothAmount;
            public Crocodile(string name, string type, int height, int age, int toothAmount) : base(name, type, height, age)
            {
                this.toothAmount = toothAmount;
            }
            public int ToothAmount
            {
                get { return this.toothAmount; }
                set { this.toothAmount = value; }
            }
            public void printCrocodile()
            {
                this.print();
                Console.WriteLine($"Tooth amount: {toothAmount}");
            }
        }
        public class Cangaroo : Animal
        {
            private int taleLength;
            public Cangaroo(string name, string type, int height, int age, int taleLength) : base(name, type, height, age)
            {
                this.taleLength = taleLength;
            }
            public int TaleLength
            {
                get { return this.taleLength; }
                set { this.taleLength = value; }
            }
            public void printCangaroo()
            {
                this.print();
                Console.WriteLine($"Tale length: {taleLength}");
            }
        }
        abstract class Phigure 
        {
            public abstract void countArea();
        }

        class Rectangle : Phigure
        {
            private int a, b;
            public Rectangle(int a, int b)
            {
                this.a = a;
                this.b = b;
            }
            public override void countArea()
            {
                Console.WriteLine($"Area: {a * b}");
            }
        }
        static void Main(string[] args)
        {
            Builder b1 = new Builder("Dima", 18, "Kovale", 45, "dfgfusdgf");
            b1.printBuilder();
        }
    }
}
