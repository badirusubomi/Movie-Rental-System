﻿namespace CMPT291_GROUP_PROJECT
{
    partial class searchResultForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.searchResult = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectMovie = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Result:";
            // 
            // searchResult
            // 
            this.searchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Title,
            this.Genre,
            this.Year,
            this.Fee,
            this.Rating});
            this.searchResult.Location = new System.Drawing.Point(31, 87);
            this.searchResult.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchResult.Name = "searchResult";
            this.searchResult.RowHeadersWidth = 51;
            this.searchResult.RowTemplate.Height = 25;
            this.searchResult.Size = new System.Drawing.Size(850, 167);
            this.searchResult.TabIndex = 2;
            this.searchResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.searchResult_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "movieID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Title
            // 
            this.Title.HeaderText = "title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Title.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Genre
            // 
            this.Genre.HeaderText = "Genre";
            this.Genre.MinimumWidth = 6;
            this.Genre.Name = "Genre";
            this.Genre.ReadOnly = true;
            // 
            // Year
            // 
            this.Year.HeaderText = "year";
            this.Year.MinimumWidth = 6;
            this.Year.Name = "Year";
            this.Year.ReadOnly = true;
            // 
            // Fee
            // 
            this.Fee.HeaderText = "Fee";
            this.Fee.MinimumWidth = 6;
            this.Fee.Name = "Fee";
            this.Fee.ReadOnly = true;
            // 
            // Rating
            // 
            this.Rating.HeaderText = "rating";
            this.Rating.MinimumWidth = 6;
            this.Rating.Name = "Rating";
            this.Rating.ReadOnly = true;
            // 
            // SelectMovie
            // 
            this.SelectMovie.Location = new System.Drawing.Point(690, 260);
            this.SelectMovie.Name = "SelectMovie";
            this.SelectMovie.Size = new System.Drawing.Size(191, 49);
            this.SelectMovie.TabIndex = 1;
            this.SelectMovie.Text = "Pick Movie";
            this.SelectMovie.UseVisualStyleBackColor = true;
            this.SelectMovie.Click += new System.EventHandler(this.SelectMovie_Click);
            // 
            // searchResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(895, 324);
            this.Controls.Add(this.searchResult);
            this.Controls.Add(this.SelectMovie);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "searchResultForm";
            this.Text = "searchResultForm";
            this.Load += new System.EventHandler(this.searchResultForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView searchResult;
        private Button SelectMovie;
        private DataGridViewButtonColumn ID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn Fee;
        private DataGridViewTextBoxColumn Rating;
    }
}