using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAretheChampions.Models;

namespace WeAretheChampions
{
    public partial class TeamsForm : Form
    {
        WeAretheChampionsContext db = new WeAretheChampionsContext();

        public event EventHandler TheChangeWasMade;

        public TeamsForm()
        {
            InitializeComponent();
            ToListTeams();
        }

        private void ToListTeams()
        {
            lstTeams.DataSource = db.Teams.ToList();
        }

        protected virtual void WhenTheChangeIsMade(EventArgs args)
        {
           
            TheChangeWasMade?.Invoke(this, args);
        }

        private void btnAddTeam_Click_2(object sender, EventArgs e)
        {
            String TeamName = txtTeamName.Text.Trim();
            if (db.Teams.ToList().Any(x => x.TeamName == TeamName.Replace(" ", "")))
            {
                MessageBox.Show("There is a team record with this name");
                return;
            }

            if (TeamName == "")
                return;

            db.Teams.Add(new Team() { TeamName = TeamName });
            db.SaveChanges();
            ToListTeams();
            MessageBox.Show("New Team added");
            txtTeamName.Clear();

        }

        private void btnSelectedDelete_Click_1(object sender, EventArgs e)
        {

            try
            {
                if (lstTeams.SelectedIndex < 0) return;
                Team selectedTeam = (Team)lstTeams.SelectedItem;
                db.Teams.Remove(selectedTeam);
                db.SaveChanges();
                ToListTeams();
                WhenTheChangeIsMade(EventArgs.Empty);
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry :( you can't delete this team ! There is a match record of the team...", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            btnAddTeam.Visible = false;
            btnUpdate.Visible = true;
            btnCancel.Visible = true;
            var selectedTeam = (Team)lstTeams.SelectedItem;
            txtTeamName.Text = selectedTeam.TeamName;


            WhenTheChangeIsMade(EventArgs.Empty);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var selectedTeam= (Team)lstTeams.SelectedItem;     
            selectedTeam.TeamName = txtTeamName.Text.ToString();
            db.SaveChanges();
            txtTeamName.Clear();
            btnUpdate.Visible = false;
            btnAddTeam.Visible = true;
            ToListTeams();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnAddTeam.Visible = true;
            btnUpdate.Visible = false;
            txtTeamName.Clear();
            btnCancel.Visible = false;
        }
    }
}
