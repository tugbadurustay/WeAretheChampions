using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAretheChampions.Models;

namespace WeAretheChampions
{
    public partial class NewMatch : Form
    {
        WeAretheChampionsContext db = new WeAretheChampionsContext();
        public NewMatch()
        {
          
            InitializeComponent();
            NewMatchList();
        }

        private void NewMatchList()
        {
            var team1 = db.Teams.ToList();
            cboTeam1.DataSource = team1;

            var team2 = db.Teams.ToList();
            cboTeam2.DataSource = team2;
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {

            Team team1 = (Team)cboTeam1.SelectedItem;
            Team team2 = (Team)cboTeam2.SelectedItem;
            if (team1.TeamId == team2.TeamId)
            {
                MessageBox.Show("No matches between the same teams");
                return;
            }
            DateTime? Matchdate = dtpMatchTime.Value;
            db.Matches.Add(new Match() { Team1 = team1, Team2 = team2, MatchTime = Matchdate });
            db.SaveChanges();
            Close();
            MessageBox.Show("New match added");
        }
    }
}
