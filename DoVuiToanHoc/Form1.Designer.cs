namespace DoVuiToanHoc
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelNum1 = new System.Windows.Forms.Label();
            this.LabelArithmetic = new System.Windows.Forms.Label();
            this.LabelNum2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RadResult1 = new System.Windows.Forms.RadioButton();
            this.RadResult2 = new System.Windows.Forms.RadioButton();
            this.RadResult3 = new System.Windows.Forms.RadioButton();
            this.RadResult4 = new System.Windows.Forms.RadioButton();
            this.BtnStart = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timerTickProgress = new System.Windows.Forms.Timer(this.components);
            this.LabelPercent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đố vui toán học";
            // 
            // LabelNum1
            // 
            this.LabelNum1.AutoSize = true;
            this.LabelNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNum1.ForeColor = System.Drawing.Color.OrangeRed;
            this.LabelNum1.Location = new System.Drawing.Point(36, 62);
            this.LabelNum1.Name = "LabelNum1";
            this.LabelNum1.Size = new System.Drawing.Size(49, 18);
            this.LabelNum1.TabIndex = 1;
            this.LabelNum1.Text = "quest";
            // 
            // LabelArithmetic
            // 
            this.LabelArithmetic.AutoSize = true;
            this.LabelArithmetic.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelArithmetic.ForeColor = System.Drawing.Color.OrangeRed;
            this.LabelArithmetic.Location = new System.Drawing.Point(91, 62);
            this.LabelArithmetic.Name = "LabelArithmetic";
            this.LabelArithmetic.Size = new System.Drawing.Size(49, 18);
            this.LabelArithmetic.TabIndex = 2;
            this.LabelArithmetic.Text = "quest";
            // 
            // LabelNum2
            // 
            this.LabelNum2.AutoSize = true;
            this.LabelNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNum2.ForeColor = System.Drawing.Color.OrangeRed;
            this.LabelNum2.Location = new System.Drawing.Point(141, 62);
            this.LabelNum2.Name = "LabelNum2";
            this.LabelNum2.Size = new System.Drawing.Size(49, 18);
            this.LabelNum2.TabIndex = 3;
            this.LabelNum2.Text = "quest";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(196, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "quest";
            // 
            // RadResult1
            // 
            this.RadResult1.AutoSize = true;
            this.RadResult1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadResult1.ForeColor = System.Drawing.Color.LimeGreen;
            this.RadResult1.Location = new System.Drawing.Point(58, 111);
            this.RadResult1.Name = "RadResult1";
            this.RadResult1.Size = new System.Drawing.Size(68, 29);
            this.RadResult1.TabIndex = 5;
            this.RadResult1.TabStop = true;
            this.RadResult1.Text = "ans";
            this.RadResult1.UseVisualStyleBackColor = true;
            // 
            // RadResult2
            // 
            this.RadResult2.AutoSize = true;
            this.RadResult2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadResult2.ForeColor = System.Drawing.Color.LimeGreen;
            this.RadResult2.Location = new System.Drawing.Point(58, 162);
            this.RadResult2.Name = "RadResult2";
            this.RadResult2.Size = new System.Drawing.Size(68, 29);
            this.RadResult2.TabIndex = 6;
            this.RadResult2.TabStop = true;
            this.RadResult2.Text = "ans";
            this.RadResult2.UseVisualStyleBackColor = true;
            // 
            // RadResult3
            // 
            this.RadResult3.AutoSize = true;
            this.RadResult3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadResult3.ForeColor = System.Drawing.Color.LimeGreen;
            this.RadResult3.Location = new System.Drawing.Point(149, 111);
            this.RadResult3.Name = "RadResult3";
            this.RadResult3.Size = new System.Drawing.Size(68, 29);
            this.RadResult3.TabIndex = 7;
            this.RadResult3.TabStop = true;
            this.RadResult3.Text = "ans";
            this.RadResult3.UseVisualStyleBackColor = true;
            // 
            // RadResult4
            // 
            this.RadResult4.AutoSize = true;
            this.RadResult4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RadResult4.ForeColor = System.Drawing.Color.LimeGreen;
            this.RadResult4.Location = new System.Drawing.Point(149, 162);
            this.RadResult4.Name = "RadResult4";
            this.RadResult4.Size = new System.Drawing.Size(68, 29);
            this.RadResult4.TabIndex = 8;
            this.RadResult4.TabStop = true;
            this.RadResult4.Text = "ans";
            this.RadResult4.UseVisualStyleBackColor = true;
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(197, 227);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(75, 23);
            this.BtnStart.TabIndex = 9;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 226);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // LabelPercent
            // 
            this.LabelPercent.AutoSize = true;
            this.LabelPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPercent.ForeColor = System.Drawing.Color.DarkBlue;
            this.LabelPercent.Location = new System.Drawing.Point(12, 259);
            this.LabelPercent.Name = "LabelPercent";
            this.LabelPercent.Size = new System.Drawing.Size(0, 16);
            this.LabelPercent.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 290);
            this.Controls.Add(this.LabelPercent);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.RadResult4);
            this.Controls.Add(this.RadResult3);
            this.Controls.Add(this.RadResult2);
            this.Controls.Add(this.RadResult1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabelNum2);
            this.Controls.Add(this.LabelArithmetic);
            this.Controls.Add(this.LabelNum1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelNum1;
        private System.Windows.Forms.Label LabelArithmetic;
        private System.Windows.Forms.Label LabelNum2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RadResult1;
        private System.Windows.Forms.RadioButton RadResult2;
        private System.Windows.Forms.RadioButton RadResult3;
        private System.Windows.Forms.RadioButton RadResult4;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timerTickProgress;
        private System.Windows.Forms.Label LabelPercent;
    }
}

