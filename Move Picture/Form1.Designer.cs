﻿namespace Move_Picture
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Up = new System.Windows.Forms.Button();
            this.Left = new System.Windows.Forms.Button();
            this.Right = new System.Windows.Forms.Button();
            this.Bottom = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Move_Picture.Properties.Resources.DIVOCK_ORIGI;
            this.pictureBox1.Location = new System.Drawing.Point(163, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(606, 189);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(75, 32);
            this.Up.TabIndex = 3;
            this.Up.Text = "Up";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.Up_Click);
            // 
            // Left
            // 
            this.Left.Location = new System.Drawing.Point(538, 231);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(92, 33);
            this.Left.TabIndex = 4;
            this.Left.Text = "Left";
            this.Left.UseVisualStyleBackColor = true;
            this.Left.Click += new System.EventHandler(this.Left_Click);
            // 
            // Right
            // 
            this.Right.Location = new System.Drawing.Point(667, 231);
            this.Right.Name = "Right";
            this.Right.Size = new System.Drawing.Size(82, 33);
            this.Right.TabIndex = 5;
            this.Right.Text = "Right";
            this.Right.UseVisualStyleBackColor = true;
            this.Right.Click += new System.EventHandler(this.Right_Click);
            // 
            // Bottom
            // 
            this.Bottom.Location = new System.Drawing.Point(606, 270);
            this.Bottom.Name = "Bottom";
            this.Bottom.Size = new System.Drawing.Size(75, 35);
            this.Bottom.TabIndex = 6;
            this.Bottom.Text = "Bottom";
            this.Bottom.UseVisualStyleBackColor = true;
            this.Bottom.Click += new System.EventHandler(this.Bottom_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(57, 365);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(114, 39);
            this.Square.TabIndex = 7;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Triangle
            // 
            this.Triangle.Location = new System.Drawing.Point(57, 281);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(114, 52);
            this.Triangle.TabIndex = 8;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.Bottom);
            this.Controls.Add(this.Right);
            this.Controls.Add(this.Left);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Left;
        private System.Windows.Forms.Button Right;
        private System.Windows.Forms.Button Bottom;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Triangle;
    }
}

