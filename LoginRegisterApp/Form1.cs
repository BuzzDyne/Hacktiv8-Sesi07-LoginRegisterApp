using LoginRegisterForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegisterApp
{
    public partial class Form1 : Form
    {
        Config db = new Config();
        public Form1()
        {
            InitializeComponent();

            db.Connect("userdata");
        }
        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect("SELECT * FROM user_info WHERE username='" + etUsername.Text + "' AND password='" + etPassword.Text + "'");

            if (db.Count() == 1)
            {
                MessageBox.Show("Logged in as " + db.Results(0, "name"));
            } else
            {
                MessageBox.Show("Wrong Credentials");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
