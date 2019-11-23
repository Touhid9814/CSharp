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
    public partial class TeamForm : MetroFramework.Forms.MetroForm
    {
        private TeamBL teamBL = new TeamBL();
        private TeamPlayerBL teamPlayerBL = new TeamPlayerBL();

        private List<Team> teams = new List<Team>();
        private bool isNew = false;

        public TeamForm()
        {
            InitializeComponent();
        }


        private void Init()
        {
            this.LoadTeam();
        }
        private void LoadTeam()
        {
            var result = teamBL.GetAllTeams(txtSearch.Text);

            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            teams = result.Data;

            if (teams.Count > 0)
            {
                this.PopulateData(teams[0]);
            }
            else
            {
                this.New();
            }

            this.RefreshDataGrid();
        }
        private void RefreshDataGrid()
        {
            dgvTeamList.AutoGenerateColumns = false;
            dgvTeamList.DataSource = teams.ToList();
            dgvTeamList.Refresh();
            dgvTeamList.ClearSelection();

            for (int i = 0; i < dgvTeamList.Rows.Count; i++)
            {
                if (dgvTeamList.Rows[i].Cells[0].Value.ToString() == txtTID.Text)
                {
                    dgvTeamList.Rows[i].Selected = true;
                }
            }
        }

              private void PopulateData(Team team)
          {
              txtTID.Text = team.TeamID == -1 ? "" : team.TeamID.ToString();
              txtTeamname.Text = team.Team_Name;
          }
          

        private void btnCrtFix_Click(object sender, EventArgs e)
        {
           
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            if (isNew)
            {
                MessageBox.Show("Please select an existing team");
                return;
            }

            int id = Int32.Parse(txtTID.Text);

            PlayerSelection ps = new PlayerSelection(this,id);
            ps.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Fill();
        }

        private void Fill()

        {
            Team team = new Team();

            
            team.TeamID = Int32.Parse(txtTID.Text);
            team.Team_Name = txtTeamname.Text;


            var result = teamBL.SaveTeam(team);

            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            if (isNew)
                teams.Add(result.Data);
            else
            {
                var tm = teams.FirstOrDefault(t => t.TeamID == result.Data.TeamID);
                if (tm == null)
                {
                    tm.TeamID = result.Data.TeamID;
                    tm.Team_Name = result.Data.Team_Name;

                }
            }

            isNew = false;
            this.PopulateData(result.Data);
            RefreshDataGrid();
        }


        private void New()
        {
            isNew = true;
            dgvTeamList.ClearSelection();
            var team = new Team() { TeamID = -1 };
            this.PopulateData(team);
        }

        private void dgvTeamList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                int id = Int32.Parse(dgvTeamList.Rows[e.RowIndex].Cells[0].Value.ToString());

                var team = teams.FirstOrDefault(tm => tm.TeamID == id);

                if (team == null)
                {
                    MessageBox.Show("Something went wrong");
                    this.New();
                    return;
                }

                isNew = false;
                this.PopulateData(team);
                this.LoadPlayers(team.TeamID);
            }
        }

        public void LoadPlayers(int tid)
        {
            var result = teamPlayerBL.GetA(tid);
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            dgvPlayer.AutoGenerateColumns = false;
            dgvPlayer.DataSource = result.Data;
            dgvPlayer.Refresh();
        }

        

        private void TeamForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnRemoveTeam_Click(object sender, EventArgs e)
        {
           
                    DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are you Sure?", "Confirmation", MessageBoxButtons.YesNo);

                    if (dr == DialogResult.No)
                        return;

                    if (!ValidationHelper.IsIntValid(txtTID.Text))
                    {
                        MessageBox.Show("Please select a row first");
                        return;
                    }

                    var result = teamBL.Delete(Int32.Parse(txtTID.Text));
                    if (result.HasError)
                    {
                        MessageBox.Show("Cannot remove "+result.Messages[0]);
                        return;
                    }

                    var tm = teams.FirstOrDefault(t => t.TeamID == result.Data.TeamID);
                    if (tm != null)
                        teams.Remove(tm);

                    this.RefreshDataGrid();
                    this.New();
                    MessageBox.Show("Operation Completed");
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.New();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Init();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.LoadTeam();
            }
        }

        private void dgvTeamList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPlayer_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void TeamForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Admin ad = new Admin();
            ad.Show();
        }
    }
}

