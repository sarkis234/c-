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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string login)
        {
            InitializeComponent();
            label1.Text = login;
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\04.06.25\\qwiz.csv"))
            {
                string line;
                int count = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] qwiz = line.Split(';');
                    comboBox1.Items.Add(qwiz[0]);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void a_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            comboBox2.Visible = true;
            comboBox3.Visible = true;
            comboBox4.Visible = true;
            comboBox5.Visible = true;
            comboBox6.Visible = true;
            button2.Visible = true;
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\04.06.25\\qwiz.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] qwiz = line.Split(';');
                    label3.Text = qwiz[1];
                    label4.Text = qwiz[1];
                    label5.Text = qwiz[1];
                    label6.Text = qwiz[1];
                    label7.Text = qwiz[1];

                }
            }
        }
    }
}
