using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01._06._25
{
    public partial class Form2 : Form
    {
        public Form2(string log, string pass, Form1 form1)
        {
            //this.FormClosing += formOnClose;
            InitializeComponent();
            label1.Text = log;
            
        }

        //private void formOnClose(object sender, FormClosingEventArgs e)
        //{
        //    if (e.CloseReason == CloseReason.UserClosing)
        //    {
        //        Console.WriteLine(this.Owner);
        //    }
        //}
        private void button_Click(object sender, EventArgs e)
        {
            string testName = ((Button)sender).Name;
            int number = Convert.ToInt32(testName.Split('n')[1]);
            string path = $"C:\\Users\\Взрослая академия\\source\\repos\\01.06.25\\01.06.25\\test{number}.csv";
            Process.Start(path);
        }
    }
}
