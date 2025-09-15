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
using static System.Net.Mime.MediaTypeNames;

namespace _15._09._25
{
    public partial class Form1 : Form
    {
        logger l1 = new logger();
        public Form1()
        {
            InitializeComponent();
        }

        public void readFile(string path)
        {
            try
            {
                File.OpenRead(path);
            }
            catch (Exception ex)
            {
                l1.logging(ex.Message);
            }
            finally
            {
                l1.logging("POSTOL");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.ShowDialog();
            //if(saveFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    path = saveFileDialog.FileName;
            //}
            //using (StreamWriter writer = new StreamWriter(path, false))
            //{
            //    writer.WriteLine(textBox1.Text);
            //}
            readFile(path);
        }
    }
}
