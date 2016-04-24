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
        System.Timers.Timer mainTimer;
        int randomResultPosition;
        int correctedCount;

        public Form1()
        {
            InitializeComponent();
            RadResult1.Visible = false;
            RadResult2.Visible = false;
            RadResult3.Visible = false;
            RadResult4.Visible = false;

            label5.Visible = false;
            LabelNum1.Visible = false;
            LabelNum2.Visible = false;
            LabelArithmetic.Visible = false;
            LabelPercent.Visible = false;

            //http://codereview.stackexchange.com/questions/93224/proper-use-of-timer-in-windows-service
            mainTimer = new System.Timers.Timer();
            mainTimer.Interval = 10000;
            mainTimer.Elapsed += mainTimer_Eslaped;
      

            timerTickProgress.Interval = 1000;
            timerTickProgress.Tick += new EventHandler(timerTickProgress_Tick);

            progressBar1.Maximum = 10;
        }

        void mainTimer_Eslaped(Object sender, System.Timers.ElapsedEventArgs e)
        {
            switch(randomResultPosition)
            {
                case 1:
                    if (RadResult1.Checked)
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

        void timerTickProgress_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 10)
            {
                progressBar1.Visible = true;
                progressBar1.Increment(1);
                LabelPercent.Text = (progressBar1.Value*10).ToString() + " % Time Esplapted";
            }
            else
            {
                timerTickProgress.Stop();
                progressBar1.Value = 0;
            }
        }

        

        private void BtnStart_Click(object sender, EventArgs e)
        {
            RadResult1.Visible = true;
            RadResult2.Visible = true;
            RadResult3.Visible = true;
            RadResult4.Visible = true;

            label5.Visible = true;
            LabelNum1.Visible = true;
            LabelNum2.Visible = true;
            LabelArithmetic.Visible = true;
            LabelPercent.Visible = true;

            Random rnd = new Random();
            int num1 = rnd.Next(0, 10);
            int num2 = rnd.Next(0, 10);
            int arith = rnd.Next(1, 4);
            LabelNum1.Text = num1.ToString();
            LabelNum2.Text = num2.ToString();
            string arithText = "";
            int resultNumber = 0;

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
            LabelArithmetic.Text = arithText;
            label5.Text = "=?";

            randomResultPosition = rnd.Next(1, 4);
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
            timerTickProgress.Start();
            mainTimer.Start();
        }
    }
}
