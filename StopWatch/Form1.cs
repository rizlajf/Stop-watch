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
using System.Windows.Threading;

namespace StopWatch
{
    public partial class StopWatch : Form
    {
        DispatcherTimer dt = new DispatcherTimer();
        // Create new stopwatch.
        Stopwatch stopwatch = new Stopwatch();
        string currentTime = string.Empty;

        public StopWatch()
        {
            InitializeComponent();
            //dt.Tick += new EventHandler(dt_Tick);
        }

        private void StartBotton_Click(object sender, EventArgs e)
        {    
            // Begin timing.
            stopwatch.Start();
            dt.Start();
            //while (true)
            //{
            //    TimeSpan ts = stopwatch.Elapsed;
            //    currentTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //    ts.Hours, ts.Minutes, ts.Seconds,
            //    ts.Milliseconds / 10);
            //    label1.Text = currentTime;
            //    //TimeSpan timeSpan = TimeSpan.FromSeconds(Convert.ToInt32(stopwatch.Elapsed.TotalSeconds));
            //    //label1.Text = timeSpan.ToString("c");
            //    //Console.Write(timeSpan.ToString("c"));
            //    //Console.Write('\r');
            //}

            // Get the elapsed time as a TimeSpan value.
            //TimeSpan ts = stopwatch.Elapsed;

            // Format and display the TimeSpan value.
            //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            //    ts.Hours, ts.Minutes, ts.Seconds,
            //    ts.Milliseconds / 10);
        }

        void dt_Tick(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                TimeSpan ts = stopwatch.Elapsed;
                currentTime = String.Format("{0:00}:{1:00}:{2:00}",
                    ts.Hours, ts.Minutes, ts.Seconds);
                label1.Text = currentTime;
            }
        }
    }
}
