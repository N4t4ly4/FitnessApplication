
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace NDMyFitnessApp
{
    public partial class MyTimer : Form
    {
        //time to wait between seconds constant
        const int TIME_INTERVAL = 1000;

        /// <summary>
        /// initializes MyTimer Object
        /// </summary>
        public MyTimer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// adds excersise name and time to list boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //seconds variable and exercise name variable
            int seconds;
            string exerciseName = txtBoxExercise.Text;

            //validate inputs
            if (int.TryParse(txtBoxTime.Text, out seconds) && seconds > 0)
            {
                //add items to listboxes
                lstBoxExercises.Items.Add(exerciseName);
                lstBoxTimes.Items.Add(seconds.ToString());

                //clear inputs
                txtBoxExercise.Text = "";
                txtBoxTime.Text = "";
            }
            else
            {
                //display error, clear input and give txt box focus
                MessageBox.Show("Please enter a whole number greater than zero for time.");
                txtBoxTime.Text = "";
                txtBoxTime.Focus();
            }
        }

        /// <summary>
        /// saves and test all setup variables for timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //ensure at least one exercise has been entered
            if (lstBoxExercises.Items.Count > 0)
            {
                int restInterval;
                //validate rest input
                if (int.TryParse(txtBoxIntervalRest.Text, out restInterval) && restInterval > 0)
                {
                    //display success message
                    MessageBox.Show("Timer is Ready!");
                }
                else
                {
                    //display input error message and clear and focus time input
                    MessageBox.Show("Please add a whole number for rest period.");
                    txtBoxIntervalRest.Text = "";
                    txtBoxIntervalRest.Focus();
                }
            }
            else
            {
                //display exercise error
                MessageBox.Show("Please add an exercise.");
            }
        }

        /// <summary>
        /// clears inputs for timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear all timer text box inputs
            txtBoxExercise.Text = "";
            txtBoxIntervalRest.Text = "";
            txtBoxTime.Text = "";

            //clear timer listboxes
            lstBoxExercises.Items.Clear();
            lstBoxTimes.Items.Clear();

        }

        /// <summary>
        /// starts and runs timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            //while loop to run through list box items
            int index = 0;
            while (index < lstBoxExercises.Items.Count)
            {
                //display excersise name
                lblExerciseNM.Text = lstBoxExercises.Items[index].ToString();
                //set variable for time
                int timer = int.Parse(lstBoxTimes.Items[index].ToString());

                
                

                //countdown time
                while (timer >= 0)
                {
                    //initialize timespan object to format time
                    TimeSpan runningtime = new TimeSpan(0, 0, timer);

                    //display time
                    lblTimer.Text = runningtime.ToString(@"mm\:ss");

                    //see if a sound needs to be played
                    if (timer < 3)
                    {
                        //play sound
                        SystemSounds.Beep.Play();
                    }

                    //allow interaction with system while timer is running
                    Application.DoEvents();

                    //time between each second
                    Thread.Sleep(TIME_INTERVAL);

                    //decrease timer
                    timer--;
                }

                //rest interval
                int restTime = int.Parse(txtBoxIntervalRest.Text);
                while (restTime >= 0)
                {
                    //display rest
                    lblExerciseNM.Text = "Rest";

                    //display rest time
                    TimeSpan restingTime = new TimeSpan(0, 0, restTime);
                    lblTimer.Text = restingTime.ToString(@"mm\:ss");

                    //time warning
                    if (restTime < 3)
                    {
                        //play sound
                        SystemSounds.Beep.Play();
                    }
                    //allow interaction with system while timer is running
                    Application.DoEvents();

                    //time between each second
                    Thread.Sleep(TIME_INTERVAL);

                    //decrease timer
                    restTime--;
                }

                //increment list box index
                index++;
            }

            //display timer finished
            lblExerciseNM.Text = "Finished";
           
        }

        /// <summary>
        /// closes form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
            
        }
    }
}


