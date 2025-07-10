namespace TigaCineplex
{
    partial class frmManageShowtime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageShowtime));
            this.btnMSRefresh = new System.Windows.Forms.Button();
            this.btnMSApply = new System.Windows.Forms.Button();
            this.gbxManageShowtime = new System.Windows.Forms.GroupBox();
            this.dtpstartdate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cbxHallNumber = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMSDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtShowtimeID = new System.Windows.Forms.TextBox();
            this.cbxMSTime = new System.Windows.Forms.ComboBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.cbxSelectMovie = new System.Windows.Forms.ComboBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.btnMSCancel = new System.Windows.Forms.Button();
            this.btnMSMovie = new System.Windows.Forms.Button();
            this.cbxMSOrderBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxMSFilterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTigaCineplex = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lvShowtime = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbxManageShowtime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMSRefresh
            // 
            this.btnMSRefresh.BackColor = System.Drawing.Color.Navy;
            this.btnMSRefresh.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMSRefresh.ForeColor = System.Drawing.Color.White;
            this.btnMSRefresh.Location = new System.Drawing.Point(638, 431);
            this.btnMSRefresh.Name = "btnMSRefresh";
            this.btnMSRefresh.Size = new System.Drawing.Size(122, 36);
            this.btnMSRefresh.TabIndex = 50;
            this.btnMSRefresh.Text = "Refresh";
            this.btnMSRefresh.UseVisualStyleBackColor = false;
            this.btnMSRefresh.Click += new System.EventHandler(this.btnMSRefresh_Click);
            // 
            // btnMSApply
            // 
            this.btnMSApply.BackColor = System.Drawing.Color.Navy;
            this.btnMSApply.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMSApply.ForeColor = System.Drawing.Color.White;
            this.btnMSApply.Location = new System.Drawing.Point(496, 430);
            this.btnMSApply.Name = "btnMSApply";
            this.btnMSApply.Size = new System.Drawing.Size(122, 36);
            this.btnMSApply.TabIndex = 49;
            this.btnMSApply.Text = "Apply";
            this.btnMSApply.UseVisualStyleBackColor = false;
            this.btnMSApply.Click += new System.EventHandler(this.btnMSApply_Click);
            // 
            // gbxManageShowtime
            // 
            this.gbxManageShowtime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxManageShowtime.Controls.Add(this.dtpstartdate);
            this.gbxManageShowtime.Controls.Add(this.label6);
            this.gbxManageShowtime.Controls.Add(this.cbxHallNumber);
            this.gbxManageShowtime.Controls.Add(this.label5);
            this.gbxManageShowtime.Controls.Add(this.btnMSDelete);
            this.gbxManageShowtime.Controls.Add(this.label4);
            this.gbxManageShowtime.Controls.Add(this.txtShowtimeID);
            this.gbxManageShowtime.Controls.Add(this.cbxMSTime);
            this.gbxManageShowtime.Controls.Add(this.lblTime);
            this.gbxManageShowtime.Controls.Add(this.dtpenddate);
            this.gbxManageShowtime.Controls.Add(this.cbxSelectMovie);
            this.gbxManageShowtime.Controls.Add(this.lblDate);
            this.gbxManageShowtime.Controls.Add(this.lblMovieName);
            this.gbxManageShowtime.Controls.Add(this.btnMSCancel);
            this.gbxManageShowtime.Controls.Add(this.btnMSMovie);
            this.gbxManageShowtime.Font = new System.Drawing.Font("Palatino Linotype", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxManageShowtime.ForeColor = System.Drawing.Color.Navy;
            this.gbxManageShowtime.Location = new System.Drawing.Point(805, 44);
            this.gbxManageShowtime.Name = "gbxManageShowtime";
            this.gbxManageShowtime.Size = new System.Drawing.Size(441, 424);
            this.gbxManageShowtime.TabIndex = 48;
            this.gbxManageShowtime.TabStop = false;
            this.gbxManageShowtime.Text = "Manage Showtime";
            // 
            // dtpstartdate
            // 
            this.dtpstartdate.CustomFormat = "yyyy-MM-dd";
            this.dtpstartdate.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpstartdate.Location = new System.Drawing.Point(146, 171);
            this.dtpstartdate.Name = "dtpstartdate";
            this.dtpstartdate.Size = new System.Drawing.Size(277, 29);
            this.dtpstartdate.TabIndex = 41;
            this.dtpstartdate.Value = new System.DateTime(2025, 6, 2, 8, 9, 27, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(18, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 40;
            this.label6.Text = "Start Date:*";
            // 
            // cbxHallNumber
            // 
            this.cbxHallNumber.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxHallNumber.FormattingEnabled = true;
            this.cbxHallNumber.Location = new System.Drawing.Point(144, 127);
            this.cbxHallNumber.Name = "cbxHallNumber";
            this.cbxHallNumber.Size = new System.Drawing.Size(277, 30);
            this.cbxHallNumber.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(16, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 38;
            this.label5.Text = "Hall Number:*";
            // 
            // btnMSDelete
            // 
            this.btnMSDelete.BackColor = System.Drawing.Color.Navy;
            this.btnMSDelete.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMSDelete.ForeColor = System.Drawing.Color.White;
            this.btnMSDelete.Location = new System.Drawing.Point(160, 359);
            this.btnMSDelete.Name = "btnMSDelete";
            this.btnMSDelete.Size = new System.Drawing.Size(122, 36);
            this.btnMSDelete.TabIndex = 37;
            this.btnMSDelete.Text = "Delete";
            this.btnMSDelete.UseVisualStyleBackColor = false;
            this.btnMSDelete.Click += new System.EventHandler(this.btnMSDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(18, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Showtime ID:";
            // 
            // txtShowtimeID
            // 
            this.txtShowtimeID.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowtimeID.Location = new System.Drawing.Point(146, 37);
            this.txtShowtimeID.Name = "txtShowtimeID";
            this.txtShowtimeID.Size = new System.Drawing.Size(71, 29);
            this.txtShowtimeID.TabIndex = 36;
            // 
            // cbxMSTime
            // 
            this.cbxMSTime.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMSTime.FormattingEnabled = true;
            this.cbxMSTime.Items.AddRange(new object[] {
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
            this.cbxMSTime.Location = new System.Drawing.Point(146, 255);
            this.cbxMSTime.Name = "cbxMSTime";
            this.cbxMSTime.Size = new System.Drawing.Size(276, 30);
            this.cbxMSTime.TabIndex = 34;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Navy;
            this.lblTime.Location = new System.Drawing.Point(18, 255);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(54, 22);
            this.lblTime.TabIndex = 33;
            this.lblTime.Text = "Time:*";
            // 
            // dtpenddate
            // 
            this.dtpenddate.CustomFormat = "yyyy-MM-dd";
            this.dtpenddate.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpenddate.Location = new System.Drawing.Point(146, 213);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(277, 29);
            this.dtpenddate.TabIndex = 32;
            this.dtpenddate.Value = new System.DateTime(2025, 6, 2, 8, 9, 27, 0);
            // 
            // cbxSelectMovie
            // 
            this.cbxSelectMovie.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSelectMovie.FormattingEnabled = true;
            this.cbxSelectMovie.Location = new System.Drawing.Point(144, 81);
            this.cbxSelectMovie.Name = "cbxSelectMovie";
            this.cbxSelectMovie.Size = new System.Drawing.Size(277, 30);
            this.cbxSelectMovie.TabIndex = 29;
            this.cbxSelectMovie.SelectedIndexChanged += new System.EventHandler(this.cbxSelectMovie_SelectedIndexChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Navy;
            this.lblDate.Location = new System.Drawing.Point(18, 213);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(84, 22);
            this.lblDate.TabIndex = 28;
            this.lblDate.Text = "End Date:*";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.ForeColor = System.Drawing.Color.Navy;
            this.lblMovieName.Location = new System.Drawing.Point(16, 81);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(105, 22);
            this.lblMovieName.TabIndex = 27;
            this.lblMovieName.Text = "Select Movie:*";
            this.lblMovieName.Click += new System.EventHandler(this.lblMovieName_Click);
            // 
            // btnMSCancel
            // 
            this.btnMSCancel.BackColor = System.Drawing.Color.Navy;
            this.btnMSCancel.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMSCancel.ForeColor = System.Drawing.Color.White;
            this.btnMSCancel.Location = new System.Drawing.Point(299, 317);
            this.btnMSCancel.Name = "btnMSCancel";
            this.btnMSCancel.Size = new System.Drawing.Size(122, 36);
            this.btnMSCancel.TabIndex = 26;
            this.btnMSCancel.Text = "Cancel";
            this.btnMSCancel.UseVisualStyleBackColor = false;
            this.btnMSCancel.Click += new System.EventHandler(this.btnMSCancel_Click);
            // 
            // btnMSMovie
            // 
            this.btnMSMovie.BackColor = System.Drawing.Color.Navy;
            this.btnMSMovie.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMSMovie.ForeColor = System.Drawing.Color.White;
            this.btnMSMovie.Location = new System.Drawing.Point(160, 317);
            this.btnMSMovie.Name = "btnMSMovie";
            this.btnMSMovie.Size = new System.Drawing.Size(122, 36);
            this.btnMSMovie.TabIndex = 24;
            this.btnMSMovie.Text = "Update";
            this.btnMSMovie.UseVisualStyleBackColor = false;
            this.btnMSMovie.Click += new System.EventHandler(this.btnMSMovie_Click);
            // 
            // cbxMSOrderBy
            // 
            this.cbxMSOrderBy.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMSOrderBy.FormattingEnabled = true;
            this.cbxMSOrderBy.Items.AddRange(new object[] {
            "Ascending",
            "Descending",
            ""});
            this.cbxMSOrderBy.Location = new System.Drawing.Point(129, 434);
            this.cbxMSOrderBy.Name = "cbxMSOrderBy";
            this.cbxMSOrderBy.Size = new System.Drawing.Size(200, 30);
            this.cbxMSOrderBy.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(32, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 45;
            this.label3.Text = "Order By:";
            // 
            // cbxMSFilterBy
            // 
            this.cbxMSFilterBy.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMSFilterBy.FormattingEnabled = true;
            this.cbxMSFilterBy.Items.AddRange(new object[] {
            "ID",
            "Movie Name",
            "Hallnumber",
            "Showtime",
            "End Date",
            "Start Date"});
            this.cbxMSFilterBy.Location = new System.Drawing.Point(129, 391);
            this.cbxMSFilterBy.Name = "cbxMSFilterBy";
            this.cbxMSFilterBy.Size = new System.Drawing.Size(200, 30);
            this.cbxMSFilterBy.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(32, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 42;
            this.label1.Text = "Filter By:";
            // 
            // lblTigaCineplex
            // 
            this.lblTigaCineplex.AutoSize = true;
            this.lblTigaCineplex.Font = new System.Drawing.Font("Cooper Black", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTigaCineplex.ForeColor = System.Drawing.Color.Navy;
            this.lblTigaCineplex.Location = new System.Drawing.Point(267, 137);
            this.lblTigaCineplex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTigaCineplex.Name = "lblTigaCineplex";
            this.lblTigaCineplex.Size = new System.Drawing.Size(413, 64);
            this.lblTigaCineplex.TabIndex = 41;
            this.lblTigaCineplex.Text = "Tiga Cineplex";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(36, 83);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(192, 184);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 40;
            this.picLogo.TabStop = false;
            // 
            // lvShowtime
            // 
            this.lvShowtime.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvShowtime.HideSelection = false;
            this.lvShowtime.Location = new System.Drawing.Point(34, 487);
            this.lvShowtime.Name = "lvShowtime";
            this.lvShowtime.Size = new System.Drawing.Size(1212, 286);
            this.lvShowtime.TabIndex = 51;
            this.lvShowtime.UseCompatibleStateImageBehavior = false;
            this.lvShowtime.View = System.Windows.Forms.View.Details;
            this.lvShowtime.SelectedIndexChanged += new System.EventHandler(this.lvShowtime_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Movie name";
            this.columnHeader2.Width = 582;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Hall number";
            this.columnHeader3.Width = 101;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Start Date";
            this.columnHeader4.Width = 157;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "End Date";
            this.columnHeader5.Width = 151;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Showtime";
            this.columnHeader6.Width = 175;
            // 
            // frmManageShowtime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1280, 797);
            this.Controls.Add(this.lvShowtime);
            this.Controls.Add(this.btnMSRefresh);
            this.Controls.Add(this.btnMSApply);
            this.Controls.Add(this.gbxManageShowtime);
            this.Controls.Add(this.cbxMSOrderBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxMSFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTigaCineplex);
            this.Controls.Add(this.picLogo);
            this.Name = "frmManageShowtime";
            this.Text = "Manage Showtime";
            this.Load += new System.EventHandler(this.frmManageShowtime_Load);
            this.gbxManageShowtime.ResumeLayout(false);
            this.gbxManageShowtime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMSRefresh;
        private System.Windows.Forms.Button btnMSApply;
        private System.Windows.Forms.GroupBox gbxManageShowtime;
        private System.Windows.Forms.Button btnMSDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtShowtimeID;
        private System.Windows.Forms.ComboBox cbxMSTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpenddate;
        private System.Windows.Forms.ComboBox cbxSelectMovie;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Button btnMSCancel;
        private System.Windows.Forms.Button btnMSMovie;
        private System.Windows.Forms.ComboBox cbxMSOrderBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxMSFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTigaCineplex;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.DateTimePicker dtpstartdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbxHallNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lvShowtime;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}