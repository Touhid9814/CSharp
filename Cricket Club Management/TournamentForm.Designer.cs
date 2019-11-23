namespace Cricket_Club_Management
{
    partial class TournamentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTourID = new MetroFramework.Controls.MetroTextBox();
            this.txtVenue = new MetroFramework.Controls.MetroTextBox();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.dgvTour = new MetroFramework.Controls.MetroGrid();
            this.TournamentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TournamentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnAddteam = new MetroFramework.Controls.MetroButton();
            this.txtTourName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnRefresh = new MetroFramework.Controls.MetroButton();
            this.dgvTourTeams = new MetroFramework.Controls.MetroGrid();
            this.Teams = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrtFixture = new MetroFramework.Controls.MetroButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.dgvFixture = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Team2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourTeams)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFixture)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(385, 181);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Tournament ID : ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(385, 263);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(58, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Venue : ";
            // 
            // txtTourID
            // 
            // 
            // 
            // 
            this.txtTourID.CustomButton.Image = null;
            this.txtTourID.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtTourID.CustomButton.Name = "";
            this.txtTourID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTourID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTourID.CustomButton.TabIndex = 1;
            this.txtTourID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTourID.CustomButton.UseSelectable = true;
            this.txtTourID.CustomButton.Visible = false;
            this.txtTourID.Lines = new string[0];
            this.txtTourID.Location = new System.Drawing.Point(520, 181);
            this.txtTourID.MaxLength = 32767;
            this.txtTourID.Name = "txtTourID";
            this.txtTourID.PasswordChar = '\0';
            this.txtTourID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTourID.SelectedText = "";
            this.txtTourID.SelectionLength = 0;
            this.txtTourID.SelectionStart = 0;
            this.txtTourID.ShortcutsEnabled = true;
            this.txtTourID.Size = new System.Drawing.Size(170, 23);
            this.txtTourID.TabIndex = 2;
            this.txtTourID.UseSelectable = true;
            this.txtTourID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTourID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtVenue
            // 
            // 
            // 
            // 
            this.txtVenue.CustomButton.Image = null;
            this.txtVenue.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtVenue.CustomButton.Name = "";
            this.txtVenue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtVenue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVenue.CustomButton.TabIndex = 1;
            this.txtVenue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVenue.CustomButton.UseSelectable = true;
            this.txtVenue.CustomButton.Visible = false;
            this.txtVenue.Lines = new string[0];
            this.txtVenue.Location = new System.Drawing.Point(520, 259);
            this.txtVenue.MaxLength = 32767;
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.PasswordChar = '\0';
            this.txtVenue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVenue.SelectedText = "";
            this.txtVenue.SelectionLength = 0;
            this.txtVenue.SelectionStart = 0;
            this.txtVenue.ShortcutsEnabled = true;
            this.txtVenue.Size = new System.Drawing.Size(170, 23);
            this.txtVenue.TabIndex = 3;
            this.txtVenue.UseSelectable = true;
            this.txtVenue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVenue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(233, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(23, 82);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(255, 23);
            this.txtSearch.TabIndex = 22;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvTour
            // 
            this.dgvTour.AllowUserToAddRows = false;
            this.dgvTour.AllowUserToDeleteRows = false;
            this.dgvTour.AllowUserToResizeRows = false;
            this.dgvTour.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTour.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTour.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTour.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TournamentID,
            this.TournamentName,
            this.Venue});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTour.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTour.EnableHeadersVisualStyles = false;
            this.dgvTour.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvTour.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTour.Location = new System.Drawing.Point(23, 121);
            this.dgvTour.Name = "dgvTour";
            this.dgvTour.ReadOnly = true;
            this.dgvTour.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTour.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTour.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTour.Size = new System.Drawing.Size(356, 395);
            this.dgvTour.TabIndex = 21;
            this.dgvTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellClick);
            this.dgvTour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellContentClick);
            // 
            // TournamentID
            // 
            this.TournamentID.DataPropertyName = "ID";
            this.TournamentID.HeaderText = "TournamentID";
            this.TournamentID.Name = "TournamentID";
            this.TournamentID.ReadOnly = true;
            // 
            // TournamentName
            // 
            this.TournamentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TournamentName.DataPropertyName = "Tournament_Name";
            this.TournamentName.HeaderText = "TournamentName";
            this.TournamentName.Name = "TournamentName";
            this.TournamentName.ReadOnly = true;
            // 
            // Venue
            // 
            this.Venue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Venue.DataPropertyName = "Venue";
            this.Venue.HeaderText = "Venue";
            this.Venue.Name = "Venue";
            this.Venue.ReadOnly = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(304, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Registration";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.Add_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(385, 82);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(466, 82);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddteam
            // 
            this.btnAddteam.Location = new System.Drawing.Point(628, 82);
            this.btnAddteam.Name = "btnAddteam";
            this.btnAddteam.Size = new System.Drawing.Size(75, 23);
            this.btnAddteam.TabIndex = 28;
            this.btnAddteam.Text = "Add Team";
            this.btnAddteam.UseSelectable = true;
            this.btnAddteam.Click += new System.EventHandler(this.btnAddteam_Click);
            // 
            // txtTourName
            // 
            // 
            // 
            // 
            this.txtTourName.CustomButton.Image = null;
            this.txtTourName.CustomButton.Location = new System.Drawing.Point(148, 1);
            this.txtTourName.CustomButton.Name = "";
            this.txtTourName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTourName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTourName.CustomButton.TabIndex = 1;
            this.txtTourName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTourName.CustomButton.UseSelectable = true;
            this.txtTourName.CustomButton.Visible = false;
            this.txtTourName.Lines = new string[0];
            this.txtTourName.Location = new System.Drawing.Point(520, 221);
            this.txtTourName.MaxLength = 32767;
            this.txtTourName.Name = "txtTourName";
            this.txtTourName.PasswordChar = '\0';
            this.txtTourName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTourName.SelectedText = "";
            this.txtTourName.SelectionLength = 0;
            this.txtTourName.SelectionStart = 0;
            this.txtTourName.ShortcutsEnabled = true;
            this.txtTourName.Size = new System.Drawing.Size(170, 23);
            this.txtTourName.TabIndex = 30;
            this.txtTourName.UseSelectable = true;
            this.txtTourName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTourName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(385, 221);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(126, 19);
            this.metroLabel4.TabIndex = 29;
            this.metroLabel4.Text = "Tournament Name:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(547, 82);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvTourTeams
            // 
            this.dgvTourTeams.AllowUserToAddRows = false;
            this.dgvTourTeams.AllowUserToDeleteRows = false;
            this.dgvTourTeams.AllowUserToResizeRows = false;
            this.dgvTourTeams.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTourTeams.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTourTeams.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTourTeams.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTourTeams.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTourTeams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTourTeams.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Teams});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTourTeams.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTourTeams.EnableHeadersVisualStyles = false;
            this.dgvTourTeams.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvTourTeams.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvTourTeams.Location = new System.Drawing.Point(696, 121);
            this.dgvTourTeams.Name = "dgvTourTeams";
            this.dgvTourTeams.ReadOnly = true;
            this.dgvTourTeams.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTourTeams.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTourTeams.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvTourTeams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTourTeams.Size = new System.Drawing.Size(210, 395);
            this.dgvTourTeams.TabIndex = 32;
            this.dgvTourTeams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTourTeams_CellClick);
            this.dgvTourTeams.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTour_CellContentClick);
            // 
            // Teams
            // 
            this.Teams.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Teams.DataPropertyName = "TeamName";
            this.Teams.HeaderText = "Teams";
            this.Teams.Name = "Teams";
            this.Teams.ReadOnly = true;
            // 
            // btnCrtFixture
            // 
            this.btnCrtFixture.Location = new System.Drawing.Point(709, 82);
            this.btnCrtFixture.Name = "btnCrtFixture";
            this.btnCrtFixture.Size = new System.Drawing.Size(86, 23);
            this.btnCrtFixture.TabIndex = 33;
            this.btnCrtFixture.Text = "Create Fixture";
            this.btnCrtFixture.UseSelectable = true;
            this.btnCrtFixture.Click += new System.EventHandler(this.btnCrtFixture_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(1049, 98);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 19);
            this.metroLabel5.TabIndex = 35;
            this.metroLabel5.Text = "Fixture";
            // 
            // dgvFixture
            // 
            this.dgvFixture.AllowUserToAddRows = false;
            this.dgvFixture.AllowUserToDeleteRows = false;
            this.dgvFixture.AllowUserToResizeRows = false;
            this.dgvFixture.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFixture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFixture.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvFixture.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFixture.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFixture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFixture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Team2,
            this.Date});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFixture.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFixture.EnableHeadersVisualStyles = false;
            this.dgvFixture.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvFixture.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvFixture.Location = new System.Drawing.Point(912, 121);
            this.dgvFixture.Name = "dgvFixture";
            this.dgvFixture.ReadOnly = true;
            this.dgvFixture.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFixture.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFixture.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvFixture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFixture.Size = new System.Drawing.Size(403, 395);
            this.dgvFixture.TabIndex = 36;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Team1Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Team1";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // Team2
            // 
            this.Team2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Team2.DataPropertyName = "Team2Name";
            this.Team2.HeaderText = "Team2";
            this.Team2.Name = "Team2";
            this.Team2.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // TournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 531);
            this.Controls.Add(this.dgvFixture);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnCrtFixture);
            this.Controls.Add(this.dgvTourTeams);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtTourName);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnAddteam);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvTour);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.txtTourID);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "TournamentForm";
            this.Text = "TournamentForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TournamentForm_FormClosing);
            this.Load += new System.EventHandler(this.TournamentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTourTeams)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFixture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtTourID;
        private MetroFramework.Controls.MetroTextBox txtVenue;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroGrid dgvTour;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnAddteam;
        private MetroFramework.Controls.MetroTextBox txtTourName;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TournamentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TournamentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Venue;
        private MetroFramework.Controls.MetroGrid dgvTourTeams;
        private MetroFramework.Controls.MetroButton btnCrtFixture;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroGrid dgvFixture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teams;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Team2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}