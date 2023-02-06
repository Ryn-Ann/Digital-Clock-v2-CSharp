using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Digital Clock v2 
 * A simple digital clock written in C# in VS using Windows Form Apps
 *  
 * Noor Kamaruddin Feb 6, 2023
 */

namespace Digital_Clock_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                
        private void timerClock_Tick(object sender, EventArgs e)
        {
            // Contents of the digital clock
            labelTime.Text = DateTime.Now.ToString("HH:mm");
            labelSeconds.Text = DateTime.Now.ToString("ss");
            labelDate.Text = DateTime.Now.ToString("d MMMM yyyy");
            labelDay.Text = DateTime.Now.ToString("dddd");

            // Fixed the position of the Seconds label
            labelSeconds.Location = new Point(labelTime.Location.X + labelTime.Width - 15, labelSeconds.Location.Y);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerClock.Start();
        }
    }
}
