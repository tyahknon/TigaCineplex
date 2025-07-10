using Microsoft.Data.SqlClient;
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
    public partial class frmAddShowtime : Form
    {
        string loggeduser;
        List<Movie> movielist;
        public frmAddShowtime()
        {
            InitializeComponent();

        }

        private void frmAddShowtime_Load(object sender, EventArgs e)
        {
            LoadMovies();
        }
        private void LoadMovies()
        {
            try
            {
                Movie mv = new Movie();
                movielist = new List<Movie>();
                movielist = mv.GetMovie("");
                for (int i = 0; i < movielist.Count; i++) {
                    cbxSelectMovie.Items.Add(movielist[i].name);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadMovies Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (InputCompleteds() == true)
            {
                //object of class today
                Showtime st = new Showtime();

                st.mvid = movielist[cbxSelectMovie.SelectedIndex].id.ToString();
                MessageBox.Show(st.mvid); 
                st.startdate = dtpstartdate.Value;
                st.enddate = dtpenddate.Value;
                st.time = cbxTime.SelectedItem.ToString();
                st.hallnumber = cbxHallNumber.SelectedItem.ToString();
                st.userid = 2;
           

                if (st.SaveShowtime(st) == true)
                {
                    MessageBox.Show("Latest Showtime had been Added!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error saving", "Showtime", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {

                MessageBox.Show("Error saving", "Showtime", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool InputCompleteds()
        {
            bool rtn = true;
            try
            {
                if (cbxSelectMovie.SelectedIndex == -1)
                {
                    MessageBox.Show("Select Movie name", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }
                else if (cbxHallNumber.SelectedIndex == -1)
                {
                    MessageBox.Show("Select Hall Number for thid movie", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn =false;
                }
                else if (cbxTime.SelectedIndex == -1)
                {
                    MessageBox.Show("Select showtime", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }
                else if (dtpstartdate.Text.Length == -1)
                {
                    MessageBox.Show("Select start date of the showtime", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }

                else if (dtpstartdate.Text.Length == 0)
                {
                    MessageBox.Show("Select end date of the showtime", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtn;
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

        private void btnCancelShowtimes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
