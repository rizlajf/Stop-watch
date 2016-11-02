using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class FormsTimer : Form
    {

        Timer tmr = null;

        public FormsTimer()
        {
            InitializeComponent();
        }

        private void FormsTimerStartButton_Click(object sender, EventArgs e)
        {
            tmr = new Timer();
            //tmr.Interval = 1000;
            tmr.Tick += new EventHandler(tmr_Tick);
            tmr.Enabled = true;
        }

        void tmr_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
