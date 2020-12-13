namespace WeAretheChampions
{
    partial class Form1
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
            if (disposing)
            {
                db.Dispose();
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
            this.ms = new System.Windows.Forms.MenuStrip();
            this.tsmiTeams = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPlayers = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudScore1 = new System.Windows.Forms.NumericUpDown();
            this.nudScore2 = new System.Windows.Forms.NumericUpDown();
            this.cboTeam2 = new System.Windows.Forms.ComboBox();
            this.cboTeam1 = new System.Windows.Forms.ComboBox();
            this.dtpMatchTime = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.btnEditUpdate = new FontAwesome.Sharp.IconButton();
            this.chbCompleted = new System.Windows.Forms.CheckBox();
            this.ıconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnNewMatch = new FontAwesome.Sharp.IconButton();
            this.btnEditSelected = new FontAwesome.Sharp.IconButton();
            this.btnDeleteSelected = new FontAwesome.Sharp.IconButton();
            this.btnEditCancel = new FontAwesome.Sharp.IconButton();
            this.ms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).BeginInit();
            this.gbUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ms
            // 
            this.ms.BackColor = System.Drawing.Color.Snow;
            this.ms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTeams,
            this.tsmiPlayers});
            this.ms.Location = new System.Drawing.Point(0, 0);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(718, 24);
            this.ms.TabIndex = 0;
            this.ms.Text = "menuStrip1";
            // 
            // tsmiTeams
            // 
            this.tsmiTeams.Name = "tsmiTeams";
            this.tsmiTeams.Size = new System.Drawing.Size(52, 20);
            this.tsmiTeams.Text = "Teams";
            this.tsmiTeams.Click += new System.EventHandler(this.takimlarToolStripMenuItem_Click);
            // 
            // tsmiPlayers
            // 
            this.tsmiPlayers.Name = "tsmiPlayers";
            this.tsmiPlayers.Size = new System.Drawing.Size(56, 20);
            this.tsmiPlayers.Text = "Players";
            this.tsmiPlayers.Click += new System.EventHandler(this.tsmiPlayers_Click);
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMatches.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvMatches.Location = new System.Drawing.Point(13, 93);
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.ReadOnly = true;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(685, 277);
            this.dgvMatches.TabIndex = 2;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Id";
            this.Column7.HeaderText = "MatchId";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MatchTime";
            this.Column1.HeaderText = "MatchTime";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "MatchDate";
            this.Column8.HeaderText = "Match Date";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Team1";
            this.Column2.HeaderText = "Team1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Team2";
            this.Column3.HeaderText = "Team2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Score1";
            this.Column4.HeaderText = "Score1";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Score2";
            this.Column5.HeaderText = "Score2";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Result";
            this.Column6.HeaderText = "Result";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // nudScore1
            // 
            this.nudScore1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudScore1.Location = new System.Drawing.Point(85, 136);
            this.nudScore1.Name = "nudScore1";
            this.nudScore1.Size = new System.Drawing.Size(30, 20);
            this.nudScore1.TabIndex = 37;
            // 
            // nudScore2
            // 
            this.nudScore2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudScore2.Location = new System.Drawing.Point(85, 162);
            this.nudScore2.Name = "nudScore2";
            this.nudScore2.Size = new System.Drawing.Size(30, 20);
            this.nudScore2.TabIndex = 38;
            // 
            // cboTeam2
            // 
            this.cboTeam2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTeam2.DisplayMember = "TeamName";
            this.cboTeam2.FormattingEnabled = true;
            this.cboTeam2.Location = new System.Drawing.Point(89, 106);
            this.cboTeam2.Name = "cboTeam2";
            this.cboTeam2.Size = new System.Drawing.Size(198, 21);
            this.cboTeam2.TabIndex = 35;
            // 
            // cboTeam1
            // 
            this.cboTeam1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTeam1.DisplayMember = "TeamName";
            this.cboTeam1.FormattingEnabled = true;
            this.cboTeam1.Location = new System.Drawing.Point(89, 67);
            this.cboTeam1.Name = "cboTeam1";
            this.cboTeam1.Size = new System.Drawing.Size(198, 21);
            this.cboTeam1.TabIndex = 36;
            // 
            // dtpMatchTime
            // 
            this.dtpMatchTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpMatchTime.CustomFormat = "MM.dd.yyyy hh:mm tt";
            this.dtpMatchTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMatchTime.Location = new System.Drawing.Point(89, 30);
            this.dtpMatchTime.Name = "dtpMatchTime";
            this.dtpMatchTime.Size = new System.Drawing.Size(198, 20);
            this.dtpMatchTime.TabIndex = 34;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(210, 639);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 27);
            this.btnUpdate.TabIndex = 33;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(10, 639);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 27);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Score2 : ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Team 2 : ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Score1 : ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Team 1 : ";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Match Time :";
            // 
            // gbUpdate
            // 
            this.gbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gbUpdate.BackgroundImage = global::WeAretheChampions.Properties.Resources.saha;
            this.gbUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbUpdate.Controls.Add(this.btnEditCancel);
            this.gbUpdate.Controls.Add(this.btnEditUpdate);
            this.gbUpdate.Controls.Add(this.label5);
            this.gbUpdate.Controls.Add(this.label2);
            this.gbUpdate.Controls.Add(this.nudScore1);
            this.gbUpdate.Controls.Add(this.label4);
            this.gbUpdate.Controls.Add(this.nudScore2);
            this.gbUpdate.Controls.Add(this.label3);
            this.gbUpdate.Controls.Add(this.cboTeam2);
            this.gbUpdate.Controls.Add(this.label6);
            this.gbUpdate.Controls.Add(this.cboTeam1);
            this.gbUpdate.Controls.Add(this.dtpMatchTime);
            this.gbUpdate.Location = new System.Drawing.Point(16, 404);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(304, 194);
            this.gbUpdate.TabIndex = 40;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Update Matches";
            this.gbUpdate.Visible = false;
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.BackColor = System.Drawing.Color.White;
            this.btnEditUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnEditUpdate.IconChar = FontAwesome.Sharp.IconChar.React;
            this.btnEditUpdate.IconColor = System.Drawing.Color.DarkGreen;
            this.btnEditUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditUpdate.IconSize = 40;
            this.btnEditUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditUpdate.Location = new System.Drawing.Point(121, 139);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(76, 43);
            this.btnEditUpdate.TabIndex = 46;
            this.btnEditUpdate.Text = "UPDATE";
            this.btnEditUpdate.UseVisualStyleBackColor = false;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // chbCompleted
            // 
            this.chbCompleted.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chbCompleted.AutoSize = true;
            this.chbCompleted.BackColor = System.Drawing.Color.Snow;
            this.chbCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chbCompleted.ForeColor = System.Drawing.Color.OliveDrab;
            this.chbCompleted.Location = new System.Drawing.Point(490, 70);
            this.chbCompleted.Name = "chbCompleted";
            this.chbCompleted.Size = new System.Drawing.Size(145, 17);
            this.chbCompleted.TabIndex = 41;
            this.chbCompleted.Text = "Hide Completed Matches";
            this.chbCompleted.UseVisualStyleBackColor = false;
            this.chbCompleted.CheckedChanged += new System.EventHandler(this.chbCompleted_CheckedChanged);
            // 
            // ıconPictureBox1
            // 
            this.ıconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ıconPictureBox1.BackColor = System.Drawing.Color.White;
            this.ıconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ıconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.SortAmountDown;
            this.ıconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ıconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ıconPictureBox1.IconSize = 34;
            this.ıconPictureBox1.Location = new System.Drawing.Point(641, 53);
            this.ıconPictureBox1.Name = "ıconPictureBox1";
            this.ıconPictureBox1.Size = new System.Drawing.Size(43, 34);
            this.ıconPictureBox1.TabIndex = 42;
            this.ıconPictureBox1.TabStop = false;
            this.ıconPictureBox1.Click += new System.EventHandler(this.ıconPictureBox1_Click);
            // 
            // btnNewMatch
            // 
            this.btnNewMatch.BackColor = System.Drawing.Color.Snow;
            this.btnNewMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewMatch.IconChar = FontAwesome.Sharp.IconChar.FootballBall;
            this.btnNewMatch.IconColor = System.Drawing.Color.Olive;
            this.btnNewMatch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewMatch.IconSize = 30;
            this.btnNewMatch.Location = new System.Drawing.Point(12, 53);
            this.btnNewMatch.Name = "btnNewMatch";
            this.btnNewMatch.Size = new System.Drawing.Size(110, 33);
            this.btnNewMatch.TabIndex = 43;
            this.btnNewMatch.Text = "NEW MATCH";
            this.btnNewMatch.UseVisualStyleBackColor = false;
            this.btnNewMatch.Click += new System.EventHandler(this.btnNewMatch_Click_1);
            // 
            // btnEditSelected
            // 
            this.btnEditSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditSelected.BackColor = System.Drawing.Color.Snow;
            this.btnEditSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditSelected.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnEditSelected.IconColor = System.Drawing.Color.OliveDrab;
            this.btnEditSelected.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditSelected.IconSize = 30;
            this.btnEditSelected.Location = new System.Drawing.Point(384, 405);
            this.btnEditSelected.Name = "btnEditSelected";
            this.btnEditSelected.Size = new System.Drawing.Size(142, 37);
            this.btnEditSelected.TabIndex = 44;
            this.btnEditSelected.Text = "EDİT SELECTED";
            this.btnEditSelected.UseVisualStyleBackColor = false;
            this.btnEditSelected.Click += new System.EventHandler(this.btnEditSelected_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteSelected.BackColor = System.Drawing.Color.White;
            this.btnDeleteSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteSelected.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDeleteSelected.IconColor = System.Drawing.Color.DarkRed;
            this.btnDeleteSelected.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteSelected.IconSize = 25;
            this.btnDeleteSelected.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDeleteSelected.Location = new System.Drawing.Point(542, 405);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(156, 37);
            this.btnDeleteSelected.TabIndex = 45;
            this.btnDeleteSelected.Text = "DELETE SELECTED";
            this.btnDeleteSelected.UseVisualStyleBackColor = false;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
            // 
            // btnEditCancel
            // 
            this.btnEditCancel.BackColor = System.Drawing.Color.White;
            this.btnEditCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEditCancel.ForeColor = System.Drawing.Color.Black;
            this.btnEditCancel.IconChar = FontAwesome.Sharp.IconChar.Walking;
            this.btnEditCancel.IconColor = System.Drawing.Color.Red;
            this.btnEditCancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditCancel.IconSize = 40;
            this.btnEditCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditCancel.Location = new System.Drawing.Point(203, 139);
            this.btnEditCancel.Name = "btnEditCancel";
            this.btnEditCancel.Size = new System.Drawing.Size(76, 43);
            this.btnEditCancel.TabIndex = 46;
            this.btnEditCancel.Text = "CANCEL";
            this.btnEditCancel.UseVisualStyleBackColor = false;
            this.btnEditCancel.Click += new System.EventHandler(this.btnEditCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeAretheChampions.Properties.Resources.match;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(718, 598);
            this.Controls.Add(this.btnDeleteSelected);
            this.Controls.Add(this.btnEditSelected);
            this.Controls.Add(this.btnNewMatch);
            this.Controls.Add(this.ıconPictureBox1);
            this.Controls.Add(this.chbCompleted);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvMatches);
            this.Controls.Add(this.ms);
            this.MainMenuStrip = this.ms;
            this.MinimumSize = new System.Drawing.Size(676, 637);
            this.Name = "Form1";
            this.Text = "We Are the Champions 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ms.ResumeLayout(false);
            this.ms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScore2)).EndInit();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ıconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms;
        private System.Windows.Forms.ToolStripMenuItem tsmiTeams;
        private System.Windows.Forms.ToolStripMenuItem tsmiPlayers;
        public System.Windows.Forms.DataGridView dgvMatches;
        public System.Windows.Forms.NumericUpDown nudScore1;
        public System.Windows.Forms.NumericUpDown nudScore2;
        public System.Windows.Forms.ComboBox cboTeam2;
        public System.Windows.Forms.ComboBox cboTeam1;
        public System.Windows.Forms.DateTimePicker dtpMatchTime;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.CheckBox chbCompleted;
        private FontAwesome.Sharp.IconPictureBox ıconPictureBox1;
        private FontAwesome.Sharp.IconButton btnNewMatch;
        private FontAwesome.Sharp.IconButton btnEditSelected;
        private FontAwesome.Sharp.IconButton btnDeleteSelected;
        private FontAwesome.Sharp.IconButton btnEditUpdate;
        private FontAwesome.Sharp.IconButton btnEditCancel;
    }
}

