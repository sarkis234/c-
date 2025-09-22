using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _22._09._25
{
    public partial class Form2 : Form
    {
        public Form2(string budget, string cotton, string wood, string leather, string ceramics, string plastic, string glass, string metal)
        {
            
            InitializeComponent();
            labelBudget.Text = budget;
            labelCotton.Text = cotton;
            labelWood.Text = wood;
            labelLeather.Text = leather;
            labelCeramic.Text = ceramics;
            labelPlastic.Text = plastic;
            labelMetal.Text = metal;
            labelGlass.Text = glass;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 addOrder = new Form3();
            addOrder.Show();
        }
    }
}
