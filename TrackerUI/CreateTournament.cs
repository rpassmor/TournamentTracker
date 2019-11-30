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
    public partial class frmCreateTournament : Form, IPrizeRequester, ITeamRequester
    {
        List<Team> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<Team> selectedTeams = new List<Team>();
        List<Prize> selectedPrizes = new List<Prize>();

        public frmCreateTournament()
        {
            InitializeComponent();
            WireUpList();
        }
        private void WireUpList()
        {
            cboSelectTeam.DataSource = null;
            cboSelectTeam.DataSource = availableTeams;
            cboSelectTeam.DisplayMember = "TeamName";

            lstTeams.DataSource = null;
            lstTeams.DataSource = selectedTeams;
            lstTeams.DisplayMember = "TeamName";

            lstPrizes.DataSource = null;
            lstPrizes.DataSource = selectedPrizes;
            lstPrizes.DisplayMember = "PlaceName";
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            Team t = (Team)cboSelectTeam.SelectedItem;
            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpList();
            }
        }

        private void btnCreatePrize_Click(object sender, EventArgs e)
        {
            // Call frmCreatePrize
            frmCreatePrize frm = new frmCreatePrize(this);
            frm.ShowDialog();

            // Get back from the form a Prize(model)

            // Take the Prize(model) and put it into our list of selected prizes
        }

        public void PrizeComplete(Prize model)
        {
            // Get back from the form a Prize(model)
            // Take the Prize(model) and put it into our list of selected prizes 
            selectedPrizes.Add(model);
            WireUpList();
        }

        private void llbCreateTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCreateTeam frm = new frmCreateTeam(this);
            frm.ShowDialog();
        }

        public void TeamComplete(Team model)
        {
            selectedTeams.Add(model);
            WireUpList();
        }

        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {
            /*Person p = (Person)lstTeamMembers.SelectedItem;
            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                WireUpList();
            }*/
            Team t = (Team)lstTeams.SelectedItem;
            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                WireUpList();
            }
        }

        private void btnRemovePrize_Click(object sender, EventArgs e)
        {
            Prize p = (Prize)lstPrizes.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpList();
            }
        }

        private void btnCreateTournament_Click(object sender, EventArgs e)
        {
            // Validate data
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(txtEntryFee.Text, out fee);
            
            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter a valid Entry Fee.", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Create tournamnet model
            Tournament tm = new Tournament();

            tm.TounamentName = txtTournamentName.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            // TODO - Wire our matchups

            // Order our list randomly of teams
            // Check is list is big enough - if not, add in byes - 2^n
            // Create first round of matchups
            // Create every round after that
            TournamentLogic.CreateRounds(tm);

            // Create tournaments entry
            // Create all of the prizes entries
            // Create all of the team entries

            GlobalConfig.Connection.CreateTournament(tm);
        }
    }
}
