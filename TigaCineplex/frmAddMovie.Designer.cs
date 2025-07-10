namespace TigaCineplex
{
    partial class frmAddMovie
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
            this.gbxAddMovie = new System.Windows.Forms.GroupBox();
            this.cbxRating = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.cbxGenre = new System.Windows.Forms.ComboBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.gbxAddMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAddMovie
            // 
            this.gbxAddMovie.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gbxAddMovie.Controls.Add(this.cbxRating);
            this.gbxAddMovie.Controls.Add(this.label1);
            this.gbxAddMovie.Controls.Add(this.btnCancel);
            this.gbxAddMovie.Controls.Add(this.btnSave);
            this.gbxAddMovie.Controls.Add(this.txtDescription);
            this.gbxAddMovie.Controls.Add(this.txtDuration);
            this.gbxAddMovie.Controls.Add(this.cbxGenre);
            this.gbxAddMovie.Controls.Add(this.txtMovieName);
            this.gbxAddMovie.Controls.Add(this.lblDescription);
            this.gbxAddMovie.Controls.Add(this.lblGenre);
            this.gbxAddMovie.Controls.Add(this.lblDuration);
            this.gbxAddMovie.Controls.Add(this.lblMovieName);
            this.gbxAddMovie.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddMovie.ForeColor = System.Drawing.Color.Navy;
            this.gbxAddMovie.Location = new System.Drawing.Point(31, 36);
            this.gbxAddMovie.Name = "gbxAddMovie";
            this.gbxAddMovie.Size = new System.Drawing.Size(566, 568);
            this.gbxAddMovie.TabIndex = 1;
            this.gbxAddMovie.TabStop = false;
            this.gbxAddMovie.Text = "Add Movie - * required";
            // 
            // cbxRating
            // 
            this.cbxRating.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbxRating.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxRating.FormattingEnabled = true;
            this.cbxRating.Items.AddRange(new object[] {
            "PG-13",
            "PG-16",
            "X RATED",
            "R RATED"});
            this.cbxRating.Location = new System.Drawing.Point(206, 170);
            this.cbxRating.Name = "cbxRating";
            this.cbxRating.Size = new System.Drawing.Size(208, 35);
            this.cbxRating.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(43, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rating:*";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Navy;
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(353, 482);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 45);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Navy;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(194, 482);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 45);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDescription.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(206, 289);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(300, 174);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.Text = "";
            // 
            // txtDuration
            // 
            this.txtDuration.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDuration.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuration.Location = new System.Drawing.Point(206, 228);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(270, 34);
            this.txtDuration.TabIndex = 10;
            // 
            // cbxGenre
            // 
            this.cbxGenre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbxGenre.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGenre.FormattingEnabled = true;
            this.cbxGenre.Items.AddRange(new object[] {
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
            this.cbxGenre.Location = new System.Drawing.Point(206, 118);
            this.cbxGenre.Name = "cbxGenre";
            this.cbxGenre.Size = new System.Drawing.Size(208, 35);
            this.cbxGenre.TabIndex = 8;
            // 
            // txtMovieName
            // 
            this.txtMovieName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMovieName.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMovieName.Location = new System.Drawing.Point(206, 64);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(300, 34);
            this.txtMovieName.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblDescription.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.Navy;
            this.lblDescription.Location = new System.Drawing.Point(43, 287);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(131, 27);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:*";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblGenre.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Navy;
            this.lblGenre.Location = new System.Drawing.Point(43, 114);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(80, 27);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "Genre:*";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblDuration.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuration.ForeColor = System.Drawing.Color.Navy;
            this.lblDuration.Location = new System.Drawing.Point(41, 227);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(107, 27);
            this.lblDuration.TabIndex = 2;
            this.lblDuration.Text = "Duration:*";
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblMovieName.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.ForeColor = System.Drawing.Color.Navy;
            this.lblMovieName.Location = new System.Drawing.Point(43, 66);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(140, 27);
            this.lblMovieName.TabIndex = 1;
            this.lblMovieName.Text = "Movie Name:*";
            // 
            // frmAddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(641, 634);
            this.Controls.Add(this.gbxAddMovie);
            this.Name = "frmAddMovie";
            this.Text = "Add Movie";
            this.Load += new System.EventHandler(this.frmAddMovie_Load);
            this.gbxAddMovie.ResumeLayout(false);
            this.gbxAddMovie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAddMovie;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.ComboBox cbxGenre;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.ComboBox cbxRating;
        private System.Windows.Forms.Label label1;
    }
}