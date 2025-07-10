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
    public partial class frmManageShowtime : Form
    {
        String loggedusers;
        List<Showtime> ShowtimeList;
        int selectedrow = -1; 
        public frmManageShowtime(String param)
        {
            InitializeComponent();
            loggedusers = param;
        }

        public frmManageShowtime()
        {
        }

        private void frmManageShowtime_Load(object sender, EventArgs e)
        {
            this.Text = "Logged in as: " + loggedusers.ToString();
            //disable the groupbox 
            gbxManageShowtime.Enabled = false;
            //call function to load showtime
            LoadShowtime();
        }

        private void cbxSelectMovie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblMovieName_Click(object sender, EventArgs e)
        {

        }

        private void btnMSMovie_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputCompleted() == true)
                {
                    //object of class today
                    Showtime st = new Showtime();
                    st.id = Convert.ToInt32(txtShowtimeID.Text);
                    st.mvid = cbxSelectMovie.SelectedItem.ToString();
                    st.hallnumber = cbxHallNumber.SelectedItem.ToString();
                    st.startdate = dtpstartdate.Value;
                    st.enddate = dtpenddate.Value;
                    st.time = cbxMSTime.SelectedItem.ToString();

                    if (st.UpdateRecord() == true)
                    {
                        MessageBox.Show("Showtime record updated successfully!", "Showtime");
                        //refresh the list
                        LoadShowtime();
                        //clear the inputs and disable groupbox
                        ClearInputsSt();

                    }
                    else
                    {
                        MessageBox.Show("Error Showtime", "Showtime", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    MessageBox.Show("Error Showtime", "Showtime", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool InputCompleted()
        {
            bool rtn = true;
            try
            {
                if (cbxSelectMovie.SelectedIndex == -1)
                {
                    MessageBox.Show("Required to select movie name", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }
                else if (cbxHallNumber.SelectedIndex == -1)
                {
                    MessageBox.Show("Select Hall number", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }
                else if (dtpstartdate.Text.Length == 0)
                {
                    MessageBox.Show("Enter the start date of the movie showtime", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }
                else if (dtpenddate.Value < dtpstartdate.Value)
                {
                    MessageBox.Show("End date must be after the start date.", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }
                else if (cbxMSTime.SelectedIndex == -1)
                {
                    MessageBox.Show("Select showtime of the movie", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return rtn;

        }

        private void btnMSCancel_Click(object sender, EventArgs e)
        {
            ClearInputsSt();
        }
        private void LoadShowtime()
        {
            try
            {
                //initialize the list
                ShowtimeList = new List<Showtime>();
                //object of class
                Showtime st = new Showtime();
                ShowtimeList = st.GetShowtime(loggedusers);
                //clear the listview
                lvShowtime.Items.Clear();
                if (ShowtimeList != null)//list greater than 0
                {

                    for (int row = 0; row < ShowtimeList.Count; row++)
                    {
                        lvShowtime.Items.Add(ShowtimeList[row].id.ToString());//1st column
                        //subitems for the rest of the column
                        lvShowtime.Items[row].SubItems.Add(ShowtimeList[row].mvid.ToString());
                        lvShowtime.Items[row].SubItems.Add(ShowtimeList[row].hallnumber.ToString());
                        lvShowtime.Items[row].SubItems.Add(ShowtimeList[row].startdate.ToString());
                        lvShowtime.Items[row].SubItems.Add(ShowtimeList[row].enddate.ToString());
                        lvShowtime.Items[row].SubItems.Add(ShowtimeList[row].time.ToString());

                    }
                }
                else
                {
                    MessageBox.Show("No list of Showtime found", "Showtime");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Showtime", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void lvShowtime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lvShowtime_Click(object sender, EventArgs e)
        {
            if (lvShowtime.SelectedIndices.Count > 0)
            {
                selectedrow = lvShowtime.SelectedIndices[0];
                LoadShowtimeDetail(selectedrow);
            }
        }
        private void LoadShowtimeDetail(int row)
        {
            try
            {
                //enable te groupbox
                gbxManageShowtime.Enabled = true;//load
                //display each content
                txtShowtimeID.Text = ShowtimeList[row].id.ToString();
                cbxSelectMovie.Text = ShowtimeList[row].mvid.ToString();
                cbxHallNumber.Text = ShowtimeList[row].hallnumber.ToString();
                dtpstartdate.Text = ShowtimeList[row].startdate.ToString();
                dtpenddate.Text = ShowtimeList[row].enddate.ToString();
                cbxMSTime.Text = ShowtimeList[row].time.ToString();
                //disable the id
                txtShowtimeID.Enabled = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "LoadShowtime Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputsSt()
        {
            txtShowtimeID.Clear();
            cbxSelectMovie.SelectedIndex = -1;
            cbxHallNumber.SelectedIndex = -1;
            dtpstartdate.Value = DateTime.Now;
            dtpenddate.Value = DateTime.Now;
            cbxMSTime.SelectedIndex = -1;
            //disable the Movie groupbox
            gbxManageShowtime.Enabled = false;
            //set the selected row to nothing
            selectedrow = -1;
        }

        private void btnMSRefresh_Click(object sender, EventArgs e)
        {
            LoadShowtime();
        }

        private void btnMSDelete_Click(object sender, EventArgs e)
        {
            DialogResult qs = MessageBox.Show("Delete this record", "Showtime", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (qs == DialogResult.Yes)
            {
                Showtime st = new Showtime();
                st.id = Convert.ToInt32(txtShowtimeID.Text);
                if (st.DeleteRecords() == true)
                {
                    MessageBox.Show("Record had been delete!", "Movie");
                    LoadShowtime();
                    ClearInputsSt();
                }
            }
        }

        private void btnMSApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxMSFilterBy.SelectedIndex != -1 && cbxMSOrderBy.SelectedIndex != -1)
                {
                    int selectField = cbxMSFilterBy.SelectedIndex;
                    int orders = cbxMSOrderBy.SelectedIndex;
                    //initialize the list
                    ShowtimeList = new List<Showtime>();
                    //object of class 
                    Showtime mv = new Showtime();
                    ShowtimeList = mv.FilterShowtime(selectField, orders, loggedusers);
                    //clear the listview
                    lvShowtime.Items.Clear();
                    if (ShowtimeList != null)//list greater than 0
                    {

                        //loop
                        for (int row = 0; row < ShowtimeList.Count; row++)
                        {
                            lvShowtime.Items.Add(ShowtimeList[row].id.ToString());//1st column
                            //subitems for the rest of the column
                            lvShowtime.Items[row].SubItems.Add(ShowtimeList[row].mvid.ToString());
                            lvShowtime.Items[row].SubItems.Add(ShowtimeList[row].hallnumber.ToString());
                            lvShowtime.Items[row].SubItems.Add(ShowtimeList[row].startdate.ToString());
                            lvShowtime.Items[row].SubItems.Add(ShowtimeList[row].enddate.ToString());
                            lvShowtime.Items[row].SubItems.Add(ShowtimeList[row].time.ToString());
                            //disable the ID
                            txtShowtimeID.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No list of showtime found", "Showtime");
                    }
                }
                else
                {
                    MessageBox.Show("Select field and order", "Apply", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Apply", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
