﻿namespace CMPT291_GROUP_PROJECT
{
    partial class searchform
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
            this.titleBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.actorBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.title = new System.Windows.Forms.CheckBox();
            this.genre = new System.Windows.Forms.CheckBox();
            this.actor = new System.Windows.Forms.CheckBox();
            this.year = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(249, 43);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(338, 27);
            this.titleBox.TabIndex = 0;
            this.titleBox.TextChanged += new System.EventHandler(this.titleBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(150, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // actorBox
            // 
            this.actorBox.Location = new System.Drawing.Point(249, 145);
            this.actorBox.Name = "actorBox";
            this.actorBox.Size = new System.Drawing.Size(338, 27);
            this.actorBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(141, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Actor:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(249, 201);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(338, 27);
            this.yearBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(146, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Year:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(134, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Genre:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 27);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Action",
            "Drama",
            "Documentary",
            "Thriller",
            "Romance",
            "Horror"});
            this.genreComboBox.Location = new System.Drawing.Point(249, 93);
            this.genreComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(338, 28);
            this.genreComboBox.TabIndex = 3;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(615, 48);
            this.title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(126, 24);
            this.title.TabIndex = 4;
            this.title.Text = "search by Title";
            this.title.UseVisualStyleBackColor = true;
            this.title.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // genre
            // 
            this.genre.AutoSize = true;
            this.genre.Location = new System.Drawing.Point(615, 101);
            this.genre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(136, 24);
            this.genre.TabIndex = 5;
            this.genre.Text = "search by Genre";
            this.genre.UseVisualStyleBackColor = true;
            this.genre.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // actor
            // 
            this.actor.AutoSize = true;
            this.actor.Location = new System.Drawing.Point(615, 151);
            this.actor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.actor.Name = "actor";
            this.actor.Size = new System.Drawing.Size(133, 24);
            this.actor.TabIndex = 6;
            this.actor.Text = "search by Actor";
            this.actor.UseVisualStyleBackColor = true;
            this.actor.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // year
            // 
            this.year.AutoSize = true;
            this.year.Location = new System.Drawing.Point(615, 207);
            this.year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(125, 24);
            this.year.TabIndex = 7;
            this.year.Text = "search by year";
            this.year.UseVisualStyleBackColor = true;
            this.year.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // searchform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.year);
            this.Controls.Add(this.actor);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.title);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.actorBox);
            this.Controls.Add(this.titleBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "searchform";
            this.Text = "searchform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        public TextBox titleBox;
        public TextBox actorBox;
        public TextBox yearBox;
        public Button button1;
        private ComboBox genreComboBox;
        private CheckBox title;
        private CheckBox genre;
        private CheckBox actor;
        private CheckBox year;
    }
}