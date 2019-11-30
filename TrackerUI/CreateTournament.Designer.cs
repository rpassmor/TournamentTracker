namespace TrackerUI
{
    partial class frmCreateTournament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateTournament));
            this.lblCreateTournament = new System.Windows.Forms.Label();
            this.txtTournamentName = new System.Windows.Forms.TextBox();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.txtEntryFee = new System.Windows.Forms.TextBox();
            this.lblEntryFee = new System.Windows.Forms.Label();
            this.cboSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.llbCreateTeam = new System.Windows.Forms.LinkLabel();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnCreatePrize = new System.Windows.Forms.Button();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.btnRemoveTeam = new System.Windows.Forms.Button();
            this.btnRemovePrize = new System.Windows.Forms.Button();
            this.lblPrize = new System.Windows.Forms.Label();
            this.lstPrizes = new System.Windows.Forms.ListBox();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCreateTournament
            // 
            this.lblCreateTournament.AutoSize = true;
            this.lblCreateTournament.BackColor = System.Drawing.Color.White;
            this.lblCreateTournament.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblCreateTournament.Location = new System.Drawing.Point(12, 9);
            this.lblCreateTournament.Name = "lblCreateTournament";
            this.lblCreateTournament.Size = new System.Drawing.Size(317, 50);
            this.lblCreateTournament.TabIndex = 1;
            this.lblCreateTournament.Text = "Create Tournament";
            // 
            // txtTournamentName
            // 
            this.txtTournamentName.Location = new System.Drawing.Point(21, 114);
            this.txtTournamentName.Name = "txtTournamentName";
            this.txtTournamentName.Size = new System.Drawing.Size(306, 33);
            this.txtTournamentName.TabIndex = 10;
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTournamentName.Location = new System.Drawing.Point(16, 86);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(172, 25);
            this.lblTournamentName.TabIndex = 9;
            this.lblTournamentName.Text = "Tournament Name:";
            // 
            // txtEntryFee
            // 
            this.txtEntryFee.Location = new System.Drawing.Point(115, 165);
            this.txtEntryFee.Name = "txtEntryFee";
            this.txtEntryFee.Size = new System.Drawing.Size(100, 33);
            this.txtEntryFee.TabIndex = 12;
            this.txtEntryFee.Text = "0";
            // 
            // lblEntryFee
            // 
            this.lblEntryFee.AutoSize = true;
            this.lblEntryFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEntryFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblEntryFee.Location = new System.Drawing.Point(16, 165);
            this.lblEntryFee.Name = "lblEntryFee";
            this.lblEntryFee.Size = new System.Drawing.Size(93, 25);
            this.lblEntryFee.TabIndex = 11;
            this.lblEntryFee.Text = "Entry Fee:";
            // 
            // cboSelectTeam
            // 
            this.cboSelectTeam.FormattingEnabled = true;
            this.cboSelectTeam.Location = new System.Drawing.Point(21, 242);
            this.cboSelectTeam.Name = "cboSelectTeam";
            this.cboSelectTeam.Size = new System.Drawing.Size(308, 33);
            this.cboSelectTeam.TabIndex = 14;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSelectTeam.Location = new System.Drawing.Point(14, 214);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(115, 25);
            this.lblSelectTeam.TabIndex = 13;
            this.lblSelectTeam.Text = "Select Team:";
            // 
            // llbCreateTeam
            // 
            this.llbCreateTeam.AutoSize = true;
            this.llbCreateTeam.LinkColor = System.Drawing.Color.Black;
            this.llbCreateTeam.Location = new System.Drawing.Point(219, 214);
            this.llbCreateTeam.Name = "llbCreateTeam";
            this.llbCreateTeam.Size = new System.Drawing.Size(117, 25);
            this.llbCreateTeam.TabIndex = 15;
            this.llbCreateTeam.TabStop = true;
            this.llbCreateTeam.Text = "+create new";
            this.llbCreateTeam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCreateTeam_LinkClicked);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddTeam.Location = new System.Drawing.Point(86, 310);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(154, 44);
            this.btnAddTeam.TabIndex = 16;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnCreatePrize
            // 
            this.btnCreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatePrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreatePrize.Location = new System.Drawing.Point(86, 360);
            this.btnCreatePrize.Name = "btnCreatePrize";
            this.btnCreatePrize.Size = new System.Drawing.Size(154, 44);
            this.btnCreatePrize.TabIndex = 17;
            this.btnCreatePrize.Text = "Create Prize";
            this.btnCreatePrize.UseVisualStyleBackColor = true;
            this.btnCreatePrize.Click += new System.EventHandler(this.btnCreatePrize_Click);
            // 
            // lstTeams
            // 
            this.lstTeams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.ItemHeight = 25;
            this.lstTeams.Location = new System.Drawing.Point(370, 114);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(297, 127);
            this.lstTeams.TabIndex = 18;
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblPlayers.Location = new System.Drawing.Point(365, 86);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(123, 25);
            this.lblPlayers.TabIndex = 19;
            this.lblPlayers.Text = "Team/Players";
            // 
            // btnRemoveTeam
            // 
            this.btnRemoveTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRemoveTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnRemoveTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnRemoveTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnRemoveTeam.Location = new System.Drawing.Point(673, 140);
            this.btnRemoveTeam.Name = "btnRemoveTeam";
            this.btnRemoveTeam.Size = new System.Drawing.Size(113, 70);
            this.btnRemoveTeam.TabIndex = 20;
            this.btnRemoveTeam.Text = "Remove Selected";
            this.btnRemoveTeam.UseVisualStyleBackColor = true;
            this.btnRemoveTeam.Click += new System.EventHandler(this.btnRemoveTeam_Click);
            // 
            // btnRemovePrize
            // 
            this.btnRemovePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRemovePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnRemovePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnRemovePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemovePrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemovePrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnRemovePrize.Location = new System.Drawing.Point(673, 310);
            this.btnRemovePrize.Name = "btnRemovePrize";
            this.btnRemovePrize.Size = new System.Drawing.Size(113, 72);
            this.btnRemovePrize.TabIndex = 23;
            this.btnRemovePrize.Text = "Remove Selected";
            this.btnRemovePrize.UseVisualStyleBackColor = true;
            this.btnRemovePrize.Click += new System.EventHandler(this.btnRemovePrize_Click);
            // 
            // lblPrize
            // 
            this.lblPrize.AutoSize = true;
            this.lblPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblPrize.Location = new System.Drawing.Point(365, 249);
            this.lblPrize.Name = "lblPrize";
            this.lblPrize.Size = new System.Drawing.Size(62, 25);
            this.lblPrize.TabIndex = 22;
            this.lblPrize.Text = "Prizes";
            // 
            // lstPrizes
            // 
            this.lstPrizes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstPrizes.FormattingEnabled = true;
            this.lstPrizes.ItemHeight = 25;
            this.lstPrizes.Location = new System.Drawing.Point(370, 277);
            this.lstPrizes.Name = "lstPrizes";
            this.lstPrizes.Size = new System.Drawing.Size(297, 127);
            this.lstPrizes.TabIndex = 21;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateTournament.Location = new System.Drawing.Point(224, 456);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(242, 50);
            this.btnCreateTournament.TabIndex = 24;
            this.btnCreateTournament.Text = "Create Tournament";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            this.btnCreateTournament.Click += new System.EventHandler(this.btnCreateTournament_Click);
            // 
            // frmCreateTournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 518);
            this.Controls.Add(this.btnCreateTournament);
            this.Controls.Add(this.btnRemovePrize);
            this.Controls.Add(this.lblPrize);
            this.Controls.Add(this.lstPrizes);
            this.Controls.Add(this.btnRemoveTeam);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.lstTeams);
            this.Controls.Add(this.btnCreatePrize);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.llbCreateTeam);
            this.Controls.Add(this.cboSelectTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.txtEntryFee);
            this.Controls.Add(this.lblEntryFee);
            this.Controls.Add(this.txtTournamentName);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblCreateTournament);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCreateTournament";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreateTournament;
        private System.Windows.Forms.TextBox txtTournamentName;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.TextBox txtEntryFee;
        private System.Windows.Forms.Label lblEntryFee;
        private System.Windows.Forms.ComboBox cboSelectTeam;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.LinkLabel llbCreateTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnCreatePrize;
        private System.Windows.Forms.ListBox lstTeams;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Button btnRemoveTeam;
        private System.Windows.Forms.Button btnRemovePrize;
        private System.Windows.Forms.Label lblPrize;
        private System.Windows.Forms.ListBox lstPrizes;
        private System.Windows.Forms.Button btnCreateTournament;
    }
}