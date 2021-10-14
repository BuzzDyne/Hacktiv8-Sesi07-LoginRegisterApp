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
    public partial class Register : Form
    {
        Config db = new Config();
        public Register()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            db.Execute("INSERT INTO user_info (id, name, username, password) " +
                "VALUES (NULL, '" + tbNama.Text + "', '" + tbUsername.Text + "', '" + tbPwd.Text + "')");

            MessageBox.Show("Data telah tersimpan!");

            this.Close();
        }
    }
}
