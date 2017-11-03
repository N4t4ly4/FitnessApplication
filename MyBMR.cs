
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
    public partial class formMyBMR : Form
    {

        //Constants used in male and female bmr calculations
        private const int F_ADDER = 655;
        private const double F_WEIGHT_MULTIPLIER = 4.35;
        private const double F_HEIGHT_MULTIPLIER = 4.7;
        private const double F_AGE_MULTIPLIER = 4.7;

        private const int M_ADDER= 66;
        private const double M_WEIGHT_MULTIPLIER = 6.23;
        private const double M_HEIGHT_MULTIPLIER = 12.7;
        private const double M_AGE_MULTIPLIER  = 6.8;

        //constants for activity multipliers
        private const double LITTLE_MULT = 1.2;
        private const double LIGHT_MULT = 1.375;
        private const double MOD_MULT = 1.55;
        private const double HEAVY_MULT = 1.725;
        private const double V_HEAVY_MULT = 1.9;


        /// <summary>
        /// Constructor for MyBMR Form
        /// Preconditions: none
        /// Postconditions: initialized the mybmr form
        /// </summary>
        public formMyBMR()
        {
            InitializeComponent();

            //select default list box item for activity level
            lstBoxActivityLvl.SelectedIndex = 1;

        }

       

        /// <summary>
        /// event handler for the calculate bmr button
        /// Preconditions: none
        /// Postconditions: calculates bmr
        /// </summary>
        private void btnCalcBMR_Click(object sender, EventArgs e)
        {
            //variables for male and female bmr
            double femaleBMR;
            double maleBMR;

            //varaiable for bmr value
            double BMRValue;

            //initialize myprofileform object
            formMyProfile myProfile = new formMyProfile();

            //open myprofileform
            myProfile.ShowDialog();

            if (rButtonFemale.Checked == true)
            {
                //calculate female bmr
                femaleBMR = (F_ADDER + (F_WEIGHT_MULTIPLIER * myProfile.Weight) + (F_HEIGHT_MULTIPLIER * myProfile.Height)) - (F_AGE_MULTIPLIER * myProfile.Age);
                BMRValue = femaleBMR;
            }
            else
            {
                //calculate male bmr
                maleBMR = (M_ADDER + (M_WEIGHT_MULTIPLIER * myProfile.Weight) + (M_HEIGHT_MULTIPLIER * myProfile.Height) - (M_AGE_MULTIPLIER * myProfile.Age));
                BMRValue = maleBMR;
            }

            //switch to multiply bmr value
            switch (lstBoxActivityLvl.SelectedIndex)
            {
                case 0:
                    BMRValue *= LITTLE_MULT;
                    break;
                case 1:
                    BMRValue *= LIGHT_MULT;
                    break;
                case 2:
                    BMRValue *= MOD_MULT;
                    break;
                case 3:
                    BMRValue *= HEAVY_MULT;
                    break;
                case 4:
                    BMRValue *= V_HEAVY_MULT;
                    break;
                case 5:
                    break;
                default:
                    break;
            }

      
            //display bmr
            lblMyBmrVal.Text = BMRValue.ToString("F");
            
          
        }

        /// <summary>
        /// event handler for close button
        /// Preconditions: none
        /// Postconditions: closes form
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }


    }
}
