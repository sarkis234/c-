using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;

namespace _22._09._25
{
    public class Order
    {
        private string budget, cotton, wood, leather, ceramics, plastic, glass, metal, name;
        public string Name
        {   get{return name;}
            set { name = value; }
        }
        public string Budget
        {
            get { return budget; }
            set { budget = value; }
        }
        public string Cotton
        {
            get { return cotton; }
            set { cotton = value; }
        }
        public string Wood
        {
            get { return wood; }
            set { wood = value; }
        }
        public string Leather
        {
            get { return leather; }
            set { leather = value; }
        }
        public string Ceramics
        {
            get { return ceramics; }
            set { ceramics = value; }
        }
        public string Plastic
        {
            get { return plastic; }
            set { plastic = value; }
        }
        public string Glass
        {
            get { return glass; }
            set { glass = value; }
        }
        public string Metal
        {
            get { return metal; }
            set { metal = value; }
        }
        public Order(string name, string budget, string cotton, string wood, string leather, string ceramics, string plastic, string glass, string metal) {
            this.budget = budget;
            this.cotton = cotton;
            this.wood = wood;
            this.leather = leather;
            this.ceramics = ceramics;
            this.plastic = plastic;
            this.glass = glass;
            this.metal = metal;
            this.name = name;
        }
    }
}
