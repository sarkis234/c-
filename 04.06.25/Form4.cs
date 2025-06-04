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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
            textBox15.Visible = true;
            textBox16.Visible = true;
            textBox17.Visible = true;
            textBox18.Visible = true;
            textBox19.Visible = true;
            textBox20.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox21.Text;
            string[] questions = { textBox1.Text, textBox8.Text, textBox12.Text, textBox17.Text, textBox16.Text };
            string[] answers = { textBox2.Text, textBox4.Text, textBox7.Text, textBox6.Text, textBox10.Text, textBox11.Text, textBox18.Text, textBox19.Text, textBox15.Text, textBox14.Text };
            int[] corAnswers = { Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox20.Text), Convert.ToInt32(textBox13.Text) };

            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\04.06.25\\qwiz.csv", true))
            {
                writer.WriteLine($"{name};{questions[0]};{answers[0]};{answers[1]};{corAnswers[0]};{questions[1]};{answers[2]};{answers[3]};{corAnswers[1]};{questions[2]};{answers[4]};{answers[5]};{corAnswers[2]};{questions[3]};{answers[6]};{answers[7]};{corAnswers[3]};{questions[4]};{answers[8]};{answers[9]};{corAnswers[4]}");
            }

        }
    }
}
