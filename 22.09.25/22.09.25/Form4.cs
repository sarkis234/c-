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
    public partial class Form4 : Form
    {
        public BindingList<Order> orders = new BindingList<Order>();
        public Form4()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\source\\repos\\22.09.25\\22.09.25\\orders.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] arr = line.Split(';');
                    Order newOrder = new Order(arr[0], arr[1], arr[2], arr[3], arr[4], arr[5], arr[6], arr[7], arr[8]);
                    orders.Add(newOrder);
                }
            }
            foreach (Order order in orders)
            {
                dataGridView1.Rows.Add(order.Name, order.Budget, order.Cotton, order.Wood, order.Leather, order.Ceramics, order.Plastic, order.Glass, order.Metal);
            }
        }

    }
}
