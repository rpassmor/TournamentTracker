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
        private List<Person> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<Person> selectedTeamMembers = new List<Person>();
        private ITeamRequester callingForm;
        public frmCreateTeam(ITeamRequester caller)
        {
            InitializeComponent();
            callingForm = caller;
            // CreateSampleData();
            WireUpList();
        }
        private void CreateSampleData()
        { 
            availableTeamMembers.Add(new Person { FirstName = "Blake", LastName = "Passmore" });
            availableTeamMembers.Add(new Person { FirstName = "Allison", LastName = "Passmore" });

            selectedTeamMembers.Add(new Person { FirstName = "Lola", LastName = "Passmore" });
            selectedTeamMembers.Add(new Person { FirstName = "Ekko", LastName = "Passmore" });
        }
        private void WireUpList()
        {
            cboSelectTeam.DataSource = null;
            cboSelectTeam.DataSource = availableTeamMembers;
            cboSelectTeam.DisplayMember = "FullName";

            lstTeamMembers.DataSource = null;
            lstTeamMembers.DataSource = selectedTeamMembers;
            lstTeamMembers.DisplayMember = "FullName";
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

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);
                WireUpList();

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

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            Person p = (Person)cboSelectTeam.SelectedItem;
            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                WireUpList();
            }
        }
        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {
            Person p = (Person)lstTeamMembers.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpList();
            }
        }

        private void btnCreateTeam_Click(object sender, EventArgs e)
        {
            Team t = new Team();

            t.TeamName = txtTeamName.Text;
            t.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(t);
            callingForm.TeamComplete(t);
            this.Close();
        }
    }
}
