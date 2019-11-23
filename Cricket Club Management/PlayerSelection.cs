using BusinessLogic;
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

namespace Cricket_Club_Management
{
    public partial class PlayerSelection : MetroFramework.Forms.MetroForm
    {
        PlayerInfoForm pif = new PlayerInfoForm();
        int teamID;
        private TeamBL teamBL = new TeamBL();
        private PlayerBL playerBL = new PlayerBL();
        private TeamPlayerBL teamPlayerBL = new TeamPlayerBL();
        TeamForm teamForm;
        public PlayerSelection(TeamForm tf,int id)
        {
            InitializeComponent();
            teamID = id;
            teamForm = tf;
        }

        private void PlayerSelection_Load(object sender, EventArgs e)
        {
            var team = teamBL.GetByID(teamID);
            metroLabel2.Text = team.Data.Team_Name;
            this.LoadPlayers();
        }

        private void LoadPlayers()
        {
            var result = playerBL.GetUnusedPlayers();
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            dgvPlrSlct.AutoGenerateColumns = false;
            dgvPlrSlct.DataSource = result.Data;
            dgvPlrSlct.Refresh();
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (dgvPlrSlct.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please Select Atleast a row");
                return;
            }

            for (int i = 0; i < dgvPlrSlct.SelectedRows.Count; i++)
            {
                int playerID = Int32.Parse(dgvPlrSlct.SelectedRows[i].Cells[0].Value.ToString());

                var tp = new TeamPlayer() { TeamID = teamID, PlayerID = playerID };
                teamPlayerBL.SaveTeamPlayer(tp);
            }

            this.Hide();
            teamForm.LoadPlayers(teamID);
        }
    }
}
