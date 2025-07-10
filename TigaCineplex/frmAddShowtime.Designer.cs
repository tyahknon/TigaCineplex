namespace TigaCineplex
{
    partial class frmAddShowtime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxCreateShowtimes = new System.Windows.Forms.GroupBox();
            this.dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxHallNumber = new System.Windows.Forms.ComboBox();
            this.cbxTime = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpstartdate = new System.Windows.Forms.DateTimePicker();
            this.btnCancelShowtimes = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cbxSelectMovie = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.gbxCreateShowtimes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCreateShowtimes
            // 
            this.gbxCreateShowtimes.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gbxCreateShowtimes.Controls.Add(this.dtpenddate);
            this.gbxCreateShowtimes.Controls.Add(this.label2);
            this.gbxCreateShowtimes.Controls.Add(this.label1);
            this.gbxCreateShowtimes.Controls.Add(this.cbxHallNumber);
            this.gbxCreateShowtimes.Controls.Add(this.cbxTime);
            this.gbxCreateShowtimes.Controls.Add(this.lblTime);
            this.gbxCreateShowtimes.Controls.Add(this.dtpstartdate);
            this.gbxCreateShowtimes.Controls.Add(this.btnCancelShowtimes);
            this.gbxCreateShowtimes.Controls.Add(this.btnCreate);
            this.gbxCreateShowtimes.Controls.Add(this.cbxSelectMovie);
            this.gbxCreateShowtimes.Controls.Add(this.lblDate);
            this.gbxCreateShowtimes.Controls.Add(this.lblMovieName);
            this.gbxCreateShowtimes.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCreateShowtimes.ForeColor = System.Drawing.Color.Navy;
            this.gbxCreateShowtimes.Location = new System.Drawing.Point(41, 52);
            this.gbxCreateShowtimes.Name = "gbxCreateShowtimes";
            this.gbxCreateShowtimes.Size = new System.Drawing.Size(559, 448);
            this.gbxCreateShowtimes.TabIndex = 2;
            this.gbxCreateShowtimes.TabStop = false;
            this.gbxCreateShowtimes.Text = "Create Showtimes - * required";
            // 
            // dtpenddate
            // 
            this.dtpenddate.CustomFormat = "yyyy-MM-dd";
            this.dtpenddate.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpenddate.Location = new System.Drawing.Point(192, 191);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(300, 29);
            this.dtpenddate.TabIndex = 21;
            this.dtpenddate.Value = new System.DateTime(2025, 6, 2, 8, 9, 27, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(30, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 20;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(30, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Hall Number:*";
            // 
            // cbxHallNumber
            // 
            this.cbxHallNumber.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHallNumber.FormattingEnabled = true;
            this.cbxHallNumber.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbxHallNumber.Location = new System.Drawing.Point(192, 99);
            this.cbxHallNumber.Name = "cbxHallNumber";
            this.cbxHallNumber.Size = new System.Drawing.Size(188, 30);
            this.cbxHallNumber.TabIndex = 18;
            // 
            // cbxTime
            // 
            this.cbxTime.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTime.FormattingEnabled = true;
            this.cbxTime.Items.AddRange(new object[] {
            "11:00AM",
            "11:30AM",
            "12:00PM",
            "12:30PM",
            "1:00PM",
            "1:30PM",
            "2:00PM",
            "2:30PM",
            "3:00PM",
            "3:30PM",
            "4:00PM",
            "4:30PM",
            "5:00PM",
            "5:30PM",
            "6:00PM",
            "6:30PM",
            "7:00PM",
            "7:30PM",
            "8:00PM",
            "8:30PM",
            "9:00PM",
            "9:30PM",
            "10:00PM",
            "10:30PM"});
            this.cbxTime.Location = new System.Drawing.Point(193, 235);
            this.cbxTime.Name = "cbxTime";
            this.cbxTime.Size = new System.Drawing.Size(299, 30);
            this.cbxTime.TabIndex = 16;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Navy;
            this.lblTime.Location = new System.Drawing.Point(31, 235);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(71, 27);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "Time:*";
            // 
            // dtpstartdate
            // 
            this.dtpstartdate.CustomFormat = "yyyy-MM-dd";
            this.dtpstartdate.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpstartdate.Location = new System.Drawing.Point(192, 146);
            this.dtpstartdate.Name = "dtpstartdate";
            this.dtpstartdate.Size = new System.Drawing.Size(300, 29);
            this.dtpstartdate.TabIndex = 14;
            this.dtpstartdate.Value = new System.DateTime(2025, 6, 2, 8, 9, 27, 0);
            // 
            // btnCancelShowtimes
            // 
            this.btnCancelShowtimes.BackColor = System.Drawing.Color.Navy;
            this.btnCancelShowtimes.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelShowtimes.ForeColor = System.Drawing.Color.White;
            this.btnCancelShowtimes.Location = new System.Drawing.Point(351, 300);
            this.btnCancelShowtimes.Name = "btnCancelShowtimes";
            this.btnCancelShowtimes.Size = new System.Drawing.Size(141, 36);
            this.btnCancelShowtimes.TabIndex = 13;
            this.btnCancelShowtimes.Text = "Cancel";
            this.btnCancelShowtimes.UseVisualStyleBackColor = false;
            this.btnCancelShowtimes.Click += new System.EventHandler(this.btnCancelShowtimes_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Navy;
            this.btnCreate.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(209, 300);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(137, 36);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cbxSelectMovie
            // 
            this.cbxSelectMovie.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectMovie.FormattingEnabled = true;
            this.cbxSelectMovie.Location = new System.Drawing.Point(192, 55);
            this.cbxSelectMovie.Name = "cbxSelectMovie";
            this.cbxSelectMovie.Size = new System.Drawing.Size(300, 30);
            this.cbxSelectMovie.TabIndex = 8;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Navy;
            this.lblDate.Location = new System.Drawing.Point(30, 146);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(116, 27);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Start Date:*";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.ForeColor = System.Drawing.Color.Navy;
            this.lblMovieName.Location = new System.Drawing.Point(30, 55);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(138, 27);
            this.lblMovieName.TabIndex = 1;
            this.lblMovieName.Text = "Select Movie:*";
            // 
            // frmAddShowtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(650, 553);
            this.Controls.Add(this.gbxCreateShowtimes);
            this.Name = "frmAddShowtime";
            this.Text = "Add Showtime";
            this.Load += new System.EventHandler(this.frmAddShowtime_Load);
            this.gbxCreateShowtimes.ResumeLayout(false);
            this.gbxCreateShowtimes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCreateShowtimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxHallNumber;
        private System.Windows.Forms.ComboBox cbxTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpstartdate;
        private System.Windows.Forms.Button btnCancelShowtimes;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbxSelectMovie;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.DateTimePicker dtpenddate;
        private System.Windows.Forms.Label label2;
    }
}