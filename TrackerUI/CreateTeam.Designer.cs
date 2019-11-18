namespace TrackerUI
{
    partial class frmCreateTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateTeam));
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamName = new System.Windows.Forms.Label();
            this.lblCreateTeam = new System.Windows.Forms.Label();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.cboSelectTeam = new System.Windows.Forms.ComboBox();
            this.lblSelectTeam = new System.Windows.Forms.Label();
            this.grpAddNewMember = new System.Windows.Forms.GroupBox();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.txtCellphone = new System.Windows.Forms.TextBox();
            this.lblCellphone = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtLastNameOne = new System.Windows.Forms.TextBox();
            this.lblLastNameOne = new System.Windows.Forms.Label();
            this.txtFirstNameOne = new System.Windows.Forms.TextBox();
            this.lblFirstNameOne = new System.Windows.Forms.Label();
            this.lstTeamMembers = new System.Windows.Forms.ListBox();
            this.btnRemoveTeam = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.grpAddNewMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(21, 114);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(355, 35);
            this.txtTeamName.TabIndex = 13;
            // 
            // lblTeamName
            // 
            this.lblTeamName.AutoSize = true;
            this.lblTeamName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTeamName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamName.Location = new System.Drawing.Point(16, 86);
            this.lblTeamName.Name = "lblTeamName";
            this.lblTeamName.Size = new System.Drawing.Size(129, 30);
            this.lblTeamName.TabIndex = 12;
            this.lblTeamName.Text = "Team Name:";
            // 
            // lblCreateTeam
            // 
            this.lblCreateTeam.AutoSize = true;
            this.lblCreateTeam.BackColor = System.Drawing.Color.White;
            this.lblCreateTeam.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblCreateTeam.Location = new System.Drawing.Point(12, 9);
            this.lblCreateTeam.Name = "lblCreateTeam";
            this.lblCreateTeam.Size = new System.Drawing.Size(213, 50);
            this.lblCreateTeam.TabIndex = 11;
            this.lblCreateTeam.Text = "Create Team";
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddTeam.Location = new System.Drawing.Point(115, 224);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(176, 44);
            this.btnAddTeam.TabIndex = 19;
            this.btnAddTeam.Text = "Add Player";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // cboSelectTeam
            // 
            this.cboSelectTeam.FormattingEnabled = true;
            this.cboSelectTeam.Location = new System.Drawing.Point(23, 180);
            this.cboSelectTeam.Name = "cboSelectTeam";
            this.cboSelectTeam.Size = new System.Drawing.Size(353, 38);
            this.cboSelectTeam.TabIndex = 18;
            // 
            // lblSelectTeam
            // 
            this.lblSelectTeam.AutoSize = true;
            this.lblSelectTeam.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblSelectTeam.Location = new System.Drawing.Point(16, 152);
            this.lblSelectTeam.Name = "lblSelectTeam";
            this.lblSelectTeam.Size = new System.Drawing.Size(115, 25);
            this.lblSelectTeam.TabIndex = 17;
            this.lblSelectTeam.Text = "Select Team:";
            // 
            // grpAddNewMember
            // 
            this.grpAddNewMember.Controls.Add(this.btnCreateMember);
            this.grpAddNewMember.Controls.Add(this.txtCellphone);
            this.grpAddNewMember.Controls.Add(this.lblCellphone);
            this.grpAddNewMember.Controls.Add(this.txtEmail);
            this.grpAddNewMember.Controls.Add(this.lblEmail);
            this.grpAddNewMember.Controls.Add(this.txtLastNameOne);
            this.grpAddNewMember.Controls.Add(this.lblLastNameOne);
            this.grpAddNewMember.Controls.Add(this.txtFirstNameOne);
            this.grpAddNewMember.Controls.Add(this.lblFirstNameOne);
            this.grpAddNewMember.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddNewMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.grpAddNewMember.Location = new System.Drawing.Point(21, 298);
            this.grpAddNewMember.Name = "grpAddNewMember";
            this.grpAddNewMember.Size = new System.Drawing.Size(355, 268);
            this.grpAddNewMember.TabIndex = 20;
            this.grpAddNewMember.TabStop = false;
            this.grpAddNewMember.Text = "Add New Member";
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateMember.Location = new System.Drawing.Point(94, 205);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(176, 44);
            this.btnCreateMember.TabIndex = 25;
            this.btnCreateMember.Text = "Create Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            this.btnCreateMember.Click += new System.EventHandler(this.btnCreateMember_Click);
            // 
            // txtCellphone
            // 
            this.txtCellphone.Location = new System.Drawing.Point(124, 167);
            this.txtCellphone.Name = "txtCellphone";
            this.txtCellphone.Size = new System.Drawing.Size(225, 35);
            this.txtCellphone.TabIndex = 16;
            // 
            // lblCellphone
            // 
            this.lblCellphone.AutoSize = true;
            this.lblCellphone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCellphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblCellphone.Location = new System.Drawing.Point(6, 172);
            this.lblCellphone.Name = "lblCellphone";
            this.lblCellphone.Size = new System.Drawing.Size(111, 30);
            this.lblCellphone.TabIndex = 15;
            this.lblCellphone.Text = "Cellphone:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 126);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(225, 35);
            this.txtEmail.TabIndex = 14;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblEmail.Location = new System.Drawing.Point(6, 131);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(68, 30);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email:";
            // 
            // txtLastNameOne
            // 
            this.txtLastNameOne.Location = new System.Drawing.Point(124, 85);
            this.txtLastNameOne.Name = "txtLastNameOne";
            this.txtLastNameOne.Size = new System.Drawing.Size(225, 35);
            this.txtLastNameOne.TabIndex = 12;
            // 
            // lblLastNameOne
            // 
            this.lblLastNameOne.AutoSize = true;
            this.lblLastNameOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblLastNameOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblLastNameOne.Location = new System.Drawing.Point(6, 90);
            this.lblLastNameOne.Name = "lblLastNameOne";
            this.lblLastNameOne.Size = new System.Drawing.Size(117, 30);
            this.lblLastNameOne.TabIndex = 11;
            this.lblLastNameOne.Text = "Last Name:";
            // 
            // txtFirstNameOne
            // 
            this.txtFirstNameOne.Location = new System.Drawing.Point(124, 44);
            this.txtFirstNameOne.Name = "txtFirstNameOne";
            this.txtFirstNameOne.Size = new System.Drawing.Size(225, 35);
            this.txtFirstNameOne.TabIndex = 10;
            // 
            // lblFirstNameOne
            // 
            this.lblFirstNameOne.AutoSize = true;
            this.lblFirstNameOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFirstNameOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblFirstNameOne.Location = new System.Drawing.Point(6, 49);
            this.lblFirstNameOne.Name = "lblFirstNameOne";
            this.lblFirstNameOne.Size = new System.Drawing.Size(118, 30);
            this.lblFirstNameOne.TabIndex = 9;
            this.lblFirstNameOne.Text = "First Name:";
            // 
            // lstTeamMembers
            // 
            this.lstTeamMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstTeamMembers.FormattingEnabled = true;
            this.lstTeamMembers.ItemHeight = 30;
            this.lstTeamMembers.Location = new System.Drawing.Point(399, 114);
            this.lstTeamMembers.Name = "lstTeamMembers";
            this.lstTeamMembers.Size = new System.Drawing.Size(291, 452);
            this.lstTeamMembers.TabIndex = 21;
            // 
            // btnRemoveTeam
            // 
            this.btnRemoveTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRemoveTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnRemoveTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnRemoveTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnRemoveTeam.Location = new System.Drawing.Point(696, 308);
            this.btnRemoveTeam.Name = "btnRemoveTeam";
            this.btnRemoveTeam.Size = new System.Drawing.Size(106, 38);
            this.btnRemoveTeam.TabIndex = 22;
            this.btnRemoveTeam.Text = "Remove";
            this.btnRemoveTeam.UseVisualStyleBackColor = true;
            this.btnRemoveTeam.Click += new System.EventHandler(this.btnRemoveTeam_Click);
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCreateTeam.Location = new System.Drawing.Point(277, 572);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(176, 44);
            this.btnCreateTeam.TabIndex = 26;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // frmCreateTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.btnCreateTeam);
            this.Controls.Add(this.btnRemoveTeam);
            this.Controls.Add(this.lstTeamMembers);
            this.Controls.Add(this.grpAddNewMember);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.cboSelectTeam);
            this.Controls.Add(this.lblSelectTeam);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.lblTeamName);
            this.Controls.Add(this.lblCreateTeam);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmCreateTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Team";
            this.grpAddNewMember.ResumeLayout(false);
            this.grpAddNewMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeamName;
        private System.Windows.Forms.Label lblCreateTeam;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.ComboBox cboSelectTeam;
        private System.Windows.Forms.Label lblSelectTeam;
        private System.Windows.Forms.GroupBox grpAddNewMember;
        private System.Windows.Forms.TextBox txtCellphone;
        private System.Windows.Forms.Label lblCellphone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtLastNameOne;
        private System.Windows.Forms.Label lblLastNameOne;
        private System.Windows.Forms.TextBox txtFirstNameOne;
        private System.Windows.Forms.Label lblFirstNameOne;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.ListBox lstTeamMembers;
        private System.Windows.Forms.Button btnRemoveTeam;
        private System.Windows.Forms.Button btnCreateTeam;
    }
}