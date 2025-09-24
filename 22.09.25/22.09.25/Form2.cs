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
    public partial class Form2 : Form
    {
        public BindingList<Order> orders = new BindingList<Order>();
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

        private void buttonOrdersList_Click(object sender, EventArgs e)
        {
            Form4 ordersList = new Form4();
            ordersList.Show();
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDelOk_Click(object sender, EventArgs e)
        {
            string delNameText = textBoxDelName.Text;
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\source\\repos\\22.09.25\\22.09.25\\orders.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] arr = line.Split(';');
                    Order newOrder = new Order(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8], arr[9]);
                    orders.Add(newOrder);
                }
            }
            int id = 0;
            foreach (Order order2 in orders)
            {
                Console.WriteLine(order2.Name, delNameText);
                if (order2.Name == delNameText)
                {
                    id = Convert.ToInt32(order2.Id) - 1;
                    Console.WriteLine(id);
                }
            }
            orders.RemoveAt(id);

            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\22.09.25\\22.09.25\\orders.txt", false))
            {
            }
            foreach (Order order in orders)
            {
                using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\22.09.25\\22.09.25\\orders.txt", true))
                {
                    writer.WriteLine($"{order.Id};{order.Name};{order.Budget};{order.Cotton};{order.Wood};{order.Leather};{order.Ceramics};{order.Plastic};{order.Glass};{order.Metal}");
                }
            }
        }
    }
}
