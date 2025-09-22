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

namespace _22._09._25
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            string budget, cotton, wood, leather, ceramics, plastic, glass, metal, name;
            name = textBoxName.Text;
            if (textBoxBudget == null)
            {
                budget = "0";
            }
            else
            {
                budget = textBoxBudget.Text;
            }
            if (textBoxCotton == null)
            {
                cotton = "0";
            }
            else
            {
                cotton = textBoxCotton.Text;
            }
            if (textBoxWood == null)
            {
                wood = "0";
            }
            else
            {
                wood = textBoxWood.Text;
            }
            if (textBoxLeather == null)
            {
                leather = "0";
            }
            else
            {
                leather = textBoxLeather.Text;
            }
            if (textBoxCeramic == null)
            {
                ceramics = "0";
            }
            else
            {
                ceramics = textBoxCeramic.Text;
            }
            if (textBoxGlass == null)
            {
                glass = "0";
            }
            else
            {
                glass = textBoxGlass.Text;
            }
            if (textBoxPlastic == null)
            {
                plastic = "0";
            }
            else
            {
                plastic = textBoxPlastic.Text;
            }
            if (textBoxMetal == null)
            {
                metal = "0";
            }
            else
            {
                metal = textBoxMetal.Text;
            }
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\source\\repos\\22.09.25\\22.09.25\\orders.txt"))
            {
                string line;
                if (reader.ReadLine() == null)
                {
                    id = 1;
                }
                else
                {
                    id = 2;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] arr = line.Split(';');
                        id = Convert.ToInt32(arr[0]) + 1;
                    }
                }
            }
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\22.09.25\\22.09.25\\orders.txt", true))
            {
                writer.WriteLine($"{id};{name};{budget};{cotton};{wood};{leather};{ceramics};{plastic};{glass};{metal}");
            }
        }
    }
}
