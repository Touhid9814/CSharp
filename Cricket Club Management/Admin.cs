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
    public partial class Admin : MetroFramework.Forms.MetroForm
    {
        public bool showForm = false;
        public Admin()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {

        }

        

        private void BtnAddPlayer_Click(object sender, EventArgs e)
        {
            PlayerInfoForm pif = new PlayerInfoForm();
            pif.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            TeamForm teamform = new TeamForm();
            teamform.Show(this);
            this.Hide();
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            TournamentForm tf = new TournamentForm();
            tf.Show(this);
            this.Hide();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            FixtureForm ff = new FixtureForm();
            ff.Show();
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }
    }
}
