using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TigaCineplex.Class;

namespace TigaCineplex
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frnSignUp_Load(object sender, EventArgs e)
        {
            //call function load event
            load_event();

            Database db = new Database();
            db.OpenConnection();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            
            bool savedetails = true;
            if (!inputOK(txtFullname, 2, 128, "Name cannot be empty"))
            {
                savedetails = false;
            }
            else if (!inputOK(txtEmail, 6, 64, "Email cannot be empty"))
            {
                savedetails = false;
            }
            else if (!txtPhone.MaskCompleted)
            {
                MessageBox.Show(" Phone Nmber cannot be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                savedetails = false;
            }
            else if (cbxRole.SelectedIndex == -1)
            {
                MessageBox.Show("Select your role in Tiga Cineplex", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                savedetails = false;
            }
            else if (!inputOK(txtUsername, 4, 16, "Uername cannot be empty"))
            {
                savedetails = false;
            }
            else if (!inputOK(txtPassword, 6, 32, "Password cannot be empty")) 
            {
                savedetails = false;            
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                savedetails = false;
                MessageBox.Show("Password(s) did not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(savedetails)
            {
                Users u = new Users();
                u.name = txtFullname.Text;
                u.email = txtEmail.Text;
                u.phone = txtPhone.Text;
                u.role = cbxRole.SelectedItem.ToString();
                u.username = txtUsername.Text;
                u.password = HashPassword(txtPassword.Text);

                if (u.Checkusername(txtUsername.Text))
                {
                    MessageBox.Show("This username has already been taken", "Sign-Up Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (u.SaveUser(u))
                    {
                        MessageBox.Show("New user of Tiga Cineplex has been added!", "Sign-Up Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        load_event();      // Lock fields again
                        clear_inputs();    // Clear input fields
                    }
                    else
                    {
                        MessageBox.Show("Error saving user. Please try again.", "Sign-Up Form", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        
        }

        private bool inputOK(Control ctr, int min, int max, string message)
        {
            string text = ctr.Text.Trim();
            if (text.Length >= min && text.Length <= max)
                return true;

            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //call function for add button
            add_event();
        }

        private void add_event()
        {
            txtFullname.Enabled = true;
            txtEmail.Enabled = true;
            txtPhone.Enabled = true;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            txtConfirmPassword.Enabled = true;
            cbxRole.Enabled = true;
            //button
            btnAdd.Enabled = false;
            btnSignup.Enabled = true;
            btnCancel.Enabled = true;

            cbxRole.SelectedIndex = 0;

        }

        private void load_event()
        {
            txtFullname.Enabled = false;
            txtEmail.Enabled = false;
            txtUsername.Enabled = false;
            txtPhone.Enabled = false;
            txtPassword.Enabled = false;
            txtConfirmPassword.Enabled = false;
            cbxRole.Enabled = false;
            //button
            btnAdd.Enabled = true;
            btnSignup.Enabled = false;
            btnCancel.Enabled = false;

            cbxRole.SelectedIndex = 0;

        }

        private void clear_inputs()
        {
            txtFullname.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            txtUsername.Clear();
            cbxRole.SelectedIndex = 0;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
        private void gbxUserInformation_Enter(object sender, EventArgs e)
        {

        }
    }
}
