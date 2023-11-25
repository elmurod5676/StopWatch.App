
namespace StopWatch
{
    partial class StopWatch
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
            this.watchLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.formTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // watchLabel
            // 
            this.watchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.watchLabel.Location = new System.Drawing.Point(-2, 61);
            this.watchLabel.Name = "watchLabel";
            this.watchLabel.Size = new System.Drawing.Size(968, 234);
            this.watchLabel.TabIndex = 0;
            this.watchLabel.Text = "00:00.00";
            this.watchLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(13, 434);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(299, 99);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(318, 434);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(343, 99);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(667, 434);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(299, 99);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // formTimer
            // 
            this.formTimer.Interval = 10;
            this.formTimer.Tick += new System.EventHandler(this.formTimer_Tick);
            // 
            // StopWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(974, 542);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.watchLabel);
            this.Name = "StopWatch";
            this.Text = "StopWatch";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label watchLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Timer formTimer;
    }
}

