using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yilan_oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            KeyPreview = true;
        }
        string yon = "";
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                yon = "Sağ";
            }
            else if (e.KeyCode == Keys.Left)
            {
                yon = "Sol";
            }
            else if (e.KeyCode == Keys.Up)
            {
                yon = "Yukarı";
            }
            else if (e.KeyCode == Keys.Down)
            {
                yon = "Aşağı";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        Random rnd = new Random();
        int puan = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (yon == "Sağ")
            {
                pictureBox1.Left += 1;
                label1.Text = (pictureBox1.Location.X + pictureBox1.Width).ToString();
                label2.Text = pictureBox1.Location.Y.ToString();

                label3.Text = pictureBox2.Location.X.ToString();
                label4.Text = pictureBox2.Location.Y.ToString();
            }
            else
           if (yon == "Sol")
            {
                pictureBox1.Left -= 1;
                label1.Text = (pictureBox1.Location.X + pictureBox1.Width).ToString();
                label2.Text = pictureBox1.Location.Y.ToString();

                label3.Text = pictureBox2.Location.X.ToString();
                label4.Text = pictureBox2.Location.Y.ToString();
            }
            else
               if (yon == "Yukarı")
            {
                pictureBox1.Top -= 1;
                label1.Text = (pictureBox1.Location.X + pictureBox1.Width).ToString();
                label2.Text = pictureBox1.Location.Y.ToString();

                label3.Text = pictureBox2.Location.X.ToString();
                label4.Text = pictureBox2.Location.Y.ToString();
            }
            else
               if (yon == "Aşağı")
            {
                pictureBox1.Top += 1;
                label1.Text = (pictureBox1.Location.X + pictureBox1.Width).ToString();
                label2.Text = pictureBox1.Location.Y.ToString();

                label3.Text = (pictureBox1.Location.X + pictureBox1.Width).ToString();
                label4.Text = pictureBox2.Location.Y.ToString();
            }

            if (pictureBox1.Location.X + pictureBox1.Width == pictureBox2.Location.X)
            {
                pictureBox2.Location = new Point(rnd.Next(1, 800), rnd.Next(1, 800));
                puan += 5;

                label5.Text = puan.ToString();
            }
        }
    }
}
