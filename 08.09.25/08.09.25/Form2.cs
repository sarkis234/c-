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
    public partial class Form2 : Form
    {
        public event Action<User> addNewUser;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(textBox1.Text, textBox2.Text, textBox3.Text, Convert.ToInt32(textBox4.Text));
            addNewUser?.Invoke(user);
        }
    }
}
