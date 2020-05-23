namespace Math_Quiz
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
            this.startButton = new System.Windows.Forms.Button();
            this.firstNumberLabel = new System.Windows.Forms.Label();
            this.additionLabel = new System.Windows.Forms.Label();
            this.SecondNumberLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.thirdNumberLabel = new System.Windows.Forms.Label();
            this.substractionLabel = new System.Windows.Forms.Label();
            this.fourthNumberLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fivethNumberLabel = new System.Windows.Forms.Label();
            this.multiplicationLabel = new System.Windows.Forms.Label();
            this.sixthNumberLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.seventhNumberLabel = new System.Windows.Forms.Label();
            this.divisionLabel = new System.Windows.Forms.Label();
            this.eightthNumberLabel = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.secondsTextbox = new System.Windows.Forms.TextBox();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            this.finishButton = new System.Windows.Forms.Button();
            this.additionTextbox = new System.Windows.Forms.TextBox();
            this.substractionTextbox = new System.Windows.Forms.TextBox();
            this.multiplicationTextbox = new System.Windows.Forms.TextBox();
            this.divisionTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Thistle;
            this.startButton.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Purple;
            this.startButton.Location = new System.Drawing.Point(43, 31);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(223, 56);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start the Quiz!";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // firstNumberLabel
            // 
            this.firstNumberLabel.AutoSize = true;
            this.firstNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.firstNumberLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.firstNumberLabel.Location = new System.Drawing.Point(107, 142);
            this.firstNumberLabel.Name = "firstNumberLabel";
            this.firstNumberLabel.Size = new System.Drawing.Size(61, 16);
            this.firstNumberLabel.TabIndex = 1;
            this.firstNumberLabel.Text = "(number)";
            // 
            // additionLabel
            // 
            this.additionLabel.AutoSize = true;
            this.additionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.additionLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.additionLabel.Location = new System.Drawing.Point(169, 142);
            this.additionLabel.Name = "additionLabel";
            this.additionLabel.Size = new System.Drawing.Size(15, 16);
            this.additionLabel.TabIndex = 2;
            this.additionLabel.Text = "+";
            // 
            // SecondNumberLabel
            // 
            this.SecondNumberLabel.AutoSize = true;
            this.SecondNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.SecondNumberLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.SecondNumberLabel.Location = new System.Drawing.Point(205, 142);
            this.SecondNumberLabel.Name = "SecondNumberLabel";
            this.SecondNumberLabel.Size = new System.Drawing.Size(61, 16);
            this.SecondNumberLabel.TabIndex = 3;
            this.SecondNumberLabel.Text = "(number)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(277, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "=";
            // 
            // thirdNumberLabel
            // 
            this.thirdNumberLabel.AutoSize = true;
            this.thirdNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.thirdNumberLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.thirdNumberLabel.Location = new System.Drawing.Point(107, 180);
            this.thirdNumberLabel.Name = "thirdNumberLabel";
            this.thirdNumberLabel.Size = new System.Drawing.Size(61, 16);
            this.thirdNumberLabel.TabIndex = 5;
            this.thirdNumberLabel.Text = "(number)";
            // 
            // substractionLabel
            // 
            this.substractionLabel.AutoSize = true;
            this.substractionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.substractionLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.substractionLabel.Location = new System.Drawing.Point(172, 180);
            this.substractionLabel.Name = "substractionLabel";
            this.substractionLabel.Size = new System.Drawing.Size(12, 16);
            this.substractionLabel.TabIndex = 6;
            this.substractionLabel.Text = "-";
            // 
            // fourthNumberLabel
            // 
            this.fourthNumberLabel.AutoSize = true;
            this.fourthNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.fourthNumberLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.fourthNumberLabel.Location = new System.Drawing.Point(205, 180);
            this.fourthNumberLabel.Name = "fourthNumberLabel";
            this.fourthNumberLabel.Size = new System.Drawing.Size(61, 16);
            this.fourthNumberLabel.TabIndex = 7;
            this.fourthNumberLabel.Text = "(number)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label8.Location = new System.Drawing.Point(277, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 8;
            this.label8.Text = "=";
            // 
            // fivethNumberLabel
            // 
            this.fivethNumberLabel.AutoSize = true;
            this.fivethNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.fivethNumberLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.fivethNumberLabel.Location = new System.Drawing.Point(107, 222);
            this.fivethNumberLabel.Name = "fivethNumberLabel";
            this.fivethNumberLabel.Size = new System.Drawing.Size(61, 16);
            this.fivethNumberLabel.TabIndex = 9;
            this.fivethNumberLabel.Text = "(number)";
            // 
            // multiplicationLabel
            // 
            this.multiplicationLabel.AutoSize = true;
            this.multiplicationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.multiplicationLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.multiplicationLabel.Location = new System.Drawing.Point(172, 222);
            this.multiplicationLabel.Name = "multiplicationLabel";
            this.multiplicationLabel.Size = new System.Drawing.Size(14, 16);
            this.multiplicationLabel.TabIndex = 10;
            this.multiplicationLabel.Text = "x";
            // 
            // sixthNumberLabel
            // 
            this.sixthNumberLabel.AutoSize = true;
            this.sixthNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.sixthNumberLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.sixthNumberLabel.Location = new System.Drawing.Point(205, 222);
            this.sixthNumberLabel.Name = "sixthNumberLabel";
            this.sixthNumberLabel.Size = new System.Drawing.Size(61, 16);
            this.sixthNumberLabel.TabIndex = 11;
            this.sixthNumberLabel.Text = "(number)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label12.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label12.Location = new System.Drawing.Point(277, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "=";
            // 
            // seventhNumberLabel
            // 
            this.seventhNumberLabel.AutoSize = true;
            this.seventhNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.seventhNumberLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.seventhNumberLabel.Location = new System.Drawing.Point(107, 264);
            this.seventhNumberLabel.Name = "seventhNumberLabel";
            this.seventhNumberLabel.Size = new System.Drawing.Size(61, 16);
            this.seventhNumberLabel.TabIndex = 13;
            this.seventhNumberLabel.Text = "(number)";
            // 
            // divisionLabel
            // 
            this.divisionLabel.AutoSize = true;
            this.divisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.divisionLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.divisionLabel.Location = new System.Drawing.Point(169, 264);
            this.divisionLabel.Name = "divisionLabel";
            this.divisionLabel.Size = new System.Drawing.Size(12, 16);
            this.divisionLabel.TabIndex = 14;
            this.divisionLabel.Text = "/";
            // 
            // eightthNumberLabel
            // 
            this.eightthNumberLabel.AutoSize = true;
            this.eightthNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.eightthNumberLabel.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.eightthNumberLabel.Location = new System.Drawing.Point(205, 264);
            this.eightthNumberLabel.Name = "eightthNumberLabel";
            this.eightthNumberLabel.Size = new System.Drawing.Size(61, 16);
            this.eightthNumberLabel.TabIndex = 15;
            this.eightthNumberLabel.Text = "(number)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label16.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label16.Location = new System.Drawing.Point(277, 264);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 16);
            this.label16.TabIndex = 16;
            this.label16.Text = "=";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.timeLabel.ForeColor = System.Drawing.Color.Purple;
            this.timeLabel.Location = new System.Drawing.Point(407, 31);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(169, 20);
            this.timeLabel.TabIndex = 21;
            this.timeLabel.Text = "Time Left (in seconds):";
            // 
            // secondsTextbox
            // 
            this.secondsTextbox.Location = new System.Drawing.Point(411, 67);
            this.secondsTextbox.Name = "secondsTextbox";
            this.secondsTextbox.Size = new System.Drawing.Size(100, 20);
            this.secondsTextbox.TabIndex = 22;
            this.secondsTextbox.Text = "80";
            // 
            // timeTimer
            // 
            this.timeTimer.Interval = 1000;
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // finishButton
            // 
            this.finishButton.BackColor = System.Drawing.Color.Thistle;
            this.finishButton.Font = new System.Drawing.Font("Footlight MT Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishButton.ForeColor = System.Drawing.Color.Purple;
            this.finishButton.Location = new System.Drawing.Point(43, 363);
            this.finishButton.Name = "finishButton";
            this.finishButton.Size = new System.Drawing.Size(223, 65);
            this.finishButton.TabIndex = 23;
            this.finishButton.Text = "Finish the Quiz!";
            this.finishButton.UseVisualStyleBackColor = false;
            this.finishButton.Click += new System.EventHandler(this.finishButton_Click);
            // 
            // additionTextbox
            // 
            this.additionTextbox.Location = new System.Drawing.Point(308, 142);
            this.additionTextbox.Name = "additionTextbox";
            this.additionTextbox.Size = new System.Drawing.Size(100, 20);
            this.additionTextbox.TabIndex = 24;
            this.additionTextbox.Text = "0";
            // 
            // substractionTextbox
            // 
            this.substractionTextbox.Location = new System.Drawing.Point(308, 176);
            this.substractionTextbox.Name = "substractionTextbox";
            this.substractionTextbox.Size = new System.Drawing.Size(100, 20);
            this.substractionTextbox.TabIndex = 25;
            this.substractionTextbox.Text = "0";
            // 
            // multiplicationTextbox
            // 
            this.multiplicationTextbox.Location = new System.Drawing.Point(308, 218);
            this.multiplicationTextbox.Name = "multiplicationTextbox";
            this.multiplicationTextbox.Size = new System.Drawing.Size(100, 20);
            this.multiplicationTextbox.TabIndex = 26;
            this.multiplicationTextbox.Text = "0";
            // 
            // divisionTextbox
            // 
            this.divisionTextbox.Location = new System.Drawing.Point(308, 260);
            this.divisionTextbox.Name = "divisionTextbox";
            this.divisionTextbox.Size = new System.Drawing.Size(100, 20);
            this.divisionTextbox.TabIndex = 27;
            this.divisionTextbox.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(651, 482);
            this.Controls.Add(this.divisionTextbox);
            this.Controls.Add(this.multiplicationTextbox);
            this.Controls.Add(this.substractionTextbox);
            this.Controls.Add(this.additionTextbox);
            this.Controls.Add(this.finishButton);
            this.Controls.Add(this.secondsTextbox);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.eightthNumberLabel);
            this.Controls.Add(this.divisionLabel);
            this.Controls.Add(this.seventhNumberLabel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.sixthNumberLabel);
            this.Controls.Add(this.multiplicationLabel);
            this.Controls.Add(this.fivethNumberLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fourthNumberLabel);
            this.Controls.Add(this.substractionLabel);
            this.Controls.Add(this.thirdNumberLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SecondNumberLabel);
            this.Controls.Add(this.additionLabel);
            this.Controls.Add(this.firstNumberLabel);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Math Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label firstNumberLabel;
        private System.Windows.Forms.Label additionLabel;
        private System.Windows.Forms.Label SecondNumberLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label thirdNumberLabel;
        private System.Windows.Forms.Label substractionLabel;
        private System.Windows.Forms.Label fourthNumberLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label fivethNumberLabel;
        private System.Windows.Forms.Label multiplicationLabel;
        private System.Windows.Forms.Label sixthNumberLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label seventhNumberLabel;
        private System.Windows.Forms.Label divisionLabel;
        private System.Windows.Forms.Label eightthNumberLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.TextBox secondsTextbox;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Button finishButton;
        private System.Windows.Forms.TextBox additionTextbox;
        private System.Windows.Forms.TextBox substractionTextbox;
        private System.Windows.Forms.TextBox multiplicationTextbox;
        private System.Windows.Forms.TextBox divisionTextbox;
    }
}

