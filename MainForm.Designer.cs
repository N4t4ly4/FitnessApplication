namespace NDMyFitnessApp
{
    partial class mainForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.lblTodayIs = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnMyBmr = new System.Windows.Forms.Button();
            this.btnMyTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblWelcome.Location = new System.Drawing.Point(9, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(174, 24);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome Natalya!";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.Location = new System.Drawing.Point(103, 71);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(75, 23);
            this.btnMyProfile.TabIndex = 3;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.UseVisualStyleBackColor = true;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // lblTodayIs
            // 
            this.lblTodayIs.AutoSize = true;
            this.lblTodayIs.Location = new System.Drawing.Point(205, 201);
            this.lblTodayIs.Name = "lblTodayIs";
            this.lblTodayIs.Size = new System.Drawing.Size(50, 13);
            this.lblTodayIs.TabIndex = 4;
            this.lblTodayIs.Text = "Today is:";
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Location = new System.Drawing.Point(181, 226);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 23);
            this.lblDate.TabIndex = 5;
            this.lblDate.Text = "label1";
            // 
            // btnMyBmr
            // 
            this.btnMyBmr.Location = new System.Drawing.Point(103, 100);
            this.btnMyBmr.Name = "btnMyBmr";
            this.btnMyBmr.Size = new System.Drawing.Size(75, 23);
            this.btnMyBmr.TabIndex = 6;
            this.btnMyBmr.Text = "My BMR";
            this.btnMyBmr.UseVisualStyleBackColor = true;
            this.btnMyBmr.Click += new System.EventHandler(this.btnMyBmr_Click);
            // 
            // btnMyTimer
            // 
            this.btnMyTimer.Location = new System.Drawing.Point(103, 129);
            this.btnMyTimer.Name = "btnMyTimer";
            this.btnMyTimer.Size = new System.Drawing.Size(75, 23);
            this.btnMyTimer.TabIndex = 7;
            this.btnMyTimer.Text = "My Timer";
            this.btnMyTimer.UseVisualStyleBackColor = true;
            this.btnMyTimer.Click += new System.EventHandler(this.btnMyTimer_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnMyTimer);
            this.Controls.Add(this.btnMyBmr);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTodayIs);
            this.Controls.Add(this.btnMyProfile);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWelcome);
            this.Name = "mainForm";
            this.Text = "My Fitness App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.Label lblTodayIs;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnMyBmr;
        private System.Windows.Forms.Button btnMyTimer;
    }
}

