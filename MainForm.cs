



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDMyFitnessApp
{
    public partial class mainForm : Form
    {
        /// <summary>
        /// mainform constructor
        /// Preconditions: none
        /// Postconditions: creates a new myprofile form, displays todays date in place of date label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public mainForm()
        {
            InitializeComponent();

            //set the date label txt to today's date
            lblDate.Text = DateTime.Now.ToString("d");
        }

        /// <summary>
        /// event handler for the myprofile button
        /// Preconditions: none
        /// Postconditions: opens my profile form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            //Open My Profile form
            formMyProfile myProfileForm = new formMyProfile();
            myProfileForm.ShowDialog();
        }


        /// <summary>
        /// event handler for the exit button
        /// Preconditions: none
        /// Postconditions: closes the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            //close the object
            this.Close();
        }


        /// <summary>
        /// event handler for the My BMR button
        /// Preconditions: none
        /// Postconditions: displays the My BMR Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyBmr_Click(object sender, EventArgs e)
        {
            //open my bmr form
            formMyBMR bmrForm = new formMyBMR();
            bmrForm.ShowDialog();
        }

        /// <summary>
        /// opens my timer form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMyTimer_Click(object sender, EventArgs e)
        {
            //open my MyTimer form
            MyTimer myTimerForm = new MyTimer();
            myTimerForm.Show();
        }
    }
}
