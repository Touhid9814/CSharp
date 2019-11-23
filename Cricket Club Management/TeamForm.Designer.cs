namespace Cricket_Club_Management
{
    partial class TeamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRemoveTeam = new MetroFramework.Controls.MetroButton();
            this.btnAddPlayer = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.dgvTeamList = new MetroFramework.Controls.MetroGrid();
            this.TeamID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtTID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTeamname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.dgvPlayer = new MetroFramework.Controls.MetroGrid();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRemoveTeam
            // 
            this.btnRemoveTeam.Location = new System.Drawing.Point(487, 92);
            this.btnRemoveTeam.Name = "btnRemoveTeam";
            this.btnRemoveTeam.Size = new System.Drawing.Size(107, 23);
            this.btnRemoveTeam.TabIndex = 17;
            this.btnRemoveTeam.Text = "Remove Team";
            this.btnRemoveTeam.UseSelectable = true;
            this.btnRemoveTeam.Click += new System.EventHandler(this.btnRemoveTeam_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(713, 92);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(107, 23);
            this.btnAddPlayer.TabIndex = 16;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseSelectable = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(35, 225);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(77, 19);
            this.metroLabel3.TabIndex = 15;
            this.metroLabel3.Text = "Team List : ";
            // 
            // dgvTeamList
            // 
            this.dgvTeamList.AllowUserToAddRows = false;
            this.dgvTeamList.AllowUserToDeleteRows = false;
            this.dgvTeamList.AllowUserToResizeRows = false;
            this.dgvTeamList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTeamList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTeamList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTeamList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeamList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTeamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeamList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamID,
            this.TeamName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTeamList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTeamList.EnableHeadersVisualStyles = false;
            this.dgvTeamList.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvTeamList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTeamList.Location = new System.Drawing.Point(35, 249);
            this.dgvTeamList.Name = "dgvTeamList";
            this.dgvTeamList.ReadOnly = true;
            this.dgvTeamList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTeamList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTeamList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTeamList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeamList.Size = new System.Drawing.Size(314, 307);
            this.dgvTeamList.TabIndex = 14;
            this.dgvTeamList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeamList_CellClick);
            this.dgvTeamList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeamList_CellContentClick);
            // 
            // TeamID
            // 
            this.TeamID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeamID.DataPropertyName = "TeamID";
            this.TeamID.HeaderText = "TeamID";
            this.TeamID.Name = "TeamID";
            this.TeamID.ReadOnly = true;
            // 
            // TeamName
            // 
            this.TeamName.DataPropertyName = "Team_Name";
            this.TeamName.HeaderText = "TeamName";
            this.TeamName.Name = "TeamName";
            this.TeamName.ReadOnly = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(374, 92);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 23);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTID
            // 
            // 
            // 
            // 
            this.txtTID.CustomButton.Image = null;
            this.txtTID.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtTID.CustomButton.Name = "";
            this.txtTID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTID.CustomButton.TabIndex = 1;
            this.txtTID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTID.CustomButton.UseSelectable = true;
            this.txtTID.CustomButton.Visible = false;
            this.txtTID.Lines = new string[0];
            this.txtTID.Location = new System.Drawing.Point(133, 175);
            this.txtTID.MaxLength = 32767;
            this.txtTID.Name = "txtTID";
            this.txtTID.PasswordChar = '\0';
            this.txtTID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTID.SelectedText = "";
            this.txtTID.SelectionLength = 0;
            this.txtTID.SelectionStart = 0;
            this.txtTID.ShortcutsEnabled = true;
            this.txtTID.Size = new System.Drawing.Size(225, 23);
            this.txtTID.TabIndex = 24;
            this.txtTID.UseSelectable = true;
            this.txtTID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(35, 175);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.TabIndex = 23;
            this.metroLabel2.Text = "Team ID : ";
            // 
            // txtTeamname
            // 
            // 
            // 
            // 
            this.txtTeamname.CustomButton.Image = null;
            this.txtTeamname.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtTeamname.CustomButton.Name = "";
            this.txtTeamname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTeamname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTeamname.CustomButton.TabIndex = 1;
            this.txtTeamname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTeamname.CustomButton.UseSelectable = true;
            this.txtTeamname.CustomButton.Visible = false;
            this.txtTeamname.Lines = new string[0];
            this.txtTeamname.Location = new System.Drawing.Point(133, 146);
            this.txtTeamname.MaxLength = 32767;
            this.txtTeamname.Name = "txtTeamname";
            this.txtTeamname.PasswordChar = '\0';
            this.txtTeamname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTeamname.SelectedText = "";
            this.txtTeamname.SelectionLength = 0;
            this.txtTeamname.SelectionStart = 0;
            this.txtTeamname.ShortcutsEnabled = true;
            this.txtTeamname.Size = new System.Drawing.Size(225, 23);
            this.txtTeamname.TabIndex = 22;
            this.txtTeamname.UseSelectable = true;
            this.txtTeamname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTeamname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(35, 146);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(92, 19);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Team Name : ";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(203, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(35, 92);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(225, 23);
            this.txtSearch.TabIndex = 25;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(600, 92);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 23);
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(261, 92);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(107, 23);
            this.btnRegister.TabIndex = 27;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // dgvPlayer
            // 
            this.dgvPlayer.AllowUserToAddRows = false;
            this.dgvPlayer.AllowUserToDeleteRows = false;
            this.dgvPlayer.AllowUserToResizeRows = false;
            this.dgvPlayer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPlayer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvPlayer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlayer.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPlayer.EnableHeadersVisualStyles = false;
            this.dgvPlayer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvPlayer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvPlayer.Location = new System.Drawing.Point(442, 249);
            this.dgvPlayer.Name = "dgvPlayer";
            this.dgvPlayer.ReadOnly = true;
            this.dgvPlayer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayer.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPlayer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPlayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayer.Size = new System.Drawing.Size(314, 307);
            this.dgvPlayer.TabIndex = 28;
            this.dgvPlayer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayer_CellClick);
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PlayerName.DataPropertyName = "PlayerName";
            this.PlayerName.HeaderText = "PlayerName";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(442, 225);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 19);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Player List : ";
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 569);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.dgvPlayer);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtTID);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtTeamname);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRemoveTeam);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.dgvTeamList);
            this.Name = "TeamForm";
            this.Text = "TeamForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TeamForm_FormClosing);
            this.Load += new System.EventHandler(this.TeamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeamList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnRemoveTeam;
        private MetroFramework.Controls.MetroButton btnAddPlayer;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroGrid dgvTeamList;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroTextBox txtTID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtTeamname;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private MetroFramework.Controls.MetroButton btnRegister;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamName;
        private MetroFramework.Controls.MetroGrid dgvPlayer;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
    }
}