using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using SMS.Framework;


namespace Cricket_Club_Management
{
    public partial class TournamentForm : MetroFramework.Forms.MetroForm
    {
        private PlayerDBEntities context = new PlayerDBEntities();
        private TournamentBL tournamentBL = new TournamentBL();
        private TournamentTeamBL tournamentTeamBL = new TournamentTeamBL();
        private List<Tournament> tournaments = new List<Tournament>();
        private bool isNew = false;

        public TournamentForm()
        {
            InitializeComponent();
        }

        private void Init()
        {
            this.LoadTournament();
        }
        public void LoadTournament()
        {
            var result = tournamentBL.GetAllTournaments(txtSearch.Text);

            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            tournaments = result.Data;

            if (tournaments.Count > 0)
            {
                this.PopulateData(tournaments[0]);
            }
            else
            {
                this.New();
            }

            this.RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dgvTour.AutoGenerateColumns = false;
            dgvTour.DataSource = tournaments.ToList();
            dgvTour.Refresh();
            dgvTour.ClearSelection();

            for (int i = 0; i < dgvTour.Rows.Count; i++)
            {
                if (dgvTour.Rows[i].Cells[0].Value.ToString() == txtTourID.Text)
                {
                    dgvTour.Rows[i].Selected = true;
                }
            }
        }

        private void PopulateData(Tournament tournament)
        {
            txtTourID.Text = tournament.ID == -1 ? "Auto Generated" : tournament.ID.ToString();
            txtVenue.Text = tournament.Venue;
            txtTourName.Text = tournament.Tournament_Name;
        }

        private void New()
        {
            isNew = true;
            dgvTour.ClearSelection();
            var tournament = new Tournament() { ID = -1 };
            this.PopulateData(tournament);
        }

        private void Fill()

        {
            Tournament tournament = new Tournament();

            if (!isNew)
                tournament.ID = Int32.Parse(txtTourID.Text);
            tournament.Tournament_Name = txtTourName.Text;
            tournament.Venue = txtVenue.Text;

            var result = tournamentBL.SaveTournament(tournament);

            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            if (isNew)
                tournaments.Add(result.Data);
            else
            {
                var tm = tournaments.FirstOrDefault(t => t.ID == result.Data.ID);
                if (tm == null)
                {
                    tm.ID = result.Data.ID;
                    tm.Tournament_Name = result.Data.Tournament_Name;
                    tm.Venue = result.Data.Venue;

                }
            }

            isNew = false;
            this.PopulateData(result.Data);
            RefreshDataGrid();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.LoadTournament();
            }
        }

        public void LoadTeams(int tid)
        {
            var result = tournamentTeamBL.GetA(tid);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            dgvTourTeams.AutoGenerateColumns = false;
            dgvTourTeams.DataSource = result.Data;
            dgvTourTeams.Refresh();
        }


        private void Add_Click(object sender, EventArgs e)
        {
            this.New();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Fill();
        }

        private void TournamentForm_Load(object sender, EventArgs e)
        {
            this.Init();
        }

        private void dgvTour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTour_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Int32.Parse(dgvTour.Rows[e.RowIndex].Cells[0].Value.ToString());

                var tournament = tournaments.FirstOrDefault(tr => tr.ID == id);

                if (tournament == null)
                {
                    MessageBox.Show("Something went wrong");
                    this.New();
                    return;
                }

                isNew = false;
                this.PopulateData(tournament);
                this.LoadTeams(tournament.ID);
                this.LoadFixtures();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are you Sure?", "Confirmation", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
                return;

            if (!ValidationHelper.IsIntValid(txtTourID.Text))
            {
                MessageBox.Show("Please select a row first");
                return;
            }

            var result = tournamentBL.Delete(Int32.Parse(txtTourID.Text));
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            var tm = tournaments.FirstOrDefault(t => t.ID == result.Data.ID);
            if (tm != null)
                tournaments.Remove(tm);

            this.RefreshDataGrid();
            this.New();
            MessageBox.Show("Operation Completed");

        }

        private void btnAddteam_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                MessageBox.Show("Please select an existing team");
                return;
            }

            int id = Int32.Parse(txtTourID.Text);

            TeamSelection ts = new TeamSelection(this, id);
            ts.Show();
        }

        private void btnCrtFixture_Click(object sender, EventArgs e)
        {
            try
            {
                int tournament = Int32.Parse(txtTourID.Text);

                var existingFixtures = context.Fixtures.Where(f => f.TournamentID == tournament).ToList();
                foreach(var fix in existingFixtures)
                {
                    var f = context.Fixtures.FirstOrDefault(ff => ff.ID == fix.ID);

                    if (f == null)
                        continue;

                    context.Fixtures.Remove(f);
                }

                if(existingFixtures.Any())
                    context.SaveChanges();

                var teams = context.TournamentTeams.Where(tt => tt.TournamentID == tournament).ToList();
                var date = DateTime.Now;
                for (int i = 0; i < teams.Count; i++)
                {
                    for (int j = i + 1; j < teams.Count; j++)
                    {
                        var fixture = new Fixture()
                        {
                            Team1ID = teams[i].TeamID,
                            Team2ID = teams[j].TeamID,
                            TournamentID=tournament,
                            Date = date.AddDays(2)
                        };
                        date = date.AddDays(2);
                        context.Fixtures.Add(fixture);
                    }
                }

                context.SaveChanges();
                this.LoadFixtures();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, ex.Message);
            }
        }

        private void LoadFixtures()
        {
            int tournament = Int32.Parse(txtTourID.Text);
            var existingFixtures = context.Fixtures.AsNoTracking().Where(f => f.TournamentID == tournament).ToList();

            dgvFixture.AutoGenerateColumns = false;
            dgvFixture.DataSource = existingFixtures.ToList();
            dgvFixture.Refresh();
        }

        private void dgvTourTeams_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TournamentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Admin ad = new Admin();
            ad.Show();
        }
    }
}
