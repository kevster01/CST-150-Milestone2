using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_Project_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_lbl_Click(object sender, EventArgs e)
        {
            username_txt.Clear();
            password_txt.Clear();
            username_txt.Focus();

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (username_txt.Text == "Admin" && password_txt.Text == "Password")
            {
                new AdminPortal().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again");
                username_txt.Clear();
                password_txt.Clear();
                username_txt.Focus();
            }

        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }


    }
}
