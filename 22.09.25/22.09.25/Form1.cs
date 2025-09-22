using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._09._25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string budget, cotton, wood, leather, ceramics, plastic, glass, metal;
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
            Form2 newForm = new Form2(budget, cotton, wood, leather, ceramics, plastic, glass, metal);
            newForm.Show();
        }
    }
}
