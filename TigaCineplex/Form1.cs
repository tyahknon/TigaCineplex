using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TigaCineplex.Class;

namespace TigaCineplex
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp frm = new frmSignUp();
            frm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 1. Validate input
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Username/Password cannot be empty", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Login for Manager (hardcoded)
            if (rbManager.Checked)
            {
                if (txtUsername.Text == "admin" && txtPassword.Text == "admin123")
                {
                    MessageBox.Show("Logged in as Manager", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDashboard frm = new frmDashboard(txtUsername.Text);
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Login failed (Manager)", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // 3. Login for Admin (database check)
            else if (rbAdmin.Checked)
            {
                Users u = new Users();
                string hashedPassword = u.HashPassword(txtPassword.Text);
                List<Users> userList = u.LoginUser(txtUsername.Text.Trim(), hashedPassword);

                if (userList != null && userList.Count > 0)
                {
                    MessageBox.Show("Logged in as Admin", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmDashboard frm = new frmDashboard(txtUsername.Text);
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Login failed (Admin)", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //set the default radio button
            rbAdmin.Checked = true;
            rbManager.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
