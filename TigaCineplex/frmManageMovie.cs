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
    public partial class frmManageMovie : Form
    {
        String loggeduser;
        List<Movie> MovieList;
        int selectedrow = -1; //no index selected
        public frmManageMovie(String param)
        {
            InitializeComponent();
            loggeduser = param;
        }

      

        private void frmManageMovie_Load(object sender, EventArgs e)
        {
            this.Text = "Logged in as: " + loggeduser.ToString();
            //disable the groupbox
            gbxManageMovie.Enabled = false;
            //call function to load movie
            LoadMovie();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (InputCompleteds() == true)
                {
                    //object of class today
                    Movie mv = new Movie();
                    mv.id = Convert.ToInt32(txtMovieID.Text);
                    mv.name = txtMGMovieName.Text;
                    mv.genre = cbxMGGenre.SelectedItem.ToString();
                    mv.rating =cbxRating.SelectedItem.ToString();
                    mv.duration = txtMGDuration.Text;
                    mv.description = txtMGDescription.Text;

                    if (mv.UpdateRecords() == true)
                    {
                        MessageBox.Show("Update Movie Added!", "Movie");
                        //refresh the list
                        LoadMovie();
                        //clear the inputs and disable groupbox
                        ClearInputsMv();

                    }
                    else
                    {
                        MessageBox.Show("Error Movie", "Movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {

                    MessageBox.Show("Error Movie", "Movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool InputCompleteds()
        {
            bool rtn = true;
            try
            {
                if (txtMGMovieName.Text.Length == 0)
                {
                    MessageBox.Show("Name required", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }
                else if (cbxMGGenre.SelectedIndex == -1)
                {
                    MessageBox.Show("Select genre", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }
                else if (txtMGDuration.Text.Length == 0)
                {
                    MessageBox.Show("Enter duration of the movie", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }
                else if (txtMGDescription.Text.Length == 0)
                {
                    MessageBox.Show("Enter description of the movie", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rtn = false;
                }
                else if (cbxRating.SelectedIndex == -1)
                {
                    MessageBox.Show("Select rating of the movie", "InputCompleted", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ClearInputsMv();
        }
        private void LoadMovie()
        {
            try
            {
                //initialize the list
                MovieList = new List<Movie>();
                //object of class
                Movie mv = new Movie();
                MovieList = mv.GetMovie(loggeduser);
                //clear the listview
                lvMovie.Items.Clear();
                if (MovieList != null)//list greater than 0
                {
               
                    for (int row = 0; row < MovieList.Count; row++)
                    {
                        lvMovie.Items.Add(MovieList[row].id.ToString());//1st column
                        //subitems for the rest of the column
                        lvMovie.Items[row].SubItems.Add(MovieList[row].name.ToString());
                        lvMovie.Items[row].SubItems.Add(MovieList[row].genre.ToString());
                        lvMovie.Items[row].SubItems.Add(MovieList[row].duration.ToString());
                        lvMovie.Items[row].SubItems.Add(MovieList[row].rating.ToString());

                    }
                }
                else
                {
                    MessageBox.Show("No list of Movie found", "Movie");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Movie", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void lvMovie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lvMovie_Click(object sender, EventArgs e)
        {
            selectedrow = lvMovie.SelectedIndices[0];
           
            if (selectedrow > -1)
            {
                LoadMovieDetail(selectedrow);
            }
        }
        private void LoadMovieDetail(int row)
        {
            try
            {
                //enable te groupbox
                gbxManageMovie.Enabled = true;//load
                //display each content
                txtMovieID.Text = MovieList[row].id.ToString();
                txtMGMovieName.Text = MovieList[row].name.ToString();
                txtMGDuration.Text = MovieList[row].duration.ToString();
                cbxMGGenre.Text = MovieList[row].genre.ToString();
                cbxRating.Text = MovieList[row].rating.ToString();
                txtMGDescription.Text = MovieList[row].description.ToString();
                //disable the id
                txtMovieID.Enabled = false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "LoadMovie Detail", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputsMv()
        {
            txtMovieID.Clear();
            txtMGMovieName.Clear();
            cbxMGGenre.SelectedIndex = -1;
            cbxRating.SelectedIndex = -1;
            txtMGDuration.Clear();
            txtMGDescription.Clear();
            //disable the Movie groupbox
            gbxManageMovie.Enabled = false;
            //set the selected row to nothing
            selectedrow = -1;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMovie();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult qs = MessageBox.Show("Delete this record", "Movie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (qs == DialogResult.Yes)
            {
                Movie mv = new Movie();
                mv.id = Convert.ToInt32(txtMovieID.Text);
                if (mv.DeleteRecord() == true)
                {
                    MessageBox.Show("Record had been delete!", "Movie");
                    LoadMovie();
                    ClearInputsMv();
                }
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxFilterBy.SelectedIndex != -1 && cbxOrderBy.SelectedIndex != -1)
                {
                    int selectField = cbxFilterBy.SelectedIndex;
                    int orders = cbxOrderBy.SelectedIndex;
                    //initialize the list
                    MovieList = new List<Movie>();
                    //object of class 
                    Movie mv = new Movie();
                    MovieList = mv.FilterMovie(selectField, orders, loggeduser);
                    //clear the listview
                    lvMovie.Items.Clear();
                    if (MovieList != null)//list greater than 0
                    {

                        //loop
                        for (int row = 0; row < MovieList.Count; row++)
                        {
                            lvMovie.Items.Add(MovieList[row].id.ToString());//1st column
                            //subitems for the rest of the column
                            lvMovie.Items[row].SubItems.Add(MovieList[row].name.ToString());
                            lvMovie.Items[row].SubItems.Add(MovieList[row].genre.ToString());
                            lvMovie.Items[row].SubItems.Add(MovieList[row].duration.ToString());
                            lvMovie.Items[row].SubItems.Add(MovieList[row].rating.ToString());
                            //disable the ID
                            txtMovieID.Enabled = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No list of movie found", "Movie");
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
