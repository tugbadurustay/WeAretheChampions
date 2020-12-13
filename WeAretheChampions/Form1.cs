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
    public partial class Form1 : Form
    {
        WeAretheChampionsContext db = new WeAretheChampionsContext();
        BindingList<NewMatch> newMatches = new BindingList<NewMatch>();
        public Form1()
        {
            InitializeComponent();
            dgvMatches.AutoGenerateColumns = false;
            dgvMatches.DataSource = newMatches;

            MaclariListele();

        }

        private void MaclariListele()
        {
            dgvMatches.DataSource = db.Matches.ToList()
            .Select(x => new
            {
                Id = x.Id,
                MatchTime = x.MatchTime?.ToShortDateString(),
                MatchDate = x.MatchTime?.ToShortTimeString(),
                Team1 = x.Team1.TeamName,
                Team2 = x.Team2.TeamName,
                Score1 = x.Score1,
                Score2 = x.Score2,
                Result = x.Result

            }).ToList();
        }


        private void btnNewMatch_Click_1(object sender, EventArgs e)
        {
            NewMatch newMatch = new NewMatch();
            newMatch.ShowDialog();
            MaclariListele();
        }

        private void takimlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamsForm teamsForm = new TeamsForm();
            teamsForm.ShowDialog();
        }


        private void chbBerabere_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tsmiPlayers_Click(object sender, EventArgs e)
        {
            PlayersForm playersForm = new PlayersForm();
            playersForm.ShowDialog();
        }


        private void ıconPictureBox1_Click(object sender, EventArgs e)
        {

            dgvMatches.DataSource = db.Matches.OrderByDescending(x => x.MatchTime).ToList().Select(x => new
            {
                Id = x.Id,
                MatchTime = x.MatchTime?.ToShortDateString(),
                MatchDate = x.MatchTime?.ToShortTimeString(),
                Team1 = x.Team1.TeamName,
                Team2 = x.Team2.TeamName,
                Score1 = x.Score1,
                Score2 = x.Score2,
                Result = x.Result

            }).ToList();

        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            gbUpdate.Visible = true;
            int selectedid = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            Match match = db.Matches.Find(selectedid);
            cboTeam1.DataSource = db.Teams.ToList();
            cboTeam2.DataSource = db.Teams.ToList();
            cboTeam1.SelectedItem = match.Team1;
            cboTeam2.SelectedItem = match.Team2;
            dtpMatchTime.Value = (DateTime)match.MatchTime;
            nudScore1.Value = match.Score1;
            nudScore2.Value = match.Score2;


            MaclariListele();
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            int id = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            Match match = db.Matches.Find(id);
            db.Matches.Remove(match);
            db.SaveChanges();
            MaclariListele();
        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {

            int selectedid = (int)dgvMatches.SelectedRows[0].Cells[0].Value;
            Match match = db.Matches.Find(selectedid);
            match.Team1 = (Team)cboTeam1.SelectedItem;
            match.Team2 = (Team)cboTeam2.SelectedItem;
            match.Score1 = (int)nudScore1.Value;
            match.Score2 = (int)nudScore2.Value;
            match.Result = match.Score1 > match.Score2 ? Result.Team1 : Result.Team2;
            if (match.Score1 == match.Score2)
            {
                match.Result = Result.Berabere;
            }
            match.MatchTime = dtpMatchTime.Value;
            db.SaveChanges();
            MaclariListele();
            gbUpdate.Visible = false;
        }

        private void chbCompleted_CheckedChanged(object sender, EventArgs e)
        {
            if (chbCompleted.Checked == true)
            {
                dgvMatches.DataSource = db.Matches.OrderByDescending(x => x.MatchTime).Where(x => x.Result == null).ToList().Select(x => new
                {
                    Id = x.Id,
                    MatchTime = x.MatchTime?.ToShortDateString(),
                    MatchDate = x.MatchTime?.ToShortTimeString(),
                    Team1 = x.Team1.TeamName,
                    Team2 = x.Team2.TeamName,
                    Score1 = x.Score1,
                    Score2 = x.Score2,
                    Result = x.Result

                }).ToList();
            }
            else
            {
                MaclariListele();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            var dr = MessageBox.Show(
                "Are you sure you want to quit the program?",
                "Closing Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            e.Cancel = dr == DialogResult.No;
        }

        private void btnEditCancel_Click(object sender, EventArgs e)
        {
            gbUpdate.Visible = false;
        }
    }
}
