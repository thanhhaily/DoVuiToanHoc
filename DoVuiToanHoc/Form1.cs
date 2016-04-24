using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace DoVuiToanHoc
{
    public partial class Form1 : Form
    {
        //Declare main timer
        System.Timers.Timer mainTimer;
        //This number shows random the position of the corrected result 
        //in radio buttons (1-4)
        int randomResultPosition;
        //The number of time user has been corrected
        int correctedCount;

        public Form1()
        {
            InitializeComponent();
            //Set invisible radio buttons and labels
            RadResult1.Visible = false;
            RadResult2.Visible = false;
            RadResult3.Visible = false;
            RadResult4.Visible = false;

            label5.Visible = false;
            LabelNum1.Visible = false;
            LabelNum2.Visible = false;
            LabelArithmetic.Visible = false;
            LabelPercent.Visible = false;

            //Create main timer
            //http://codereview.stackexchange.com/questions/93224/proper-use-of-timer-in-windows-service
            mainTimer = new System.Timers.Timer();
            mainTimer.Interval = 5000;
            mainTimer.Elapsed += mainTimer_Eslaped;

            //Create timer for progressbar, which is increase 1 value in 1 second
            timerTickProgress.Interval = 1000;
            timerTickProgress.Tick += new EventHandler(timerTickProgress_Tick);

            //Set maximum value for progress bar
            progressBar1.Maximum = 5;
        }

        /// <summary>
        /// This method run then main timer due time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void mainTimer_Eslaped(Object sender, System.Timers.ElapsedEventArgs e)
        {
            //Check if the radio button checked == randomResultPosition
            switch (randomResultPosition)
            {
                case 1:
                    if (RadResult1.Checked)
                    {
                        mainTimer.Stop();
                        correctedCount++;
                        MessageBox.Show("Corrected! Your score: " + correctedCount);
                        // does not work
                        //this.Dispose();
                    }
                    else
                    {
                        mainTimer.Stop();
                        MessageBox.Show("Time out!");
                    }
                    break;
                case 2:
                    if (RadResult2.Checked)
                    {
                        mainTimer.Stop();
                        correctedCount++;
                        MessageBox.Show("Corrected! Your score: " + correctedCount);
                    }
                    else
                    {
                        mainTimer.Stop();
                        MessageBox.Show("Time out!");
                    }
                    break;
                case 3:
                    if (RadResult3.Checked)
                    {
                        mainTimer.Stop();
                        correctedCount++;
                        MessageBox.Show("Corrected! Your score: " + correctedCount);
                    }
                    else
                    {
                        mainTimer.Stop();
                        MessageBox.Show("Time out!");
                    }
                    break;
                case 4:
                    if (RadResult4.Checked)
                    {
                        mainTimer.Stop();
                        correctedCount++;
                        MessageBox.Show("Corrected! Your score: " + correctedCount);
                    }
                    else
                    {
                        mainTimer.Stop();
                        MessageBox.Show("Time out!");
                    }
                    break;
            }
        }

        /// <summary>
        /// This method run when progressbar timer due time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timerTickProgress_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 5)
            {
                progressBar1.Visible = true;
                progressBar1.Increment(1);
                LabelPercent.Text = (progressBar1.Value * 20).ToString() + " % Time Esplapted";
            }
            else
            {
                timerTickProgress.Stop();
                progressBar1.Value = 0;
            }
        }

        /// <summary>
        /// This method run when you click Start button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //When Start button was clicked, show these components
            RadResult1.Visible = true;
            RadResult2.Visible = true;
            RadResult3.Visible = true;
            RadResult4.Visible = true;

            label5.Visible = true;
            LabelNum1.Visible = true;
            LabelNum2.Visible = true;
            LabelArithmetic.Visible = true;
            LabelPercent.Visible = true;

            //Create a random object
            Random rnd = new Random();
            //First random number
            int num1 = rnd.Next(0, 10);
            //Second random number
            int num2 = rnd.Next(0, 10);
            //Only 4 arithmetric (+ - * /)
            int arith = rnd.Next(1, 4);
            //Set text for number 1
            LabelNum1.Text = num1.ToString();
            //Set text for number 2
            LabelNum2.Text = num2.ToString();
            //Arithmetric text
            string arithText = "";
            //The corrected result
            int resultNumber = 0;

            //Switch throught 4 arithmetric to do
            //the calculation
            switch (arith)
            {
                case 1:
                    arithText = "+";
                    resultNumber = num1 + num2;
                    break;
                case 2:
                    arithText = "-";
                    resultNumber = num1 - num2;
                    break;
                case 3:
                    arithText = "x";
                    resultNumber = num1 * num2;
                    break;
                case 4:
                    arithText = "/";
                    resultNumber = num1 / num2;
                    break;
            }
            //Set text for arithmetric label
            LabelArithmetic.Text = arithText;
            //Set text for the label
            label5.Text = "=?";

            //Put the result in random position in the 4 radio buttons
            //Create random position (1-4)
            randomResultPosition = rnd.Next(1, 4);
            //Switch through 4 random position
            //and add text to it respectively
            switch (randomResultPosition)
            {
                case 1:
                    RadResult1.Text = resultNumber.ToString();
                    RadResult2.Text = (resultNumber - 1).ToString();
                    RadResult3.Text = (resultNumber + 1).ToString();
                    RadResult4.Text = (resultNumber + 2).ToString();
                    break;
                case 2:
                    RadResult2.Text = resultNumber.ToString();
                    RadResult1.Text = (resultNumber - 1).ToString();
                    RadResult3.Text = (resultNumber + 1).ToString();
                    RadResult4.Text = (resultNumber + 2).ToString();
                    break;
                case 3:
                    RadResult3.Text = resultNumber.ToString();
                    RadResult1.Text = (resultNumber - 1).ToString();
                    RadResult2.Text = (resultNumber + 1).ToString();
                    RadResult4.Text = (resultNumber + 2).ToString();
                    break;
                case 4:
                    RadResult4.Text = resultNumber.ToString();
                    RadResult2.Text = (resultNumber - 1).ToString();
                    RadResult3.Text = (resultNumber + 1).ToString();
                    RadResult1.Text = (resultNumber + 2).ToString();
                    break;
            }
            //Start the progressbar timer
            timerTickProgress.Start();
            //Start the main timer
            mainTimer.Start();
        }
    }
}
