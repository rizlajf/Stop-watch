namespace StopWatch
{
    partial class TimerControl
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.SetTimebutton = new System.Windows.Forms.Button();
            this.textBoxHH = new System.Windows.Forms.TextBox();
            this.textBoxMM = new System.Windows.Forms.TextBox();
            this.textBoxSS = new System.Windows.Forms.TextBox();
            this.textBoxMS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.Color.Black;
            this.StartButton.Location = new System.Drawing.Point(22, 78);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(111, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "00:00:00.00";
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(231, 78);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(129, 183);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 3;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // SetTimebutton
            // 
            this.SetTimebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetTimebutton.Location = new System.Drawing.Point(22, 130);
            this.SetTimebutton.Name = "SetTimebutton";
            this.SetTimebutton.Size = new System.Drawing.Size(75, 23);
            this.SetTimebutton.TabIndex = 4;
            this.SetTimebutton.Text = "Set Time";
            this.SetTimebutton.UseVisualStyleBackColor = true;
            this.SetTimebutton.Click += new System.EventHandler(this.SetTimebutton_Click);
            // 
            // textBoxHH
            // 
            this.textBoxHH.Location = new System.Drawing.Point(104, 132);
            this.textBoxHH.Name = "textBoxHH";
            this.textBoxHH.Size = new System.Drawing.Size(34, 20);
            this.textBoxHH.TabIndex = 5;
            this.textBoxHH.Text = "HH";
            // 
            // textBoxMM
            // 
            this.textBoxMM.Location = new System.Drawing.Point(145, 132);
            this.textBoxMM.Name = "textBoxMM";
            this.textBoxMM.Size = new System.Drawing.Size(32, 20);
            this.textBoxMM.TabIndex = 6;
            this.textBoxMM.Text = "MM";
            // 
            // textBoxSS
            // 
            this.textBoxSS.Location = new System.Drawing.Point(184, 132);
            this.textBoxSS.Name = "textBoxSS";
            this.textBoxSS.Size = new System.Drawing.Size(31, 20);
            this.textBoxSS.TabIndex = 7;
            this.textBoxSS.Text = "SS";
            // 
            // textBoxMS
            // 
            this.textBoxMS.Location = new System.Drawing.Point(222, 132);
            this.textBoxMS.Name = "textBoxMS";
            this.textBoxMS.Size = new System.Drawing.Size(32, 20);
            this.textBoxMS.TabIndex = 8;
            this.textBoxMS.Text = "MS";
            this.textBoxMS.Visible = false;
            // 
            // TimerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(327, 234);
            this.Controls.Add(this.textBoxMS);
            this.Controls.Add(this.textBoxSS);
            this.Controls.Add(this.textBoxMM);
            this.Controls.Add(this.textBoxHH);
            this.Controls.Add(this.SetTimebutton);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Name = "TimerControl";
            this.Text = "Stop Watch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Button SetTimebutton;
        private System.Windows.Forms.TextBox textBoxHH;
        private System.Windows.Forms.TextBox textBoxMM;
        private System.Windows.Forms.TextBox textBoxSS;
        private System.Windows.Forms.TextBox textBoxMS;
    }
}