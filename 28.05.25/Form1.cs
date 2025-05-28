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

namespace _28._05._25
{
    public partial class Form1 : Form
    {
        int a, b, c, d = 0;

        public Form1()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\28.05.25\\data.csv"))
            {
                string[] arr  = reader.ReadLine().Split(' ');
                a = Convert.ToInt32(arr[0]);
                b = Convert.ToInt32(arr[1]);
                c = Convert.ToInt32(arr[2]);
                d = Convert.ToInt32(arr[3]);
                label7.Text = Convert.ToString(a);
                label8.Text = Convert.ToString(b);
                label9.Text = Convert.ToString(c);
                label10.Text = Convert.ToString(d);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (button2.Text)
            {
                case "Показать расходы":
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    label7.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    button2.Text = "Скрыть расходы";
                    break;
                case "Скрыть расходы":
                    label2.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    button2.Text = "Показать расходы";
                    break;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label6.Visible = true;
            textBox1.Visible = true;
            comboBox1.Visible = true;
            button1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
            label12.Visible = true;
            textBox2.Visible = true;
            comboBox2.Visible = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(textBox2.Text);
            string categ = comboBox2.SelectedItem.ToString();
            switch (categ)
            {
                case "Продукты":
                    a -= sum;
                    label7.Text = Convert.ToString(a);
                    break;
                case "транспорт":
                    b -= sum;
                    label8.Text = Convert.ToString(b);
                    break;
                case "развлечения":
                    c -= sum;
                    label9.Text = Convert.ToString(c);
                    break;
                case "прочее":
                    d -= sum;
                    label10.Text = Convert.ToString(d);
                    break;
            }
            label11.Visible = false;
            label12.Visible = false;
            textBox2.Visible = false;
            comboBox2.Visible = false;
            button5.Visible = false;
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\28.05.25\\data.csv", false))
            {
                writer.WriteLine($"{a} {b} {c} {d}");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label13.Visible = true;
            comboBox3.Visible = true;
            button7.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string categ = comboBox3.SelectedItem.ToString();
            switch (categ)
            {
                case "Продукты":
                    a = 0;
                    label7.Text = Convert.ToString(a);
                    break;
                case "транспорт":
                    b = 0;
                    label8.Text = Convert.ToString(b);
                    break;
                case "развлечения":
                    c = 0;
                    label9.Text = Convert.ToString(c);
                    break;
                case "прочее":
                    d = 0;
                    label10.Text = Convert.ToString(d);
                    break;
            }
            label13.Visible = false;
            comboBox3.Visible = false;
            button7.Visible = false;
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\28.05.25\\data.csv", false))
            {
                writer.WriteLine($"{a} {b} {c} {d}");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(textBox1.Text);
            string categ = comboBox1.SelectedItem.ToString();
            switch (categ)
            {
                case "Продукты":
                    a += sum;
                    label7.Text = Convert.ToString(a);
                    break;
                case "транспорт":
                    b += sum;
                    label8.Text = Convert.ToString(b);
                    break;
                case "развлечения":
                    c += sum;
                    label9.Text = Convert.ToString(c);
                    break;
                case "прочее":
                    d += sum;
                    label10.Text = Convert.ToString(d);
                    break;
            }
            label1.Visible = false;
            label6.Visible = false;
            textBox1.Visible = false;
            comboBox1.Visible = false;
            button1.Visible = false;
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\28.05.25\\data.csv", false))
            {
                writer.WriteLine($"{a} {b} {c} {d}");
            }

        }
    }
}
