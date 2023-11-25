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
    public partial class StopWatch : Form
    {
        private DateTime startTime;
        private TimeSpan time = new TimeSpan(0);
        private TimeSpan interval = new TimeSpan(0);

        public StopWatch()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;

            formTimer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            formTimer.Stop();

            interval = time;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            formTimer.Stop();

            // boshlang'ich vaziyatga qaytarish
            time = new TimeSpan(0);
            interval = new TimeSpan(0);

            Print(time);
        }

        private void formTimer_Tick(object sender, EventArgs e)
        {
            //Calculate how long it's been start
            time = startTime - DateTime.Now;

            // ishlash jarayonida pauza qilingan vaqt intervalini qo'shamiz
            time += interval;

            Print(time);
        }

        private void Print(TimeSpan time)
        {
            watchLabel.Text = time.ToString(@"mm\:ss\.ff");
        }
    }
}
