using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAretheChampions.Models;

namespace WeAretheChampions
{
    public partial class PlayersForm : Form
    {
        WeAretheChampionsContext db = new WeAretheChampionsContext();

        public PlayersForm()
        {
            InitializeComponent();
            ToListPlayer();
            ToListTeams();
        }

        private void ToListTeams()
        {
            var Team = db.Teams.ToList();
            cboTeamName.DataSource = Team;
        }

        private void ToListPlayer()
        {
            dgvPlayer.DataSource = db.Players.ToList().Select(x => new
            {
                Id = x.Id,
                PlayerName = x.PlayerName,
                TeamId = x.TeamId

            }).ToList();
        }

        private void btnAddPlayer_Click_1(object sender, EventArgs e)
        {

            Team team = (Team)cboTeamName.SelectedItem;
            string PlayerName = txtPlayerName.Text.ToUpperInvariant();

            db.Players.Add(new Player() { PlayerName = PlayerName, Team = team });
            db.SaveChanges();
            ToListPlayer();
            MessageBox.Show("New player added");

        }

        private void btnEditSelected_Click_1(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnCancel.Visible = true;
            int selectedid = (int)dgvPlayer.SelectedRows[0].Cells[0].Value;
            Player player = db.Players.Find(selectedid);
            Team team = db.Teams.Find(selectedid);
            txtPlayerName.Text = player.PlayerName;
            cboTeamName.SelectedItem = player.Team;
            ToListPlayer();
            cboTeamName.Enabled = false;
            btnAddPlayer.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedid = (int)dgvPlayer.SelectedRows[0].Cells[0].Value;
            Player player = db.Players.Find(selectedid);
            player.PlayerName = txtPlayerName.Text.ToString();
            db.SaveChanges();
            ToListPlayer();
            btnAddPlayer.Visible = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
            cboTeamName.Enabled = true;
        }

        private void btnSelectedDelete_Click_1(object sender, EventArgs e)
        {
            int PlayerId = (int)dgvPlayer.SelectedRows[0].Cells[0].Value;
            Player player = db.Players.Find(PlayerId);
            db.Players.Remove(player);
            db.SaveChanges();
            ToListPlayer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPlayerName.Clear();
            cboTeamName.Enabled = true;
            btnAddPlayer.Visible = true;
            btnCancel.Visible = false;
            btnUpdate.Visible = false;
        }
    }
}