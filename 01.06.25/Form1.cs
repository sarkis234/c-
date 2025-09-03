using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01._06._25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = LoginBox.Text;
            string password = textBox2.Text;
            bool flag = false;
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\source\\repos\\01.06.25\\01.06.25\\users.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string login1 = line.Split(':')[0];
                    if (login1 == login)
                    {
                        flag = true;
                    }
                }
            }
            if (login == string.Empty || password == string.Empty)
            {
                label5.Visible = true;
            }
            else if (flag == true)
            {
                label5.Visible = true;
            }
            else
            {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\01.06.25\\01.06.25\\users.csv", true))
                {
                    writer.WriteLine($"{login}:{password}");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = textBox3.Text;
            string password = textBox1.Text;
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\source\\repos\\01.06.25\\01.06.25\\users.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string login1 = line.Split(':')[0];
                    string pass1 = line.Split(':')[1];
                    if (login1 == login && pass1 == password)
                    {
                        label6.Visible = true;
                        Form2 newForm = new Form2(login, password, this);
                        newForm.Show();
                        this.Hide();

                    }
                }
            }
        }
    }
}
