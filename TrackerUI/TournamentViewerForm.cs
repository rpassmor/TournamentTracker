using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class frmTournamentViewer : Form
    {
        private Tournament tournament;
        List<int> rounds = new List<int>();
        List<Matchup> selectedMatchups = new List<Matchup>();
        public frmTournamentViewer(Tournament tournamnetModel)
        {
            InitializeComponent();
            tournament = tournamnetModel;
            LoadFormData();
            LoadRounds();
        }
        private void LoadFormData()
        {
            lblTournamentName.Text = tournament.TounamentName;
        }
        private void WireUpRoundsLists()
        {
            cboRound.DataSource = null;
            cboRound.DataSource = rounds;

            

        }
        private void WireUpMatchupsLists()
        {
            lstMatchup.DataSource = null;
            lstMatchup.DataSource = selectedMatchups;
            lstMatchup.DisplayMember = "DisplayName";
        }
        private void LoadRounds()
        {
            rounds = new List<int>();

            rounds.Add(1);
            int currRound = 1;

            foreach (List<Matchup> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }
            WireUpRoundsLists();
        }

        private void cboRound_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchups();
        }
        private void LoadMatchups()
        {
            int round = (int)cboRound.SelectedItem;

            foreach (List<Matchup> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups = matchups;
                }
            }
            WireUpMatchupsLists();
        }
    }
}
