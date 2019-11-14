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
namespace TrackerUI
{
    public partial class frmCreateTeam : Form
    {
        public frmCreateTeam()
        {
            InitializeComponent();
        }

        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Person p = new Person();

                p.FirstName = txtFirstNameOne.Text;
                p.LastName = txtLastNameOne.Text;
                p.EmailAddress = txtEmail.Text;
                p.CellphoneNumber = txtCellphone.Text;

                GlobalConfig.Connection.CreatePerson(p);

                txtFirstNameOne.Text = "";
                txtLastNameOne.Text = "";
                txtEmail.Text = "";
                txtCellphone.Text = "";
            }
        }
        private bool ValidateForm()
        {
            if (txtFirstNameOne.Text.Length == 0)
            {
                return false;
            }
            if (txtLastNameOne.Text.Length == 0)
            {
                return false;
            }
            if (txtEmail.Text.Length == 0)
            {
                return false;
            }
            if (txtCellphone.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
    }
}
