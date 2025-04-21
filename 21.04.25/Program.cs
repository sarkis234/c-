using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._04._25
{
    public class Employee
    {
        private int age;
        private string name;
        private decimal salary;

        public Employee(int age, string name, decimal salary)
        {
            this.age = age;
            this.name = name;
            this.salary = salary;
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public decimal Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }
        public void print()
        {
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"age: {age}");
            Console.WriteLine($"salary: {salary}");
        }
        public static Employee operator +(Employee emp, decimal sal)
        {
            emp.salary += sal;
            return emp;
        }
        public static Employee operator -(Employee emp, decimal sal)
        {
            emp.salary -= sal;
            return emp;
        }
        public static bool operator ==(Employee emp, Employee emp2)
        {
            if (emp.salary == emp2.salary) return true;
            else return false;
        }
        public static bool operator !=(Employee emp, Employee emp2)
        {
            return !(emp == emp2);
        }
        public static bool operator >(Employee emp, Employee emp2)
        {
            if (emp.salary > emp2.salary) return true;
            else return false;
        }
        public static bool operator <(Employee emp, Employee emp2)
        {
            return !(emp > emp2);

        }
    }
    public class Matryx
    {
        private int[,] arr;
        private int row;
        private int column;
        public Matryx(int row, int column)
        {
            this.row = row;
            this.column = column;
            this.arr = new int[row, column];
        }
        public void print()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }
        public void fillArray()
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    arr[i, j] = j;
                }
            }
        }
        public static Matryx operator +(Matryx m1, Matryx m2)
        {
            Matryx m3 = new Matryx(m1.row, m1.column);
            for (int i = 0; i < m3.row; i++)
            {
                for (int j = 0; j < m3.column; j++)
                {
                    m3.arr[i, j] = m1.arr[i, j] + m2.arr[i, j];
                }
            }
            return m3;
        }
        public static Matryx operator -(Matryx m1, Matryx m2)
        {
            Matryx m3 = new Matryx(m1.row, m1.column);
            for (int i = 0; i < m3.row; i++)
            {
                for (int j = 0; j < m3.column; j++)
                {
                    m3.arr[i, j] = m1.arr[i, j] - m2.arr[i, j];
                }
            }
            return m3;
        }
        public static Matryx operator *(Matryx m1, Matryx m2)
        {
            Matryx m3 = new Matryx(m1.row, m1.column);
            for (int i = 0; i < m3.row; i++)
            {
                for (int j = 0; j < m3.column; j++)
                {
                    m3.arr[i, j] = m1.arr[i, j] * m2.arr[i, j];
                }
            }
            return m3;
        }
        public static bool operator ==(Matryx m1, Matryx m2)
        {
            for (int i = 0; i < m1.row; i++)
            {
                for (int j = 0; j < m1.column; j++)
                {
                    if (m1.arr[i, j] != m2.arr[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool operator !=(Matryx m1, Matryx m2)
        {
            return !(m1 == m2);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(25, "DIMA", 55000);
            emp.print();
            emp += 10000;
            emp.print();
            Employee emp2 = new Employee(20, "DIMA", 55000);
            Console.WriteLine(emp < emp2);

            Matryx mat = new Matryx(2, 3);
            Matryx mat2 = new Matryx(2, 3);
            mat.fillArray();
            mat2.fillArray();

            (mat * mat2).print();
            Console.WriteLine(mat != mat2);
        }
    }
}
