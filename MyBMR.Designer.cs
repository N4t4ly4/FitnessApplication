namespace NDMyFitnessApp
{
    partial class formMyBMR
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
            this.btnCalcBMR = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lstBoxActivityLvl = new System.Windows.Forms.ListBox();
            this.lblActivityLvl = new System.Windows.Forms.Label();
            this.grpBoxGender = new System.Windows.Forms.GroupBox();
            this.rButtonFemale = new System.Windows.Forms.RadioButton();
            this.rButtonMale = new System.Windows.Forms.RadioButton();
            this.lblMyBmr = new System.Windows.Forms.Label();
            this.lblMyBmrVal = new System.Windows.Forms.Label();
            this.grpBoxGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcBMR
            // 
            this.btnCalcBMR.Location = new System.Drawing.Point(306, 189);
            this.btnCalcBMR.Name = "btnCalcBMR";
            this.btnCalcBMR.Size = new System.Drawing.Size(124, 45);
            this.btnCalcBMR.TabIndex = 0;
            this.btnCalcBMR.Text = "Calculate BMR";
            this.btnCalcBMR.UseVisualStyleBackColor = true;
            this.btnCalcBMR.Click += new System.EventHandler(this.btnCalcBMR_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 300);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lstBoxActivityLvl
            // 
            this.lstBoxActivityLvl.FormattingEnabled = true;
            this.lstBoxActivityLvl.Items.AddRange(new object[] {
            "Little to no excercise",
            "Light exercise (1-3 days a week)",
            "Moderate exercise (3-5 days a week)",
            "Heavy exercise (6-7 days per week)",
            "Very heavy exercise (twice a day)"});
            this.lstBoxActivityLvl.Location = new System.Drawing.Point(12, 47);
            this.lstBoxActivityLvl.Name = "lstBoxActivityLvl";
            this.lstBoxActivityLvl.Size = new System.Drawing.Size(193, 95);
            this.lstBoxActivityLvl.TabIndex = 6;
            // 
            // lblActivityLvl
            // 
            this.lblActivityLvl.AutoSize = true;
            this.lblActivityLvl.Location = new System.Drawing.Point(13, 28);
            this.lblActivityLvl.Name = "lblActivityLvl";
            this.lblActivityLvl.Size = new System.Drawing.Size(127, 13);
            this.lblActivityLvl.TabIndex = 7;
            this.lblActivityLvl.Text = "Choose an Activity Level:";
            // 
            // grpBoxGender
            // 
            this.grpBoxGender.Controls.Add(this.rButtonFemale);
            this.grpBoxGender.Controls.Add(this.rButtonMale);
            this.grpBoxGender.Location = new System.Drawing.Point(12, 159);
            this.grpBoxGender.Name = "grpBoxGender";
            this.grpBoxGender.Size = new System.Drawing.Size(200, 100);
            this.grpBoxGender.TabIndex = 8;
            this.grpBoxGender.TabStop = false;
            this.grpBoxGender.Text = "Gender";
            // 
            // rButtonFemale
            // 
            this.rButtonFemale.AutoSize = true;
            this.rButtonFemale.Checked = true;
            this.rButtonFemale.Location = new System.Drawing.Point(26, 58);
            this.rButtonFemale.Name = "rButtonFemale";
            this.rButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.rButtonFemale.TabIndex = 1;
            this.rButtonFemale.TabStop = true;
            this.rButtonFemale.Text = "Female";
            this.rButtonFemale.UseVisualStyleBackColor = true;
            // 
            // rButtonMale
            // 
            this.rButtonMale.AutoSize = true;
            this.rButtonMale.Location = new System.Drawing.Point(26, 20);
            this.rButtonMale.Name = "rButtonMale";
            this.rButtonMale.Size = new System.Drawing.Size(48, 17);
            this.rButtonMale.TabIndex = 0;
            this.rButtonMale.Text = "Male";
            this.rButtonMale.UseVisualStyleBackColor = true;
            // 
            // lblMyBmr
            // 
            this.lblMyBmr.AutoSize = true;
            this.lblMyBmr.Location = new System.Drawing.Point(282, 97);
            this.lblMyBmr.Name = "lblMyBmr";
            this.lblMyBmr.Size = new System.Drawing.Size(51, 13);
            this.lblMyBmr.TabIndex = 9;
            this.lblMyBmr.Text = "My BMR:";
            // 
            // lblMyBmrVal
            // 
            this.lblMyBmrVal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMyBmrVal.Location = new System.Drawing.Point(285, 124);
            this.lblMyBmrVal.Name = "lblMyBmrVal";
            this.lblMyBmrVal.Size = new System.Drawing.Size(200, 36);
            this.lblMyBmrVal.TabIndex = 10;
            
            // 
            // formMyBMR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 336);
            this.Controls.Add(this.lblMyBmrVal);
            this.Controls.Add(this.lblMyBmr);
            this.Controls.Add(this.grpBoxGender);
            this.Controls.Add(this.lblActivityLvl);
            this.Controls.Add(this.lstBoxActivityLvl);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalcBMR);
            this.Name = "formMyBMR";
            this.Text = "MyBMR";
            this.grpBoxGender.ResumeLayout(false);
            this.grpBoxGender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcBMR;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox lstBoxActivityLvl;
        private System.Windows.Forms.Label lblActivityLvl;
        private System.Windows.Forms.GroupBox grpBoxGender;
        private System.Windows.Forms.RadioButton rButtonFemale;
        private System.Windows.Forms.RadioButton rButtonMale;
        private System.Windows.Forms.Label lblMyBmr;
        private System.Windows.Forms.Label lblMyBmrVal;
    }
}