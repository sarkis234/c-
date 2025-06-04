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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            string date = textBox3.Text;
            bool flag = false;
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\04.06.25\\users.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] user = line.Split(';');
                    if (user[0] == login)
                    {
                        flag = true;
                    }
                }
            }
            if (flag == true)
            {
                label2.Visible = true;
            }
            else
            {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\04.06.25\\users.csv", true))
                {
                    writer.WriteLine($"{login};{password};{date}");
                }
                Form1 newForm = new Form1();
                newForm.Show();
            }
        }
    }
}
