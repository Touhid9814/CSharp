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
    public partial class PlayerInfoForm : MetroFramework.Forms.MetroForm
    {
        private PlayerBL playerBL = new PlayerBL();
        
        private List<Player> players = new List<Player>();
        private bool isNew = false;


        private void Init()
        {
            txtSearch.Text = "";
            this.LoadPlayer();
        }
        public PlayerInfoForm()
        {
            InitializeComponent();
        }

        private void PlayerInfoForm_Load(object sender, EventArgs e)
        {
            pnlAddAdmin.Show();
            Init();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            this.New();
        }
        private void LoadPlayer()
        {
            var result = playerBL.GetAllPlayers(txtSearch.Text);

            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            players = result.Data;

            if (players.Count > 0)
            {
                this.PopulateData(players[0]);
            }
            else
            {
                this.New();
            }

            this.RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            dgvPlayer.AutoGenerateColumns = false;
            dgvPlayer.DataSource = players.ToList();
            dgvPlayer.Refresh();
            dgvPlayer.ClearSelection();

            for (int i = 0; i < dgvPlayer.Rows.Count; i++)
            {
                if (dgvPlayer.Rows[i].Cells[0].Value.ToString() == txtID.Text)
                {
                    dgvPlayer.Rows[i].Selected = true;
                }
            }
        }

        private void PopulateData(Player player)
        {
            txtID.Text = player.PId == -1 ? "Auto Generate" : player.PId.ToString();
            txtName.Text = player.Name;
            if(player.PId == -1)
                dtDob.Text = "";
            else
                dtDob.Text = player.DOB.ToShortDateString(); 
            txtRole.Text = player.Role;
            if(player.BattingStyle == null)
            {
                txtBatStyle.Text = null;
            }
            else
            txtBatStyle.Text= player.BattingStyle.Trim();
            txtBowl.Text = player.BowlingStyle;
        }

        private void New()
        {
            isNew = true;
            dgvPlayer.ClearSelection();
            var player = new Player() { PId = -1 };
            this.PopulateData(player);
        }

        private void dgvPlayer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = Int32.Parse(dgvPlayer.Rows[e.RowIndex].Cells[0].Value.ToString());

                var player = players.FirstOrDefault(plr => plr.PId == id);

                if (player == null)
                {
                    MessageBox.Show("Something went wrong");
                    this.New();
                    return;
                }

                isNew = false;
                this.PopulateData(player);
            }
        }
        
        

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.LoadPlayer();
            }
        }

        

       

        private void metroButton3_Click(object sender, EventArgs e)
        {
            this.Fill();
        }

        private void Fill()
        {
            Player player = new Player();            

            if (!isNew)
            player.PId = Int32.Parse(txtID.Text);
            player.Name = txtName.Text;
            player.DOB = Convert.ToDateTime(dtDob.Text);
            player.Role = txtRole.SelectedItem.ToString();
            player.BattingStyle = txtBatStyle.SelectedItem.ToString();
            player.BowlingStyle = txtBowl.SelectedItem.ToString();

            var result = playerBL.SavePlayer(player);

            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            if (isNew)
                players.Add(result.Data);
            else
            {
                var plr = players.FirstOrDefault(s => s.PId == result.Data.PId);
                if (plr == null)
                {
                    plr.PId = result.Data.PId;
                    plr.Name = result.Data.Name;
                    plr.DOB = result.Data.DOB;
                    plr.BattingStyle = result.Data.BattingStyle;
                    plr.BowlingStyle = result.Data.BowlingStyle;
                    plr.Role = result.Data.Role;
                }
            }

            isNew = false;
            this.PopulateData(result.Data);
            RefreshDataGrid();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "Are you Sure?", "Confirmation", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
                return;

            if (!ValidationHelper.IsIntValid(txtID.Text))
            {
                MessageBox.Show("Please select a row first");
                return;
            }

            var result = playerBL.Delete(Int32.Parse(txtID.Text));
            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            var plr = players.FirstOrDefault(d => d.PId == result.Data.PId);
            if (plr != null)
                players.Remove(plr);

            this.RefreshDataGrid();
            this.New();
            MessageBox.Show("Operation Completed");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Fill();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Init();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void pnlAddAdmin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            this.Hide();
            ad.Show();
        }

        private void btnRefresh_MouseEnter(object sender, EventArgs e)
        {
           
        }
    }
}
