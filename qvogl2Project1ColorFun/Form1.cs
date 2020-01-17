using System;
using System.Drawing;
using System.Windows.Forms;

namespace qvogl2Project1ColorFun
{
    public partial class Form1 : Form
    {
        PictureBox colorSquare = new PictureBox();
        public Form1()
        {
            InitializeComponent();

            colorSquare = pictureBox1;
            colorSquare.BackColor = Color.FromArgb(0,0,0,0);
            redBit.Text = "0";
            greenBit.Text = "0";
            blueBit.Text = "0";
            alphaBit.Text = "0";
        }

        private void redTrackBar_Scroll(object sender, EventArgs e)
        {
            colorSquare.BackColor = Color.FromArgb(alphaTrackBar.Value, redTrackBar.Value, colorSquare.BackColor.G, 
                colorSquare.BackColor.B);
            redBit.Text = redTrackBar.Value.ToString();
        }

        private void greenTrackBar_Scroll(object sender, EventArgs e)
        {
            colorSquare.BackColor = Color.FromArgb(alphaTrackBar.Value, colorSquare.BackColor.R, greenTrackBar.Value,
                colorSquare.BackColor.B);
            greenBit.Text = greenTrackBar.Value.ToString();
        }

        private void blueTrackBar_Scroll(object sender, EventArgs e)
        {
            colorSquare.BackColor = Color.FromArgb(alphaTrackBar.Value, colorSquare.BackColor.R, colorSquare.BackColor.G,
                            blueTrackBar.Value);
            blueBit.Text = blueTrackBar.Value.ToString();
        }

        private void alphaTrackBar_Scroll(object sender, EventArgs e)
        {
            try
            {
                colorSquare.BackColor = Color.FromArgb(alphaTrackBar.Value, colorSquare.BackColor.R,
                    colorSquare.BackColor.G, colorSquare.BackColor.B);
                alphaBit.Text = alphaTrackBar.Value.ToString();
            }
            catch (System.DivideByZeroException ex)
            {
                
            }
        }
    }
}
