using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23._05._25_2
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public static void AddUser(string login, string password, string email)
        {
            User user = new User(login, password, email);
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\23.05.25_2\\23.05.25_2\\users.csv", append: true))
            {
                writer.WriteLine($"{user.Login},{user.Password},{user.Email}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label2.Visible = true;
            label1.Visible = true;
            textBox3.Visible = true;
            textBox2.Visible = true;
            textBox1.Visible = true;
            button2.Visible = true;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            while (true)
            {
                string login = "";
                if (Regex.IsMatch(textBox1.Text, @"([a-zA-Z0-9]){5,20}") == true)
                {
                    login = textBox1.Text;          
                }
                else
                {
                    textBox1.Text = "";
                    continue;
                }
                string password = "";
                if (Regex.IsMatch(textBox2.Text, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$") == true)
                {
                    password = textBox2.Text;
                }
                else
                {
                    textBox2.Text = "";
                    continue;
                }
                string email = "";
                if (Regex.IsMatch(textBox3.Text, @"[^@\s]+[^@\s]+\.[^@\s]") == true)
                {
                    email = textBox3.Text;
                }
                else
                {
                    textBox3.Text = "";
                    continue;
                }
                AddUser(login, password, email);
                break;
            }    
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            label4.Visible = true;
            textBox5.Visible = true;
            textBox4.Visible = true;
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string login = textBox5.Text;
            string password = textBox4.Text;

            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\source\\repos\\23.05.25_2\\23.05.25_2\\users.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    if (line[0] == login)
                    {
                        if (password == line[1])
                        {
                            label6.Visible = true;
                            label6.Text = "you loged in";
                            break;
                        }
                    }
                }
                if (label6.Visible == false)
                {
                    label6.Visible = true;
                    label6.Text = "you don't loged in";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            textBox6.Visible = true;
            button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string login = textBox6.Text;
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\source\\repos\\23.05.25_2\\23.05.25_2\\users.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(',');
                    if (line[0] == login)
                    {
                        label8.Visible = true;
                        label8.Text = "user is existing";
                    }
                }
                if (label8.Visible == false)
                {
                    label8.Visible = true;
                    label8.Text = "user is not existing";
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
    public class User
    {
        private string login;
        private string password;
        private string email;
        public User(string login, string password, string email)
        {
            this.login = login;
            this.password = password;
            this.email = email;
        }
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}
