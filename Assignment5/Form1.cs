using System;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        // Initialize radio = 0 and distance = 5 since the 5km radio button is selected by default
        int radio = 0;
        int distance = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Parse time
            int seconds = Convert.ToInt32(txtSeconds.Text);
            int minutes = Convert.ToInt32(txtMinutes.Text);
            int hours = Convert.ToInt32(txtHours.Text);

            // Convert time
            int totalSeconds = seconds + (minutes * 60) + (hours * 3600);
            double totalHours = Convert.ToDouble(totalSeconds) / 3600;
            lblResult.Text = totalHours.ToString();

            // Set distance based on selected radio button
            switch (radio)
            {
                case 0:
                    distance = 5;
                    break;
                case 1:
                    distance = 10;
                    break;
                case 2:
                    distance = 21;
                    break;
            }
            // Calculate kmh
            double speedInKmh = distance / totalHours;

            // Update text label
            lblResult.Text = string.Format("{0:.000}", speedInKmh);
        }

        // Parse radio buttons
        private void rdb5km_CheckedChanged(object sender, EventArgs e)
        {
            radio = 0;
        }

        private void rdb10km_CheckedChanged(object sender, EventArgs e)
        {
            radio = 1;
        }

        private void rdb21km_CheckedChanged(object sender, EventArgs e)
        {
            radio = 2;
        }
    }
}
