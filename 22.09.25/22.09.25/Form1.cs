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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _22._09._25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bool flag = false;
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\source\\repos\\22.09.25\\22.09.25\\materials.txt"))
            {
                if (reader.ReadLine() != "")
                {
                    Console.WriteLine("Postol");
                    flag = true;
                }
            }
            if (flag == true)
            {
                using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\source\\repos\\22.09.25\\22.09.25\\materials.txt"))
                {
                    string[] line = reader.ReadLine().Split(';');
                    Form2 form2 = new Form2(line[0], line[1], line[2], line[3], line[4], line[5], line[6], line[7]);
                    form2.Show();
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string budget, cotton, wood, leather, ceramics, plastic, glass, metal;
            if (textBoxBudget.Text == "")
            {
                budget = "0";
            }
            else
            {
                budget = textBoxBudget.Text;
            }
            if (textBoxCotton.Text == "")
            {
                cotton = "0";
            }
            else
            {
                cotton = textBoxCotton.Text;
            }
            if (textBoxWood.Text == "")
            {
                wood = "0";
            }
            else
            {
                wood = textBoxWood.Text;
            }
            if (textBoxLeather.Text == "")
            {
                leather = "0";
            }
            else
            {
                leather = textBoxLeather.Text;
            }
            if (textBoxCeramic.Text == "")
            {
                ceramics = "0";
            }
            else
            {
                ceramics = textBoxCeramic.Text;
            }
            if (textBoxGlass.Text == "")
            {
                glass = "0";
            }
            else
            {
                glass = textBoxGlass.Text;
            }
            if (textBoxPlastic.Text == "")
            {
                plastic = "0";
            }
            else
            {
                plastic = textBoxPlastic.Text;
            }
            if (textBoxMetal.Text == "")
            {
                metal = "0";
            }
            else
            {
                metal = textBoxMetal.Text;
            }
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\22.09.25\\22.09.25\\materials.txt", false))
            {
                writer.WriteLine($"{budget};{cotton};{wood};{leather};{ceramics};{plastic};{glass};{metal}");
            }
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\22.09.25\\22.09.25\\orders.txt", false))
            {
            }
            Form2 newForm = new Form2(budget, cotton, wood, leather, ceramics, plastic, glass, metal);
            newForm.Show();

        }
    }
}
