
using SMS.BusinessLogic;
using SMS.Framework;
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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSign_Click_1(object sender, EventArgs e)
        {
            UserBL  ubl = new UserBL();

            var result = ubl.Login(txtUserID.Text, txtPassword.Text);

            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            if (result.Data == null)
            {
                MessageBox.Show("Invalid id or password");
                return;
            }

            LoginHelper.LoginUserInfo = result.Data;
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            UserBL ubl = new UserBL();

            var result = ubl.Login(txtUserID.Text, txtPassword.Text);

            if (result.HasError)
            {
                MessageBox.Show(result.Messages[0]);
                return;
            }

            if (result.Data == null)
            {
                MessageBox.Show("Invalid id or password");
                return;
            }

            LoginHelper.LoginUserInfo = result.Data;
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }
    }
}
    

