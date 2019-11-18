namespace TrackerUI
{
    partial class frmTournamentViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTournamentViewer));
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.lblRound = new System.Windows.Forms.Label();
            this.cboRound = new System.Windows.Forms.ComboBox();
            this.chkUnplayed = new System.Windows.Forms.CheckBox();
            this.lstMatchup = new System.Windows.Forms.ListBox();
            this.lblTeamOne = new System.Windows.Forms.Label();
            this.lblTeamOneScore = new System.Windows.Forms.Label();
            this.txtTeamOneScore = new System.Windows.Forms.TextBox();
            this.txtTeamTwoScore = new System.Windows.Forms.TextBox();
            this.lblTeamTwoScore = new System.Windows.Forms.Label();
            this.lblTeamTwo = new System.Windows.Forms.Label();
            this.lvlVs = new System.Windows.Forms.Label();
            this.btnScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.White;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(214, 50);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tournament:";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.BackColor = System.Drawing.Color.White;
            this.lblTournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTournamentName.Location = new System.Drawing.Point(232, 9);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(156, 50);
            this.lblTournamentName.TabIndex = 1;
            this.lblTournamentName.Text = "<None>";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblRound.Location = new System.Drawing.Point(21, 75);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(100, 37);
            this.lblRound.TabIndex = 2;
            this.lblRound.Text = "Round:";
            // 
            // cboRound
            // 
            this.cboRound.FormattingEnabled = true;
            this.cboRound.Location = new System.Drawing.Point(127, 74);
            this.cboRound.Name = "cboRound";
            this.cboRound.Size = new System.Drawing.Size(198, 38);
            this.cboRound.TabIndex = 3;
            // 
            // chkUnplayed
            // 
            this.chkUnplayed.AutoSize = true;
            this.chkUnplayed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkUnplayed.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnplayed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.chkUnplayed.Location = new System.Drawing.Point(127, 118);
            this.chkUnplayed.Name = "chkUnplayed";
            this.chkUnplayed.Size = new System.Drawing.Size(209, 41);
            this.chkUnplayed.TabIndex = 4;
            this.chkUnplayed.Text = "Unplayed Only";
            this.chkUnplayed.UseVisualStyleBackColor = true;
            // 
            // lstMatchup
            // 
            this.lstMatchup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstMatchup.FormattingEnabled = true;
            this.lstMatchup.ItemHeight = 30;
            this.lstMatchup.Location = new System.Drawing.Point(28, 168);
            this.lstMatchup.Name = "lstMatchup";
            this.lstMatchup.Size = new System.Drawing.Size(297, 212);
            this.lstMatchup.TabIndex = 5;
            // 
            // lblTeamOne
            // 
            this.lblTeamOne.AutoSize = true;
            this.lblTeamOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTeamOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamOne.Location = new System.Drawing.Point(352, 168);
            this.lblTeamOne.Name = "lblTeamOne";
            this.lblTeamOne.Size = new System.Drawing.Size(107, 30);
            this.lblTeamOne.TabIndex = 6;
            this.lblTeamOne.Text = "<Team 1>";
            // 
            // lblTeamOneScore
            // 
            this.lblTeamOneScore.AutoSize = true;
            this.lblTeamOneScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTeamOneScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamOneScore.Location = new System.Drawing.Point(352, 215);
            this.lblTeamOneScore.Name = "lblTeamOneScore";
            this.lblTeamOneScore.Size = new System.Drawing.Size(69, 30);
            this.lblTeamOneScore.TabIndex = 7;
            this.lblTeamOneScore.Text = "Score:";
            // 
            // txtTeamOneScore
            // 
            this.txtTeamOneScore.Location = new System.Drawing.Point(427, 210);
            this.txtTeamOneScore.Name = "txtTeamOneScore";
            this.txtTeamOneScore.Size = new System.Drawing.Size(100, 35);
            this.txtTeamOneScore.TabIndex = 8;
            // 
            // txtTeamTwoScore
            // 
            this.txtTeamTwoScore.Location = new System.Drawing.Point(427, 345);
            this.txtTeamTwoScore.Name = "txtTeamTwoScore";
            this.txtTeamTwoScore.Size = new System.Drawing.Size(100, 35);
            this.txtTeamTwoScore.TabIndex = 11;
            // 
            // lblTeamTwoScore
            // 
            this.lblTeamTwoScore.AutoSize = true;
            this.lblTeamTwoScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTeamTwoScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamTwoScore.Location = new System.Drawing.Point(352, 350);
            this.lblTeamTwoScore.Name = "lblTeamTwoScore";
            this.lblTeamTwoScore.Size = new System.Drawing.Size(69, 30);
            this.lblTeamTwoScore.TabIndex = 10;
            this.lblTeamTwoScore.Text = "Score:";
            // 
            // lblTeamTwo
            // 
            this.lblTeamTwo.AutoSize = true;
            this.lblTeamTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTeamTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.lblTeamTwo.Location = new System.Drawing.Point(352, 303);
            this.lblTeamTwo.Name = "lblTeamTwo";
            this.lblTeamTwo.Size = new System.Drawing.Size(107, 30);
            this.lblTeamTwo.TabIndex = 9;
            this.lblTeamTwo.Text = "<Team 2>";
            // 
            // lvlVs
            // 
            this.lvlVs.AutoSize = true;
            this.lvlVs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lvlVs.ForeColor = System.Drawing.Color.Black;
            this.lvlVs.Location = new System.Drawing.Point(407, 261);
            this.lvlVs.Name = "lvlVs";
            this.lvlVs.Size = new System.Drawing.Size(65, 30);
            this.lvlVs.TabIndex = 12;
            this.lvlVs.Text = "- VS -";
            // 
            // btnScore
            // 
            this.btnScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.btnScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScore.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnScore.Location = new System.Drawing.Point(565, 261);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(113, 50);
            this.btnScore.TabIndex = 13;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            // 
            // frmTournamentViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(702, 409);
            this.Controls.Add(this.btnScore);
            this.Controls.Add(this.lvlVs);
            this.Controls.Add(this.txtTeamTwoScore);
            this.Controls.Add(this.lblTeamTwoScore);
            this.Controls.Add(this.lblTeamTwo);
            this.Controls.Add(this.txtTeamOneScore);
            this.Controls.Add(this.lblTeamOneScore);
            this.Controls.Add(this.lblTeamOne);
            this.Controls.Add(this.lstMatchup);
            this.Controls.Add(this.chkUnplayed);
            this.Controls.Add(this.cboRound);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblTournamentName);
            this.Controls.Add(this.lblHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmTournamentViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTournamentName;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.ComboBox cboRound;
        private System.Windows.Forms.CheckBox chkUnplayed;
        private System.Windows.Forms.ListBox lstMatchup;
        private System.Windows.Forms.Label lblTeamOne;
        private System.Windows.Forms.Label lblTeamOneScore;
        private System.Windows.Forms.TextBox txtTeamOneScore;
        private System.Windows.Forms.TextBox txtTeamTwoScore;
        private System.Windows.Forms.Label lblTeamTwoScore;
        private System.Windows.Forms.Label lblTeamTwo;
        private System.Windows.Forms.Label lvlVs;
        private System.Windows.Forms.Button btnScore;
    }
}

