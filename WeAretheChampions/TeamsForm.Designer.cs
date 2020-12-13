namespace WeAretheChampions
{
    partial class TeamsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lstTeams = new System.Windows.Forms.ListBox();
            this.btnEditTeam = new FontAwesome.Sharp.IconButton();
            this.btnAddTeam = new FontAwesome.Sharp.IconButton();
            this.btnSelectedDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnCancel = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Khaki;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(28, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Team Name :";
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(116, 35);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(119, 20);
            this.txtTeamName.TabIndex = 38;
            // 
            // lstTeams
            // 
            this.lstTeams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstTeams.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.lstTeams.DisplayMember = "TeamName";
            this.lstTeams.FormattingEnabled = true;
            this.lstTeams.Location = new System.Drawing.Point(241, 35);
            this.lstTeams.Name = "lstTeams";
            this.lstTeams.Size = new System.Drawing.Size(277, 251);
            this.lstTeams.TabIndex = 44;
            // 
            // btnEditTeam
            // 
            this.btnEditTeam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditTeam.BackColor = System.Drawing.Color.Khaki;
            this.btnEditTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditTeam.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnEditTeam.IconColor = System.Drawing.Color.Olive;
            this.btnEditTeam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditTeam.IconSize = 30;
            this.btnEditTeam.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditTeam.Location = new System.Drawing.Point(241, 292);
            this.btnEditTeam.Name = "btnEditTeam";
            this.btnEditTeam.Size = new System.Drawing.Size(119, 40);
            this.btnEditTeam.TabIndex = 45;
            this.btnEditTeam.Text = "EDİT TEAM     ";
            this.btnEditTeam.UseVisualStyleBackColor = false;
            this.btnEditTeam.Click += new System.EventHandler(this.btnEditTeam_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.BackColor = System.Drawing.Color.Khaki;
            this.btnAddTeam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddTeam.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnAddTeam.IconColor = System.Drawing.Color.Olive;
            this.btnAddTeam.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddTeam.IconSize = 30;
            this.btnAddTeam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTeam.Location = new System.Drawing.Point(116, 61);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(119, 32);
            this.btnAddTeam.TabIndex = 46;
            this.btnAddTeam.Text = "      ADD TEAM";
            this.btnAddTeam.UseVisualStyleBackColor = false;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click_2);
            // 
            // btnSelectedDelete
            // 
            this.btnSelectedDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectedDelete.BackColor = System.Drawing.Color.Khaki;
            this.btnSelectedDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelectedDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelectedDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnSelectedDelete.IconColor = System.Drawing.Color.Maroon;
            this.btnSelectedDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSelectedDelete.IconSize = 20;
            this.btnSelectedDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectedDelete.Location = new System.Drawing.Point(366, 292);
            this.btnSelectedDelete.Name = "btnSelectedDelete";
            this.btnSelectedDelete.Size = new System.Drawing.Size(152, 40);
            this.btnSelectedDelete.TabIndex = 47;
            this.btnSelectedDelete.Text = "     SELECTED DELETE";
            this.btnSelectedDelete.UseVisualStyleBackColor = false;
            this.btnSelectedDelete.Click += new System.EventHandler(this.btnSelectedDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Khaki;
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.React;
            this.btnUpdate.IconColor = System.Drawing.Color.Olive;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 30;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(116, 61);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(119, 31);
            this.btnUpdate.TabIndex = 48;
            this.btnUpdate.Text = "     UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Khaki;
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCancel.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.btnCancel.IconColor = System.Drawing.Color.Red;
            this.btnCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancel.IconSize = 30;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(116, 99);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 31);
            this.btnCancel.TabIndex = 48;
            this.btnCancel.Text = "     CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // TeamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeAretheChampions.Properties.Resources.champ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(542, 390);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSelectedDelete);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.lstTeams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.btnEditTeam);
            this.MinimumSize = new System.Drawing.Size(458, 378);
            this.Name = "TeamsForm";
            this.Text = "TeamsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.ListBox lstTeams;
        private FontAwesome.Sharp.IconButton btnEditTeam;
        private FontAwesome.Sharp.IconButton btnAddTeam;
        private FontAwesome.Sharp.IconButton btnSelectedDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnCancel;
    }
}