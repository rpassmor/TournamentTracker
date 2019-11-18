using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;
using System.Configuration;

namespace TrackerUI
{
    public partial class frmCreatePrize : Form
    {
        IPrizeRequester callingForm;
        public frmCreatePrize(IPrizeRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
        }

        private void BtnCreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Prize model = new Prize(txtPlaceName.Text, 
                                        txtPlaceNumber.Text, 
                                        txtPrizeAmount.Text, 
                                        txtPrizePercentage.Text);

                model = GlobalConfig.Connection.CreatePrize(model);

                callingForm.PrizeComplete(model);

                this.Close();
                /*txtPlaceName.Text = "";
                txtPlaceNumber.Text = "";
                txtPrizeAmount.Text = "0";
                txtPrizePercentage.Text = "0";*/
            }
            else
            {
                MessageBox.Show("This form has invalid information. Please check it and try again.");
            }
        }

        private bool ValidateForm()
        {
            int placeNumber = 0;
            bool output = true;
            decimal prizeAmount = 0;
            double prizePercentage = 0;

            if (!int.TryParse(txtPlaceNumber.Text, out placeNumber))
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }
            if (txtPlaceNumber.Text.Length == 0)
            {
                output = false;
            }
            if ((!decimal.TryParse(txtPrizeAmount.Text, out prizeAmount)) ||
                (!double.TryParse(txtPrizePercentage.Text, out prizePercentage)))
            {
                output = false;
            }
            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }
            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }
    }
}
