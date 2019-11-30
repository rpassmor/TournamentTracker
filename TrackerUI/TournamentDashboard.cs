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
    public partial class frmTournamentDashboard : Form
    {
        List<Tournament> tournaments = GlobalConfig.Connection.GetTournament_All();
        public frmTournamentDashboard()
        {
            InitializeComponent();
            WireUpList();
        }
        private void WireUpList()
        {
            cboLoadTournament.DataSource = tournaments;
            cboLoadTournament.DisplayMember = "TounamentName";
        }

        private void btnCreateTournament_Click(object sender, EventArgs e)
        {
            frmCreateTournament frm = new frmCreateTournament();
            frm.ShowDialog();
        }

        private void btnLoadTournament_Click(object sender, EventArgs e)
        {
            Tournament tm = (Tournament)cboLoadTournament.SelectedItem;
            frmTournamentViewer frm = new frmTournamentViewer(tm);
            frm.ShowDialog();
        }
    }
}
