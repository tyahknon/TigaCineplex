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
    public partial class frmTicket : Form
    {

        private List<Button> seatButtons = new List<Button>();
        private string selectedSeat = string.Empty;
        private List<string> bookedSeats = new List<string>();
        private Ticket currentTicket;
        public frmTicket()
        {
            InitializeComponent();
            GenerateSeats();
            LoadShowtimes();
        }
        private void LoadShowtimes()
        {
            // Simulate or connect to DB to fetch showtimes
            cbxITSelectMovie.Items.Add("");
            cbxTicketPrice.Items.Add("");
        }

        private void GenerateSeats()
        {
            string[] rows = { "A", "B", "C", "D", "E" };
            for (int i = 0; i < rows.Length; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Button btn = new Button();
                    btn.Width = 40;
                    btn.Height = 40;
                    btn.Text = rows[i] + j;
                    btn.BackColor = Color.White;
                    btn.Click += Seat_Click;
                    panelSeats.Controls.Add(btn);
                    seatButtons.Add(btn);
                }
            }
        }

        private void frmTicket_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmTicket_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedSeat))
            {
                MessageBox.Show("Please select a seat.");
                return;
            }

            foreach (var btn in seatButtons)
            {
                if (btn.Text == selectedSeat)
                {
                    btn.BackColor = Color.Red;
                    break;
                }
            }

            // Display ticket details (dummy data for now)
            lblMovieName.Text = cbxITSelectMovie.Text;
            lblTicketPrice.Text = cbxTicketPrice.Text;
            lblDate.Text = DateTime.Today.ToShortDateString();
            lblTime.Text = ""; // You may replace this with actual showtime data
            lblHallNumber.Text = "";
            lblSeatNum.Text = selectedSeat;

            MessageBox.Show("Ticket Confirmed");
        }

        private void btnCancelTicket_Click(object sender, EventArgs e)
        {
            foreach (var btn in seatButtons)
            {
                if (btn.Text == selectedSeat && btn.BackColor == Color.Orange)
                {
                    btn.BackColor = Color.White;
                    selectedSeat = "";
                    lblSeatNumber.Text = "Seat Number:";
                    break;
                }
            }
        }

        private void btnPrintTicket_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ticket printed for seat: " + selectedSeat);
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            Button clicked = (Button)sender;
            if (clicked.BackColor == Color.Red)
            {
                MessageBox.Show("This seat is already booked.");
                return;
            }

            foreach (var btn in seatButtons)
            {
                if (btn.BackColor == Color.Orange)
                    btn.BackColor = Color.White;
            }

            clicked.BackColor = Color.Orange;
            selectedSeat = clicked.Text;
            lblSeatNumber.Text = selectedSeat;
        }
    }
}
