namespace NDMyFitnessApp
{
    partial class MyTimer
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
            this.grpBoxTimer = new System.Windows.Forms.GroupBox();
            this.grpBoxTimerSetup = new System.Windows.Forms.GroupBox();
            this.lblIntervalTimer = new System.Windows.Forms.Label();
            this.lblTimerSetup = new System.Windows.Forms.Label();
            this.lblExerciseNM = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblEnterExercise = new System.Windows.Forms.Label();
            this.lblEnterTime = new System.Windows.Forms.Label();
            this.txtBoxExercise = new System.Windows.Forms.TextBox();
            this.txtBoxTime = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblExerciseList = new System.Windows.Forms.Label();
            this.lstBoxExercises = new System.Windows.Forms.ListBox();
            this.lstBoxTimes = new System.Windows.Forms.ListBox();
            this.lblIntervalRest = new System.Windows.Forms.Label();
            this.txtBoxIntervalRest = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpBoxTimer.SuspendLayout();
            this.grpBoxTimerSetup.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxTimer
            // 
            this.grpBoxTimer.Controls.Add(this.btnClose);
            this.grpBoxTimer.Controls.Add(this.btnStart);
            this.grpBoxTimer.Controls.Add(this.lblTimer);
            this.grpBoxTimer.Controls.Add(this.lblExerciseNM);
            this.grpBoxTimer.Controls.Add(this.lblIntervalTimer);
            this.grpBoxTimer.Location = new System.Drawing.Point(12, 31);
            this.grpBoxTimer.Name = "grpBoxTimer";
            this.grpBoxTimer.Size = new System.Drawing.Size(200, 329);
            this.grpBoxTimer.TabIndex = 0;
            this.grpBoxTimer.TabStop = false;
            // 
            // grpBoxTimerSetup
            // 
            this.grpBoxTimerSetup.Controls.Add(this.btnClear);
            this.grpBoxTimerSetup.Controls.Add(this.btnSubmit);
            this.grpBoxTimerSetup.Controls.Add(this.txtBoxIntervalRest);
            this.grpBoxTimerSetup.Controls.Add(this.lblIntervalRest);
            this.grpBoxTimerSetup.Controls.Add(this.lstBoxTimes);
            this.grpBoxTimerSetup.Controls.Add(this.lstBoxExercises);
            this.grpBoxTimerSetup.Controls.Add(this.lblExerciseList);
            this.grpBoxTimerSetup.Controls.Add(this.lblTime);
            this.grpBoxTimerSetup.Controls.Add(this.btnAdd);
            this.grpBoxTimerSetup.Controls.Add(this.txtBoxTime);
            this.grpBoxTimerSetup.Controls.Add(this.txtBoxExercise);
            this.grpBoxTimerSetup.Controls.Add(this.lblEnterTime);
            this.grpBoxTimerSetup.Controls.Add(this.lblEnterExercise);
            this.grpBoxTimerSetup.Controls.Add(this.lblTimerSetup);
            this.grpBoxTimerSetup.Location = new System.Drawing.Point(232, 31);
            this.grpBoxTimerSetup.Name = "grpBoxTimerSetup";
            this.grpBoxTimerSetup.Size = new System.Drawing.Size(234, 329);
            this.grpBoxTimerSetup.TabIndex = 1;
            this.grpBoxTimerSetup.TabStop = false;
            // 
            // lblIntervalTimer
            // 
            this.lblIntervalTimer.AutoSize = true;
            this.lblIntervalTimer.Location = new System.Drawing.Point(17, 20);
            this.lblIntervalTimer.Name = "lblIntervalTimer";
            this.lblIntervalTimer.Size = new System.Drawing.Size(71, 13);
            this.lblIntervalTimer.TabIndex = 0;
            this.lblIntervalTimer.Text = "Interval Timer";
            // 
            // lblTimerSetup
            // 
            this.lblTimerSetup.AutoSize = true;
            this.lblTimerSetup.Location = new System.Drawing.Point(15, 20);
            this.lblTimerSetup.Name = "lblTimerSetup";
            this.lblTimerSetup.Size = new System.Drawing.Size(102, 13);
            this.lblTimerSetup.TabIndex = 1;
            this.lblTimerSetup.Text = "Interval Timer Setup";
            // 
            // lblExerciseNM
            // 
            this.lblExerciseNM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExerciseNM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExerciseNM.Location = new System.Drawing.Point(40, 69);
            this.lblExerciseNM.Name = "lblExerciseNM";
            this.lblExerciseNM.Size = new System.Drawing.Size(100, 23);
            this.lblExerciseNM.TabIndex = 1;
            // 
            // lblTimer
            // 
            this.lblTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(31, 103);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(118, 41);
            this.lblTimer.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(20, 169);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(110, 169);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblEnterExercise
            // 
            this.lblEnterExercise.AutoSize = true;
            this.lblEnterExercise.Location = new System.Drawing.Point(18, 37);
            this.lblEnterExercise.Name = "lblEnterExercise";
            this.lblEnterExercise.Size = new System.Drawing.Size(78, 13);
            this.lblEnterExercise.TabIndex = 2;
            this.lblEnterExercise.Text = "Enter Exercise:";
            // 
            // lblEnterTime
            // 
            this.lblEnterTime.AutoSize = true;
            this.lblEnterTime.Location = new System.Drawing.Point(118, 37);
            this.lblEnterTime.Name = "lblEnterTime";
            this.lblEnterTime.Size = new System.Drawing.Size(61, 13);
            this.lblEnterTime.TabIndex = 3;
            this.lblEnterTime.Text = "Enter Time:";
            // 
            // txtBoxExercise
            // 
            this.txtBoxExercise.Location = new System.Drawing.Point(18, 54);
            this.txtBoxExercise.Name = "txtBoxExercise";
            this.txtBoxExercise.Size = new System.Drawing.Size(78, 20);
            this.txtBoxExercise.TabIndex = 4;
            // 
            // txtBoxTime
            // 
            this.txtBoxTime.Location = new System.Drawing.Point(121, 54);
            this.txtBoxTime.Name = "txtBoxTime";
            this.txtBoxTime.Size = new System.Drawing.Size(36, 20);
            this.txtBoxTime.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(173, 54);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(55, 23);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(118, 103);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            // 
            // lblExerciseList
            // 
            this.lblExerciseList.AutoSize = true;
            this.lblExerciseList.Location = new System.Drawing.Point(18, 103);
            this.lblExerciseList.Name = "lblExerciseList";
            this.lblExerciseList.Size = new System.Drawing.Size(66, 13);
            this.lblExerciseList.TabIndex = 8;
            this.lblExerciseList.Text = "Exercise List";
            // 
            // lstBoxExercises
            // 
            this.lstBoxExercises.FormattingEnabled = true;
            this.lstBoxExercises.Location = new System.Drawing.Point(21, 131);
            this.lstBoxExercises.Name = "lstBoxExercises";
            this.lstBoxExercises.Size = new System.Drawing.Size(84, 95);
            this.lstBoxExercises.TabIndex = 9;
            // 
            // lstBoxTimes
            // 
            this.lstBoxTimes.FormattingEnabled = true;
            this.lstBoxTimes.Location = new System.Drawing.Point(121, 131);
            this.lstBoxTimes.Name = "lstBoxTimes";
            this.lstBoxTimes.Size = new System.Drawing.Size(84, 95);
            this.lstBoxTimes.TabIndex = 10;
            // 
            // lblIntervalRest
            // 
            this.lblIntervalRest.AutoSize = true;
            this.lblIntervalRest.Location = new System.Drawing.Point(18, 247);
            this.lblIntervalRest.Name = "lblIntervalRest";
            this.lblIntervalRest.Size = new System.Drawing.Size(70, 13);
            this.lblIntervalRest.TabIndex = 11;
            this.lblIntervalRest.Text = "Interval Rest:";
            // 
            // txtBoxIntervalRest
            // 
            this.txtBoxIntervalRest.Location = new System.Drawing.Point(105, 244);
            this.txtBoxIntervalRest.Name = "txtBoxIntervalRest";
            this.txtBoxIntervalRest.Size = new System.Drawing.Size(100, 20);
            this.txtBoxIntervalRest.TabIndex = 12;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(21, 291);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 13;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(105, 291);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MyTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 372);
            this.Controls.Add(this.grpBoxTimerSetup);
            this.Controls.Add(this.grpBoxTimer);
            this.Name = "MyTimer";
            this.Text = "Timer";
            this.grpBoxTimer.ResumeLayout(false);
            this.grpBoxTimer.PerformLayout();
            this.grpBoxTimerSetup.ResumeLayout(false);
            this.grpBoxTimerSetup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxTimer;
        private System.Windows.Forms.Label lblExerciseNM;
        private System.Windows.Forms.Label lblIntervalTimer;
        private System.Windows.Forms.GroupBox grpBoxTimerSetup;
        private System.Windows.Forms.Label lblTimerSetup;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBoxIntervalRest;
        private System.Windows.Forms.Label lblIntervalRest;
        private System.Windows.Forms.ListBox lstBoxTimes;
        private System.Windows.Forms.ListBox lstBoxExercises;
        private System.Windows.Forms.Label lblExerciseList;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxTime;
        private System.Windows.Forms.TextBox txtBoxExercise;
        private System.Windows.Forms.Label lblEnterTime;
        private System.Windows.Forms.Label lblEnterExercise;
    }
}