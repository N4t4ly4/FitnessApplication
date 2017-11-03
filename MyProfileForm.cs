

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
    public partial class formMyProfile : Form
    {
        //create weight property
        public int Weight
        {
            get;
            set;
        }

        //create height property
        public int Height
        {
            get;
            set;
        }

        //create age property
        public int Age
        {
            get;
            set;
        }

        //minimum/maximum constants for weight, height and age
        const int MIN_WEIGHT = 50;
        const int MAX_WEIGHT = 1000;
        const int MIN_HEIGHT = 48;
        const int MAX_HEIGHT = 96;
        const int MIN_AGE = 12;
        const int MAX_AGE = 120;




        /// <summary>
        /// my profifile constructor
        /// Preconditions: none
        /// Postconditions: creates a new myprofileform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public formMyProfile()
        {
            InitializeComponent();
        }



        /// <summary>
        /// event handler for the after button
        /// Preconditions: none
        /// Postconditions: after picture box is visible, after picturebox is not visible. Congratulations message shows.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAfter_Click(object sender, EventArgs e)
        {
            //show after photo
            picBoxAfter.Visible = true;

            //hide before photo
            picBoxBefore.Visible = false;

            //congradulate user
            MessageBox.Show("Congratulations!!!");
        }

        /// <summary>
        /// event handler for the before button
        /// Preconditions: none
        /// Postconditions: before picture box is visible, after picturebox is not visible
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBefore_Click(object sender, EventArgs e)
        {
            //show after photo
            picBoxAfter.Visible = false;

            //hide before photo
            picBoxBefore.Visible = true;

            //close the form
            this.Close();
        }

        /// <summary>
        /// event handler for the close button
        /// Preconditions: none
        /// Postconditions: close the app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            //Temporary variables to use for weight, height and age properties.
            //*Visual studio reads error: a property may not be passed as a out or ref parameter.
            //exception handling for my profile stats
            int weight = Weight;
            int height = Height;
            int age = Age;
            
            //input validation for height weight age
            if (int.TryParse(txtBoxWeight.Text, out weight) && weight >= MIN_WEIGHT && weight <= MAX_WEIGHT)
            {
                if (int.TryParse(txtBoxHeight.Text, out height) && height >= MIN_HEIGHT && height <= MAX_HEIGHT)
                {
                    if (int.TryParse(txtBoxAge.Text, out age) && age >= MIN_AGE && age <= MAX_AGE)
                    {
                        //set height, weight, and age properties
                        Weight = weight;
                        Height = height;
                        Age = age;

                        //close form
                        this.Close();
                    }
                    else
                    {
                        //show error message for age, clear, add focus
                        MessageBox.Show("Please enter an integer between 12 and 120 for age.");
                        txtBoxAge.Text = "";
                        txtBoxAge.Focus();
                    }
                }
                else
                {
                    //show error message for height, clear, add focus
                    MessageBox.Show("Please enter an integer between 48 and 96 for height.");
                    txtBoxHeight.Text = "";
                    txtBoxHeight.Focus();
                }
            }
            else
            {
                //show error message for weight, clear, add focus
                MessageBox.Show("Please enter an integer between 50 and 1000 for weight.");
                txtBoxWeight.Text = "";
                txtBoxWeight.Focus();
            }

            
           
        }

            /// <summary>
            /// clears all texboxes
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void btnClear_Click(object sender, EventArgs e)
            {
                //clear text boxes
                txtBoxWeight.Text = "";
                txtBoxHeight.Text = "";
                txtBoxAge.Text = "";

                //reset variables for textboxes
                Weight = 0;
                Height = 0;
                Age = 0;

                //prevent clear button from closing the form
                this.DialogResult = DialogResult.None;
            }

     
    }
   
    
}
