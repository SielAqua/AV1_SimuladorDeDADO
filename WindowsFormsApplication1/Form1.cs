using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
 
    public partial class Form1 : Form
    {
        public int minValue = 0;
        public int maxValue = 5;

        Random randomNumber = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Randomizer_Click(object sender, EventArgs e)
        {
           int Result = randomNumber.Next(minValue, maxValue);
           label1.Text = Result.ToString();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value == 0)
            {
                maxValue = 5;
            }

            else if (trackBar1.Value == 1)
            {
                maxValue = 7;
            }

            else if(trackBar1.Value == 2)
            {
                maxValue = 9;
            }

            else if (trackBar1.Value == 3)
            {
                maxValue = 11;
            }

            else if (trackBar1.Value == 4)
            {
                maxValue = 13;
            }

            else if (trackBar1.Value == 5)
            {
                maxValue = 21;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
