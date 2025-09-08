using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08._09._25
{
    public partial class Form1 : Form
    {
        public List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = users;
        }
        private void printUsersInfo(User user)
        {
            users.Add(user);
            dataGridView1.DataSource = users;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.addNewUser += printUsersInfo;
            newForm.Show();
        }
    }
}
