using Azure.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TigaCineplex
{
    public partial class frmDashboard : Form
    {
        private string loggedInUser;
        public frmDashboard(string username)
        {
            InitializeComponent();
            loggedInUser = username;
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void picTickets_Click(object sender, EventArgs e)
        {

        }

        private void btnManageMovies_Click(object sender, EventArgs e)
        {
            frmManageMovie frm = new frmManageMovie(loggedInUser);
            frm.Show();
        }

        private void btnAddMovies_Click(object sender, EventArgs e)
        {
            frmAddMovie frm = new frmAddMovie();
            frm.ShowDialog();
        }

        private void btnManageShowtimes_Click(object sender, EventArgs e)
        {
            frmManageShowtime frm = new frmManageShowtime(loggedInUser);
            frm.ShowDialog();
        }

        private void btnCreateShowtimes_Click(object sender, EventArgs e)
        {
            frmAddShowtime frm = new frmAddShowtime();
            frm.ShowDialog();
        }

        private void btnIssueTickets_Click(object sender, EventArgs e)
        {
            frmTicket frm = new frmTicket();
            frm.ShowDialog();
        }
    }
}
