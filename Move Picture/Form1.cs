﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Move_Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void Up_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y - 5 > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 25);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, 0);
            }

        }


        private void Left_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X - 5 > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 25, pictureBox1.Location.Y);
            }
            else
            {
                pictureBox1.Location = new Point(0, pictureBox1.Location.Y);
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.X + 5 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 25, pictureBox1.Location.Y);
            }
        }

        private void Bottom_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Location.Y + 5 < ClientRectangle.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 25);
            }
            else
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, ClientRectangle.Height - pictureBox1.Height);
            }
        }

        private async void Square_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 50, pictureBox1.Location.Y);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 50);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X - 50, pictureBox1.Location.Y);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 50);
            await Task.Delay(500);
        }

        private async void Triangle_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 25, pictureBox1.Location.Y + 50);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X - 50, pictureBox1.Location.Y);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X + 25, pictureBox1.Location.Y - 50);
            await Task.Delay(500);
        }

        private async void Left2_Click(object sender, EventArgs e)
        {
            while (pictureBox1.Location.X - 5 > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X - 25, pictureBox1.Location.Y);
                await Task.Delay(100);
            }
        }

        private async void Up2_Click(object sender, EventArgs e)
        {
            while (pictureBox1.Location.Y - 5 > 0)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 25);
                await Task.Delay(100);
            }
        }

        private async void Right2_Click(object sender, EventArgs e)
        {
            while (pictureBox1.Location.X + 5 < ClientRectangle.Width - pictureBox1.Width)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + 25, pictureBox1.Location.Y);
                await Task.Delay(100);
            }
        }

        private async void Bottom2_Click(object sender, EventArgs e)
        {
            while (pictureBox1.Location.Y + 5 < ClientRectangle.Height - pictureBox1.Height)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 25);
                await Task.Delay(100);
            }
        }
    }
}
