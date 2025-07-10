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
    public partial class frmAddMovie : Form
    {
    
        public frmAddMovie()
        {
            InitializeComponent();
        }

        private void frmAddMovie_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (InputCompleteds() == true)
            {
                //object of class today
                Movie mv = new Movie();
                mv.name = txtMovieName.Text;
                mv.genre = cbxGenre.SelectedItem.ToString();
                mv.rating = cbxRating.SelectedItem.ToString();
                mv.duration = txtDuration.Text;
                mv.description = txtDescription.Text;
           

                if (mv.SaveMovie(mv) == true)
                {
                    MessageBox.Show("Latest Movie had been Added!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error saving", "Movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("Error saving", "Movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool InputCompleteds()
        {
            bool rtn = true;
            try
            {
                if (txtMovieName.Text.Length == 0)
                {
                    MessageBox.Show("Insert movie name", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }
                else if (txtDescription.Text.Length == 0)
                {
                    MessageBox.Show("Insert description of the movie", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cbxGenre.SelectedIndex == -1)
                {
                    MessageBox.Show("Select genre", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }
                else if (cbxRating.SelectedIndex == -1)
                {
                    MessageBox.Show("Select Rating", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }

                else if (txtDuration.Text.Length == 0)
                {
                    MessageBox.Show("Enter the duration of the movie", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtn;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int GetUserID(string param)
        {
            int rtn = 0;
            try
            {
                //object for Users
                Users u = new Users();
                u.username = param;
                rtn = u.GetID();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "GetUserID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtn;
        }//end method
    }
}
