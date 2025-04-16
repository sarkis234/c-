using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16._04._25
{
    public class Worker
    {
        private string name;
        private string surname;
        private string fatherName;
        private string date;
        private string phone;
        private string mail;
        private string post;
        private string tasks;
        public void setFIO(string name, string surname, string fatherName)
        {
            this.name = name;
            this.surname = surname;
            this.fatherName = fatherName;
        }
        public void setDate(string date)
        {
            this.date = date;
        }
        public void setPhone(string phone)
        {
            this.phone = phone;
        }
        public void setMail(string mail)
        {
            this.mail = mail;
        }
        public void setPost(string post)
        {
            this.post = post;
        }
        public void setTasks(string tasks)
        {
            this.tasks = tasks;
        }
        public void addTask(string task)
        {
            this.tasks += task;
            this.tasks += ", ";

        }
        public void print()
        {
            Console.WriteLine($"FIO: {surname} {name} {fatherName}");
            Console.WriteLine($"Date: {date}");
            Console.WriteLine($"Phone number: {phone}");
            Console.WriteLine($"Mail adress: {mail}");
            Console.WriteLine($"Post: {post}");
            Console.WriteLine($"Tasks: {tasks}");
        }
    }
    public class Plane
    {
        private string name;
        private string creatorName;
        private int releaseYear;
        private string type;
        public Plane(string name, string creatorName, int releaseYear, string type)
        {
            this.name = name;
            this.creatorName = creatorName;
            this.releaseYear = releaseYear;
            this.type = type;
        }
        public void setName()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            this.name = name;
        }
        public void setCreatorName()
        {
            Console.Write("Enter creatorName: ");
            string creatorName = Console.ReadLine();
            this.creatorName = creatorName;
        }
        public void setReleaseYear()
        {
            Console.Write("Enter release year: ");
            int releaseYear = Convert.ToInt32(Console.ReadLine());
            this.releaseYear = releaseYear;
        }
        public void setType()
        {
            Console.Write("Enter plane type: ");
            string type = Console.ReadLine();
            this.type = type;
        }
        public void print()
        {
            Console.WriteLine($"Plane name: {name}");
            Console.WriteLine($"Creator name: {creatorName}");
            Console.WriteLine($"Release year: {releaseYear}");
            Console.WriteLine($"Plane type: {type}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker();
            worker1.setFIO("Dima", "Kovale", "Dmitrievich");
            worker1.setDate("11.01.2010");
            worker1.setMail("pesok@gmail.com");
            worker1.setPhone("79032029323");
            worker1.setPost("gtufuf");
            worker1.addTask("walk");
            worker1.addTask("buy clothes");
            worker1.print();
            Numbers.Num n1 = new Numbers.Num(1, 10);
            n1.printEven();
            n1.printOdd();
            n1.printSimple();
            n1.printFibo();
            Fig.Figure f1 = new Fig.Figure();
            f1.triangle(6);
            f1.rectangle(3, 5);
            f1.square(4);
        }
       
        
    }
}


