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
        int setTime = 0;

        public TimerControl()
        {
            InitializeComponent();         
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            hideSetTime();

            // Begin timing.
            objStopWatch.Start();
            StartButton.Enabled = false;
            StopButton.Text = objStopWatch.IsRunning ? "Pause" : "Stop";
            StartButton.Text = StartButton.Enabled ? "Start" : "Resume";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (objStopWatch.IsRunning)
            {
                TimeSpan objTimeSpan = TimeSpan.FromMilliseconds(objStopWatch.ElapsedMilliseconds);
                label1.Text = String.Format(CultureInfo.CurrentCulture, "{0:00}:{1:00}:{2:00}.{3:00}", objTimeSpan.Hours, objTimeSpan.Minutes, objTimeSpan.Seconds, objTimeSpan.Milliseconds / 10);

                if(setTime > 0)
                {
                    
                    if (objTimeSpan.Seconds == setTime)
                        objStopWatch.Stop();
                }                

                if (paused)
                {
                    paused = false;
                }
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            objStopWatch.Stop();
            StartButton.Enabled = true;
            StopButton.Text = objStopWatch.IsRunning ? "Pause" : "Stop";
            StartButton.Text = StartButton.Enabled ? "Start" : "Resume";
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            label1.Text = "00:00:00.00";
            objStopWatch.Reset();
            StartButton.Text = "Start";
            StopButton.Text = "Stop";
        }

        private void SetTimebutton_Click(object sender, EventArgs e)
        {
            objStopWatch.Reset();
            hideAutoStopWatch();

            int hh = !String.IsNullOrEmpty(textBoxHH.Text) && textBoxHH.Text != "HH" ? Convert.ToInt32(textBoxHH.Text) : 0;
            int mm = !String.IsNullOrEmpty(textBoxMM.Text) && textBoxMM.Text != "MM" ? Convert.ToInt32(textBoxMM.Text) : 0;
            int ss = !String.IsNullOrEmpty(textBoxSS.Text) && textBoxSS.Text != "SS" ? Convert.ToInt32(textBoxSS.Text) : 0;
            int ms = !String.IsNullOrEmpty(textBoxMS.Text) && textBoxMS.Text != "MS" ? Convert.ToInt32(textBoxMS.Text) : 0;

            setTime = hh * 60 * 60 + mm * 60 + ss;

            // Begin timing.
            objStopWatch.Start();
        }

        private void hideSetTime()
        {
            SetTimebutton.Visible = false;
            textBoxHH.Visible = false;
            textBoxMM.Visible = false;
            textBoxSS.Visible = false;
        }

        private void hideAutoStopWatch()
        {
            StartButton.Visible = false;
            StopButton.Visible = false;
        }
    }
}
