namespace StopWatch
{
    partial class FormsTimer
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
            this.FormsTimerStartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FormsTimerStartButton
            // 
            this.FormsTimerStartButton.Location = new System.Drawing.Point(33, 186);
            this.FormsTimerStartButton.Name = "FormsTimerStartButton";
            this.FormsTimerStartButton.Size = new System.Drawing.Size(75, 23);
            this.FormsTimerStartButton.TabIndex = 0;
            this.FormsTimerStartButton.Text = "Start";
            this.FormsTimerStartButton.UseVisualStyleBackColor = true;
            this.FormsTimerStartButton.Click += new System.EventHandler(this.FormsTimerStartButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // FormsTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FormsTimerStartButton);
            this.Name = "FormsTimer";
            this.Text = "FormsTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FormsTimerStartButton;
        private System.Windows.Forms.Label label1;
    }
}