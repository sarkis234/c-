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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _22._09._25
{
    public partial class Form3 : Form
    {
        public event Action<Order> addNewOrder;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string budget, cotton, wood, leather, ceramics, plastic, glass, metal, name, cotton2, wood2, leather2, ceramics2, plastic2, glass2, metal2;
            bool flag = false;
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
            using (StreamReader reader = new StreamReader("C:\\Users\\Взрослая академия\\source\\repos\\22.09.25\\22.09.25\\materials.txt"))
            {
                string[] line = reader.ReadLine().Split(';');
                cotton2 = line[1];
                wood2 = line[2];
                leather2 = line[3];
                ceramics2 = line[4];
                plastic2 = line[5];
                glass2 = line[6];
                metal2 = line[7];
                if (Convert.ToInt32(line[1]) <  Convert.ToInt32(cotton)){
                    label10.Text = "Недостаточно хлопка";
                    label10.Visible = true;
                }
                else if (Convert.ToInt32(line[2]) < Convert.ToInt32(wood))
                {
                    label10.Text = "Недостаточно дерева";
                    label10.Visible = true;
                }
                else if (Convert.ToInt32(line[3]) < Convert.ToInt32(leather))
                {
                    label10.Text = "Недостаточно кожи";
                    label10.Visible = true;
                }
                else if (Convert.ToInt32(line[4]) < Convert.ToInt32(ceramics))
                {
                    label10.Text = "Недостаточно керамики";
                    label10.Visible = true;
                }
                else if (Convert.ToInt32(line[5]) < Convert.ToInt32(plastic))
                {
                    label10.Text = "Недостаточно пластика";
                    label10.Visible = true;
                }
                else if (Convert.ToInt32(line[6]) < Convert.ToInt32(glass))
                {
                    label10.Text = "Недостаточно стекла";
                    label10.Visible = true;
                }
                else if (Convert.ToInt32(line[7]) < Convert.ToInt32(metal))
                {
                    label10.Text = "Недостаточно металла";
                    label10.Visible = true;
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\22.09.25\\22.09.25\\orders.txt", true))
                    {
                        writer.WriteLine($"{name};{budget};{cotton};{wood};{leather};{ceramics};{plastic};{glass};{metal}");
                    }
                    flag = true;
                }
            }
            using (StreamWriter writer = new StreamWriter("C:\\Users\\Взрослая академия\\source\\repos\\22.09.25\\22.09.25\\materials.txt", false))
            {
                writer.WriteLine($"{budget};{Convert.ToInt32(cotton2) - Convert.ToInt32(cotton)};{Convert.ToInt32(wood2) - Convert.ToInt32(wood)};{Convert.ToInt32(leather2) - Convert.ToInt32(leather)};{Convert.ToInt32(ceramics2) - Convert.ToInt32(ceramics)};{Convert.ToInt32(plastic2) - Convert.ToInt32(plastic)};{Convert.ToInt32(glass2) - Convert.ToInt32(glass)};{Convert.ToInt32(metal2) - Convert.ToInt32(metal)}");
            }

            this.Close();

            Form2 form2 = new Form2(budget, Convert.ToString(Convert.ToInt32(cotton2) - Convert.ToInt32(cotton)), Convert.ToString(Convert.ToInt32(wood2) - Convert.ToInt32(wood)), Convert.ToString(Convert.ToInt32(leather2) - Convert.ToInt32(leather)), Convert.ToString(Convert.ToInt32(cotton2) - Convert.ToInt32(cotton)), Convert.ToString(Convert.ToInt32(plastic2) - Convert.ToInt32(plastic)), Convert.ToString(Convert.ToInt32(glass2) - Convert.ToInt32(glass)), Convert.ToString(Convert.ToInt32(metal2) - Convert.ToInt32(metal)));
            form2.Show();
        }
    }
}
