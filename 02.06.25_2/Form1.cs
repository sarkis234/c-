using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02._06._25_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"\w") && comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                if (comboBox1.SelectedItem == comboBox2.SelectedItem)
                {
                    textBox2.Text = textBox1.Text;
                }
                else
                {
                    using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\{comboBox1.SelectedItem.ToString()}-{comboBox2.SelectedItem.ToString()}.csv"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] words = line.Split('-');
                            if (words[0].ToLower() == textBox1.Text.ToLower())
                            {
                                textBox2.Text = words[1];
                            }
                        }
                    }
                }    
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button3.Visible = true;
            label2.Text = "Введите его перевод: ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, @"\w") && comboBox1.SelectedItem != null && comboBox2.SelectedItem != null  && comboBox1.SelectedItem != comboBox2.SelectedItem)
            {
                using (StreamWriter writer = new StreamWriter($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\{comboBox1.SelectedItem.ToString()}-{comboBox2.SelectedItem.ToString()}.csv", true))
                {
                    writer.WriteLine($"\n{textBox1.Text}-{textBox2.Text}");
                }
                using (StreamWriter writer = new StreamWriter($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\{comboBox2.SelectedItem.ToString()}-{comboBox1.SelectedItem.ToString()}.csv", true))
                {
                    writer.WriteLine($"\n{textBox2.Text}-{textBox1.Text}");
                }
                button1.Visible = true;
                button3.Visible = false;
                label2.Text = "Перевод";
                textBox1.Text = "";
                textBox2.Text = "";
            }
               
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox3.Visible = true;
            textBox3.Visible = true;
            label3.Visible = true;
            button5.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string a = "";

            switch (comboBox3.SelectedItem.ToString())
            {
                case "Русский":
                    using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Русский-English.csv"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] words = line.Split('-');
                            if (words[0] == textBox3.Text)
                            {
                                flag = true;
                                a = "rusen";
                            }
                        }
                    }
                    using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Русский-Español.csv"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] words = line.Split('-');
                            if (words[0] == textBox3.Text)
                            {
                                flag = true;
                                a = "rusesp";
                            }
                        }
                    }
                    break;
                case "English":
                    using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\English-Русский.csv"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] words = line.Split('-');
                            if (words[0] == textBox3.Text)
                            {
                                flag = true;
                                a = "enrus";
                            }
                        }
                    }
                    using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\English-Español.csv"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] words = line.Split('-');
                            if (words[0] == textBox3.Text)
                            {
                                flag = true;
                                a = "enesp";
                            }
                        }
                    }
                    break;
                case "Español":
                    using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Español-English.csv"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] words = line.Split('-');
                            if (words[0] == textBox3.Text)
                            {
                                flag = true;
                                a = "espen";
                            }
                        }
                    }
                    using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Español-Русский.csv"))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] words = line.Split('-');
                            if (words[0] == textBox3.Text)
                            {
                                flag = true;
                                a = "esprus";
                            }
                        }
                    }
                    break;
            }
            if (flag == true)
            {
                List<string> diction = new List<string>();
                List<string> diction2 = new List<string>();

                switch (a)
                {
                    case "rusen":
                        using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Русский-English.csv"))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] words = line.Split('-');
                                if (words[0] != textBox3.Text)
                                {
                                    diction.Add(line);
                                }
                            }
                        }
                        using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\English-Русский.csv"))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] words = line.Split('-');
                                if (words[1] != textBox3.Text)
                                {
                                    diction2.Add(line);
                                }
                            }
                        }
                        using (StreamWriter writer = new StreamWriter($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Русский-English.csv", false))
                        {
                            foreach(var i in diction)
                            {
                                writer.WriteLine(i);
                            }
                        }
                        using (StreamWriter writer = new StreamWriter($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\English-Русский.csv", false))
                        {
                            foreach (var i in diction2)
                            {
                                writer.WriteLine(i);
                            }
                        }
                        break;
                    case "enrus":
                        using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\English-Русский.csv"))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] words = line.Split('-');
                                if (words[0] != textBox3.Text)
                                {
                                    diction.Add(line);
                                }
                            }
                        }
                        using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Русский-English.csv"))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] words = line.Split('-');
                                if (words[1] != textBox3.Text)
                                {
                                    diction2.Add(line);
                                }
                            }
                        }
                        using (StreamWriter writer = new StreamWriter($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\English-Русский.csv", false))
                        {
                            foreach (var i in diction)
                            {
                                writer.WriteLine(i);
                            }
                        }
                        using (StreamWriter writer = new StreamWriter($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Русский-English.csv", false))
                        {
                            foreach (var i in diction2)
                            {
                                writer.WriteLine(i);
                            }
                        }
                        break;
                    case "enesp":
                        using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\English-Español.csv"))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] words = line.Split('-');
                                if (words[0] != textBox3.Text)
                                {
                                    diction.Add(line);
                                }
                            }
                        }
                        using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Español-English.csv"))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] words = line.Split('-');
                                if (words[1] != textBox3.Text)
                                {
                                    diction2.Add(line);
                                }
                            }
                        }
                        using (StreamWriter writer = new StreamWriter($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\English-Español.csv", false))
                        {
                            foreach (var i in diction)
                            {
                                writer.WriteLine(i);
                            }
                        }
                        using (StreamWriter writer = new StreamWriter($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Español-English.csv", false))
                        {
                            foreach (var i in diction2)
                            {
                                writer.WriteLine(i);
                            }
                        }
                        break;
                    case "rusesp":
                        using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Русский-Español.csv"))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] words = line.Split('-');
                                if (words[0] != textBox3.Text)
                                {
                                    diction.Add(line);
                                }
                            }
                        }
                        using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Español-Русский.csv"))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] words = line.Split('-');
                                if (words[1] != textBox3.Text)
                                {
                                    diction2.Add(line);
                                }
                            }
                        }
                        using (StreamWriter writer = new StreamWriter($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Русский-Español.csv", false))
                        {
                            foreach (var i in diction)
                            {
                                writer.WriteLine(i);
                            }
                        }
                        using (StreamWriter writer = new StreamWriter($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Español-Русский.csv", false))
                        {
                            foreach (var i in diction2)
                            {
                                writer.WriteLine(i);
                            }
                        }
                        break;
                    case "esprus":
                        using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Español-Русский.csv"))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] words = line.Split('-');
                                if (words[0] != textBox3.Text)
                                {
                                    diction.Add(line);
                                }
                            }
                        }
                        using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Русский-Español.csv"))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] words = line.Split('-');
                                if (words[1] != textBox3.Text)
                                {
                                    diction2.Add(line);
                                }
                            }
                        }
                        using (StreamWriter writer = new StreamWriter($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Español-Русский.csv", false))
                        {
                            foreach (var i in diction)
                            {
                                writer.WriteLine(i);
                            }
                        }
                        using (StreamWriter writer = new StreamWriter($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Русский-Español.csv", false))
                        {
                            foreach (var i in diction2)
                            {
                                writer.WriteLine(i);
                            }
                        }
                        break;
                    case "espen":
                        using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Español-English.csv"))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] words = line.Split('-');
                                if (words[0] != textBox3.Text)
                                {
                                    diction.Add(line);
                                }
                            }
                        }
                        using (StreamReader reader = new StreamReader($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\English-Español.csv"))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                string[] words = line.Split('-');
                                if (words[1] != textBox3.Text)
                                {
                                    diction2.Add(line);
                                }
                            }
                        }
                        using (StreamWriter writer = new StreamWriter($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\Español-English.csv", false))
                        {
                            foreach (var i in diction)
                            {
                                writer.WriteLine(i);
                            }
                        }
                        using (StreamWriter writer = new StreamWriter($"C:\\Users\\Взрослая академия\\Desktop\\Хамчиев Али\\02.06.25_2\\English-Español.csv", false))
                        {
                            foreach (var i in diction2)
                            {
                                writer.WriteLine(i);
                            }
                        }
                        break;
                }
            }
            }
        }
    }
