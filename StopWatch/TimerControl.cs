using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace StopWatch
{
    public partial class TimerControl : Form
    {
        Stopwatch objStopWatch = new Stopwatch();
        bool paused = false;

        public TimerControl()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // Begin timing.
            objStopWatch.Start();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (objStopWatch.IsRunning)
            {
                TimeSpan objTimeSpan = TimeSpan.FromMilliseconds(objStopWatch.ElapsedMilliseconds);
                label1.Text = String.Format(CultureInfo.CurrentCulture, "{0:00}:{1:00}:{2:00}.{3:00}", objTimeSpan.Hours, objTimeSpan.Minutes, objTimeSpan.Seconds, objTimeSpan.Milliseconds / 10);

                if (paused)
                {
                    paused = false;
                }
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            objStopWatch.Stop();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            label1.Text = "00:00:00.00";
            objStopWatch.Reset();
        }
    }
}
