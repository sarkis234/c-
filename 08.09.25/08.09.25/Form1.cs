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

namespace _08._09._25
{
    public partial class Form1 : Form
    {
        public BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = users;
        }
        private void printUsersInfo(User user)
        {
            users.Add(user);
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\08.09.25\\08.09.25\\users.csv", true))
            {
                writer.WriteLine($"{user.Login};{user.Password};{user.Name};{user.Age}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.addNewUser += printUsersInfo;
            newForm.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
            button3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in users)
            {
                if (item.Login == textBox1.Text)
                {
                    users.Remove(item);
                    break;
                }
            }
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\08.09.25\\08.09.25\\users.csv", false)){}
            foreach (var item in users)
            {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\08.09.25\\08.09.25\\users.csv", true))
                {
                    writer.WriteLine($"{item.Login};{item.Password};{item.Name};{item.Age}");
                }
            }
            label1.Visible = false;
            textBox1.Visible = false;
            button3.Visible = false;
        }

        private void FileBtn_Click(object sender, EventArgs e)
        {
            //    using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
            //        if (openFileDialog.ShowDialog() == DialogResult.OK)
            //        {
            //            openFileDialog.Filter = 
            //            string path = openFileDialog.FileName;

            //        }
            //    }
        }
}
}
