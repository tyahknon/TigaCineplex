namespace TigaCineplex
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.gbxTickets = new System.Windows.Forms.GroupBox();
            this.btnIssueTickets = new System.Windows.Forms.Button();
            this.picMovies = new System.Windows.Forms.PictureBox();
            this.picTickets = new System.Windows.Forms.PictureBox();
            this.gbxShowtimes = new System.Windows.Forms.GroupBox();
            this.btnCreateShowtimes = new System.Windows.Forms.Button();
            this.btnManageShowtimes = new System.Windows.Forms.Button();
            this.picShowtimes = new System.Windows.Forms.PictureBox();
            this.gbxMovies = new System.Windows.Forms.GroupBox();
            this.btnAddMovies = new System.Windows.Forms.Button();
            this.btnManageMovies = new System.Windows.Forms.Button();
            this.gbxTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTickets)).BeginInit();
            this.gbxShowtimes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShowtimes)).BeginInit();
            this.gbxMovies.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxTickets
            // 
            this.gbxTickets.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxTickets.Controls.Add(this.btnIssueTickets);
            this.gbxTickets.Controls.Add(this.picMovies);
            this.gbxTickets.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTickets.Location = new System.Drawing.Point(434, 434);
            this.gbxTickets.Name = "gbxTickets";
            this.gbxTickets.Size = new System.Drawing.Size(492, 315);
            this.gbxTickets.TabIndex = 10;
            this.gbxTickets.TabStop = false;
            this.gbxTickets.Text = "Tickets";
            // 
            // btnIssueTickets
            // 
            this.btnIssueTickets.BackColor = System.Drawing.Color.Navy;
            this.btnIssueTickets.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueTickets.ForeColor = System.Drawing.Color.White;
            this.btnIssueTickets.Location = new System.Drawing.Point(74, 238);
            this.btnIssueTickets.Name = "btnIssueTickets";
            this.btnIssueTickets.Size = new System.Drawing.Size(344, 39);
            this.btnIssueTickets.TabIndex = 1;
            this.btnIssueTickets.Text = "Issue Tickets";
            this.btnIssueTickets.UseVisualStyleBackColor = false;
            this.btnIssueTickets.Click += new System.EventHandler(this.btnIssueTickets_Click);
            // 
            // picMovies
            // 
            this.picMovies.Image = ((System.Drawing.Image)(resources.GetObject("picMovies.Image")));
            this.picMovies.Location = new System.Drawing.Point(169, 61);
            this.picMovies.Name = "picMovies";
            this.picMovies.Size = new System.Drawing.Size(147, 144);
            this.picMovies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMovies.TabIndex = 0;
            this.picMovies.TabStop = false;
            // 
            // picTickets
            // 
            this.picTickets.Image = ((System.Drawing.Image)(resources.GetObject("picTickets.Image")));
            this.picTickets.Location = new System.Drawing.Point(177, 41);
            this.picTickets.Name = "picTickets";
            this.picTickets.Size = new System.Drawing.Size(147, 144);
            this.picTickets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTickets.TabIndex = 0;
            this.picTickets.TabStop = false;
            this.picTickets.Click += new System.EventHandler(this.picTickets_Click);
            // 
            // gbxShowtimes
            // 
            this.gbxShowtimes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxShowtimes.Controls.Add(this.btnCreateShowtimes);
            this.gbxShowtimes.Controls.Add(this.btnManageShowtimes);
            this.gbxShowtimes.Controls.Add(this.picShowtimes);
            this.gbxShowtimes.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxShowtimes.Location = new System.Drawing.Point(759, 60);
            this.gbxShowtimes.Name = "gbxShowtimes";
            this.gbxShowtimes.Size = new System.Drawing.Size(492, 315);
            this.gbxShowtimes.TabIndex = 9;
            this.gbxShowtimes.TabStop = false;
            this.gbxShowtimes.Text = "Showtimes";
            // 
            // btnCreateShowtimes
            // 
            this.btnCreateShowtimes.BackColor = System.Drawing.Color.Navy;
            this.btnCreateShowtimes.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateShowtimes.ForeColor = System.Drawing.Color.White;
            this.btnCreateShowtimes.Location = new System.Drawing.Point(75, 250);
            this.btnCreateShowtimes.Name = "btnCreateShowtimes";
            this.btnCreateShowtimes.Size = new System.Drawing.Size(344, 39);
            this.btnCreateShowtimes.TabIndex = 2;
            this.btnCreateShowtimes.Text = "Create Showtimes";
            this.btnCreateShowtimes.UseVisualStyleBackColor = false;
            this.btnCreateShowtimes.Click += new System.EventHandler(this.btnCreateShowtimes_Click);
            // 
            // btnManageShowtimes
            // 
            this.btnManageShowtimes.BackColor = System.Drawing.Color.Navy;
            this.btnManageShowtimes.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageShowtimes.ForeColor = System.Drawing.Color.White;
            this.btnManageShowtimes.Location = new System.Drawing.Point(75, 205);
            this.btnManageShowtimes.Name = "btnManageShowtimes";
            this.btnManageShowtimes.Size = new System.Drawing.Size(344, 39);
            this.btnManageShowtimes.TabIndex = 1;
            this.btnManageShowtimes.Text = "Manage Showtimes";
            this.btnManageShowtimes.UseVisualStyleBackColor = false;
            this.btnManageShowtimes.Click += new System.EventHandler(this.btnManageShowtimes_Click);
            // 
            // picShowtimes
            // 
            this.picShowtimes.Image = ((System.Drawing.Image)(resources.GetObject("picShowtimes.Image")));
            this.picShowtimes.Location = new System.Drawing.Point(175, 42);
            this.picShowtimes.Name = "picShowtimes";
            this.picShowtimes.Size = new System.Drawing.Size(147, 144);
            this.picShowtimes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShowtimes.TabIndex = 0;
            this.picShowtimes.TabStop = false;
            // 
            // gbxMovies
            // 
            this.gbxMovies.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxMovies.Controls.Add(this.btnAddMovies);
            this.gbxMovies.Controls.Add(this.picTickets);
            this.gbxMovies.Controls.Add(this.btnManageMovies);
            this.gbxMovies.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMovies.Location = new System.Drawing.Point(138, 60);
            this.gbxMovies.Name = "gbxMovies";
            this.gbxMovies.Size = new System.Drawing.Size(492, 315);
            this.gbxMovies.TabIndex = 8;
            this.gbxMovies.TabStop = false;
            this.gbxMovies.Text = "Movies";
            // 
            // btnAddMovies
            // 
            this.btnAddMovies.BackColor = System.Drawing.Color.Navy;
            this.btnAddMovies.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovies.ForeColor = System.Drawing.Color.White;
            this.btnAddMovies.Location = new System.Drawing.Point(75, 250);
            this.btnAddMovies.Name = "btnAddMovies";
            this.btnAddMovies.Size = new System.Drawing.Size(344, 39);
            this.btnAddMovies.TabIndex = 2;
            this.btnAddMovies.Text = "Add Movies";
            this.btnAddMovies.UseVisualStyleBackColor = false;
            this.btnAddMovies.Click += new System.EventHandler(this.btnAddMovies_Click);
            // 
            // btnManageMovies
            // 
            this.btnManageMovies.BackColor = System.Drawing.Color.Navy;
            this.btnManageMovies.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMovies.ForeColor = System.Drawing.Color.White;
            this.btnManageMovies.Location = new System.Drawing.Point(75, 205);
            this.btnManageMovies.Name = "btnManageMovies";
            this.btnManageMovies.Size = new System.Drawing.Size(344, 39);
            this.btnManageMovies.TabIndex = 1;
            this.btnManageMovies.Text = "Manage Movies";
            this.btnManageMovies.UseVisualStyleBackColor = false;
            this.btnManageMovies.Click += new System.EventHandler(this.btnManageMovies_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1373, 806);
            this.Controls.Add(this.gbxTickets);
            this.Controls.Add(this.gbxShowtimes);
            this.Controls.Add(this.gbxMovies);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.gbxTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTickets)).EndInit();
            this.gbxShowtimes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShowtimes)).EndInit();
            this.gbxMovies.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxTickets;
        private System.Windows.Forms.Button btnIssueTickets;
        private System.Windows.Forms.PictureBox picTickets;
        private System.Windows.Forms.GroupBox gbxShowtimes;
        private System.Windows.Forms.Button btnCreateShowtimes;
        private System.Windows.Forms.Button btnManageShowtimes;
        private System.Windows.Forms.PictureBox picShowtimes;
        private System.Windows.Forms.GroupBox gbxMovies;
        private System.Windows.Forms.Button btnAddMovies;
        private System.Windows.Forms.Button btnManageMovies;
        private System.Windows.Forms.PictureBox picMovies;
    }
}