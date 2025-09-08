using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08._09._25
{
    public class User
    {
        private string login;
        private string password;
        private string name;
        private int age;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string Name
        {
            get{ return name;}
            set{ name = value;}
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public User(string login, string password, string name, int age) { 
            this.login = login;
            this.password = password;
            this.name = name;
            this.age = age;
        }
    }
}
