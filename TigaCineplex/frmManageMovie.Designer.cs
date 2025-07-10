namespace TigaCineplex
{
    partial class frmManageMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageMovie));
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.gbxManageMovie = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxRating = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtMGDescription = new System.Windows.Forms.RichTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtMGDuration = new System.Windows.Forms.TextBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.cbxMGGenre = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtMGMovieName = new System.Windows.Forms.TextBox();
            this.lvMovie = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxOrderBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxFilterBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTigaCineplex = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.gbxManageMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Navy;
            this.btnRefresh.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(646, 344);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(122, 36);
            this.btnRefresh.TabIndex = 39;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.Navy;
            this.btnApply.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.White;
            this.btnApply.Location = new System.Drawing.Point(504, 343);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(122, 36);
            this.btnApply.TabIndex = 38;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // gbxManageMovie
            // 
            this.gbxManageMovie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbxManageMovie.Controls.Add(this.label5);
            this.gbxManageMovie.Controls.Add(this.cbxRating);
            this.gbxManageMovie.Controls.Add(this.label4);
            this.gbxManageMovie.Controls.Add(this.txtMovieID);
            this.gbxManageMovie.Controls.Add(this.btnCancel);
            this.gbxManageMovie.Controls.Add(this.btnDelete);
            this.gbxManageMovie.Controls.Add(this.txtMGDescription);
            this.gbxManageMovie.Controls.Add(this.btnUpdate);
            this.gbxManageMovie.Controls.Add(this.lblMovieName);
            this.gbxManageMovie.Controls.Add(this.lblDuration);
            this.gbxManageMovie.Controls.Add(this.txtMGDuration);
            this.gbxManageMovie.Controls.Add(this.lblGenre);
            this.gbxManageMovie.Controls.Add(this.cbxMGGenre);
            this.gbxManageMovie.Controls.Add(this.lblDescription);
            this.gbxManageMovie.Controls.Add(this.txtMGMovieName);
            this.gbxManageMovie.Font = new System.Drawing.Font("Palatino Linotype", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxManageMovie.ForeColor = System.Drawing.Color.Navy;
            this.gbxManageMovie.Location = new System.Drawing.Point(807, 232);
            this.gbxManageMovie.Name = "gbxManageMovie";
            this.gbxManageMovie.Size = new System.Drawing.Size(441, 477);
            this.gbxManageMovie.TabIndex = 37;
            this.gbxManageMovie.TabStop = false;
            this.gbxManageMovie.Text = "Manage Movie";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 29;
            this.label5.Text = "Rating:*";
            // 
            // cbxRating
            // 
            this.cbxRating.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRating.FormattingEnabled = true;
            this.cbxRating.Items.AddRange(new object[] {
            "PG-13",
            "PG-16",
            "X RATED",
            "R RATED"});
            this.cbxRating.Location = new System.Drawing.Point(151, 168);
            this.cbxRating.Name = "cbxRating";
            this.cbxRating.Size = new System.Drawing.Size(177, 30);
            this.cbxRating.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "Movie ID:";
            // 
            // txtMovieID
            // 
            this.txtMovieID.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieID.Location = new System.Drawing.Point(152, 42);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(71, 29);
            this.txtMovieID.TabIndex = 28;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Navy;
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(298, 378);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(122, 36);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Navy;
            this.btnDelete.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(159, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 36);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtMGDescription
            // 
            this.txtMGDescription.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMGDescription.Location = new System.Drawing.Point(151, 257);
            this.txtMGDescription.Name = "txtMGDescription";
            this.txtMGDescription.Size = new System.Drawing.Size(269, 114);
            this.txtMGDescription.TabIndex = 23;
            this.txtMGDescription.Text = "";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Navy;
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(159, 378);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 36);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(24, 83);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(108, 22);
            this.lblMovieName.TabIndex = 14;
            this.lblMovieName.Text = "Movie Name:*";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.Location = new System.Drawing.Point(23, 214);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(81, 22);
            this.lblDuration.TabIndex = 15;
            this.lblDuration.Text = "Duration:*";
            // 
            // txtMGDuration
            // 
            this.txtMGDuration.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMGDuration.Location = new System.Drawing.Point(151, 214);
            this.txtMGDuration.Name = "txtMGDuration";
            this.txtMGDuration.Size = new System.Drawing.Size(239, 29);
            this.txtMGDuration.TabIndex = 22;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.Location = new System.Drawing.Point(24, 122);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(61, 22);
            this.lblGenre.TabIndex = 17;
            this.lblGenre.Text = "Genre:*";
            // 
            // cbxMGGenre
            // 
            this.cbxMGGenre.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMGGenre.FormattingEnabled = true;
            this.cbxMGGenre.Items.AddRange(new object[] {
            "Horror",
            "Action",
            "Thriller",
            "Science Fiction",
            "Drama",
            "Romance",
            "Comedy",
            "Animation",
            "Adventure",
            "Musical",
            "Fantasy",
            "Rom-Com"});
            this.cbxMGGenre.Location = new System.Drawing.Point(152, 122);
            this.cbxMGGenre.Name = "cbxMGGenre";
            this.cbxMGGenre.Size = new System.Drawing.Size(177, 30);
            this.cbxMGGenre.TabIndex = 20;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(23, 257);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(97, 22);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Description:*";
            // 
            // txtMGMovieName
            // 
            this.txtMGMovieName.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMGMovieName.Location = new System.Drawing.Point(152, 81);
            this.txtMGMovieName.Name = "txtMGMovieName";
            this.txtMGMovieName.Size = new System.Drawing.Size(269, 29);
            this.txtMGMovieName.TabIndex = 19;
            // 
            // lvMovie
            // 
            this.lvMovie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4});
            this.lvMovie.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvMovie.HideSelection = false;
            this.lvMovie.Location = new System.Drawing.Point(42, 429);
            this.lvMovie.Name = "lvMovie";
            this.lvMovie.Size = new System.Drawing.Size(728, 279);
            this.lvMovie.TabIndex = 36;
            this.lvMovie.UseCompatibleStateImageBehavior = false;
            this.lvMovie.View = System.Windows.Forms.View.Details;
            this.lvMovie.SelectedIndexChanged += new System.EventHandler(this.lvMovie_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Movie Name";
            this.columnHeader2.Width = 261;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Genre";
            this.columnHeader3.Width = 195;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Duration";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Rating";
            this.columnHeader4.Width = 151;
            // 
            // cbxOrderBy
            // 
            this.cbxOrderBy.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxOrderBy.FormattingEnabled = true;
            this.cbxOrderBy.Items.AddRange(new object[] {
            "Ascending",
            "Descending"});
            this.cbxOrderBy.Location = new System.Drawing.Point(137, 347);
            this.cbxOrderBy.Name = "cbxOrderBy";
            this.cbxOrderBy.Size = new System.Drawing.Size(200, 30);
            this.cbxOrderBy.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(40, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 34;
            this.label3.Text = "Order By:";
            // 
            // cbxFilterBy
            // 
            this.cbxFilterBy.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxFilterBy.FormattingEnabled = true;
            this.cbxFilterBy.Items.AddRange(new object[] {
            "ID",
            "Movie Name",
            "Genre",
            "Hall Number",
            "Duration"});
            this.cbxFilterBy.Location = new System.Drawing.Point(137, 304);
            this.cbxFilterBy.Name = "cbxFilterBy";
            this.cbxFilterBy.Size = new System.Drawing.Size(200, 30);
            this.cbxFilterBy.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 22);
            this.label2.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(40, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 31;
            this.label1.Text = "Filter By:";
            // 
            // lblTigaCineplex
            // 
            this.lblTigaCineplex.AutoSize = true;
            this.lblTigaCineplex.Font = new System.Drawing.Font("Cooper Black", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTigaCineplex.ForeColor = System.Drawing.Color.Navy;
            this.lblTigaCineplex.Location = new System.Drawing.Point(273, 87);
            this.lblTigaCineplex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTigaCineplex.Name = "lblTigaCineplex";
            this.lblTigaCineplex.Size = new System.Drawing.Size(413, 64);
            this.lblTigaCineplex.TabIndex = 30;
            this.lblTigaCineplex.Text = "Tiga Cineplex";
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(42, 33);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(192, 183);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 29;
            this.picLogo.TabStop = false;
            // 
            // frmManageMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1295, 741);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.gbxManageMovie);
            this.Controls.Add(this.lvMovie);
            this.Controls.Add(this.cbxOrderBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxFilterBy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTigaCineplex);
            this.Controls.Add(this.picLogo);
            this.Name = "frmManageMovie";
            this.Text = "Manage Movie";
            this.Load += new System.EventHandler(this.frmManageMovie_Load);
            this.gbxManageMovie.ResumeLayout(false);
            this.gbxManageMovie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox gbxManageMovie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.RichTextBox txtMGDescription;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtMGDuration;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.ComboBox cbxMGGenre;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtMGMovieName;
        private System.Windows.Forms.ListView lvMovie;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox cbxOrderBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxFilterBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTigaCineplex;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxRating;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}