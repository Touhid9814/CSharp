using System;
using Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace Cricket_Club_Management
{
    public partial class TeamSelection : MetroFramework.Forms.MetroForm
    {
        TeamForm tmf = new TeamForm();
        int tourID;
        private TournamentBL tournamentBL = new TournamentBL();
        private TeamBL teamBL = new TeamBL();
        private TournamentTeamBL tournamentTeamBL = new TournamentTeamBL();
        TournamentForm tournamentForm;

        public TeamSelection(TournamentForm tf, int id)
        {
            InitializeComponent();
            tourID = id;
            tournamentForm = tf;
        }

        /* private void TeamSelection_Load(object sender, EventArgs e)
         {
             var tournament = tournamentBL.GetByID(tourID);
             metroLabel2.Text = tournament.Data.Tournament_Name;
             this.LoadTeams();
         }
         */
        private void LoadTeams()
        {
            var result = teamBL.GetUnusedTeams();
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            dgvTeamSlct.AutoGenerateColumns = false;
            dgvTeamSlct.DataSource = result.Data;
            dgvTeamSlct.Refresh();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (dgvTeamSlct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Atleast a row");
                return;
            }

            for (int i = 0; i < dgvTeamSlct.SelectedRows.Count; i++)
            {
                int teamID = Int32.Parse(dgvTeamSlct.SelectedRows[i].Cells[0].Value.ToString());

                var trt = new TournamentTeam() { TournamentID = tourID, TeamID = teamID };
                tournamentTeamBL.SaveTournamentTeam(trt);
            }

            this.Hide();
            tournamentForm.LoadTeams(tourID);
        }

        private void TeamSelection_Load_1(object sender, EventArgs e)
        {
            var tournament = tournamentBL.GetByID(tourID);
            metroLabel2.Text = tournament.Data.Tournament_Name;
            this.LoadTeams();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dgvTeamSlct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Atleast a row");
                return;
            }

            for (int i = 0; i < dgvTeamSlct.SelectedRows.Count; i++)
            {
                int teamID = Int32.Parse(dgvTeamSlct.SelectedRows[i].Cells[0].Value.ToString());

                var trt = new TournamentTeam() { TeamID = teamID, TournamentID = tourID };
                tournamentTeamBL.SaveTournamentTeam(trt);
            }

            this.Hide();
            tournamentForm.LoadTeams(tourID);
        }
    }
}