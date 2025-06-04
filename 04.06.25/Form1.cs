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

namespace _04._06._25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            bool flag = false;
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\04.06.25\\users.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] user = line.Split(';');
                    if (user[0] == login && user[1] == password)
                    {
                        flag = true;
                        Form3 newForm = new Form3(login);
                        newForm.Show();
                    }
                }
                if (flag == false)
                {
                    label2.Visible = true;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Войти как админ")
            {
                button1.Visible = false;
                button4.Visible = true;
                button3.Text = "Войти как пользователь";
            }
            else
            {
                button3.Text = "Войти как админ";
                button1.Visible = true;
                button4.Visible = false;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            bool flag = false;
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\04.06.25\\admins.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] user = line.Split(';');
                    if (user[0] == login && user[1] == password)
                    {
                        flag = true;
                        Form4 newForm = new Form4();
                        newForm.Show();
                    }
                }
                if (flag == false)
                {
                    label2.Visible = true;
                }

            }
        }
    }
}
