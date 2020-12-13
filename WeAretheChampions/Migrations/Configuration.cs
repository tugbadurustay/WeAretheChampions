namespace WeAretheChampions.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WeAretheChampions.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WeAretheChampions.Models.WeAretheChampionsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;

        }

        protected override void Seed(WeAretheChampions.Models.WeAretheChampionsContext context)
        {
            if (!context.Matches.Any())
                context.Matches.AddRange(Matches());

            if (!context.Players.Any())
                context.Players.AddRange(Players());

            if (!context.Teams.Any())
                context.Teams.AddRange(Teams());
        }

        private List<Team> Teams()
        {
            return new List<Team>
            {
                new Team() {TeamId = 1 , TeamName = "Galatasaray" },
                new Team() {TeamId = 2 , TeamName = "Fenerbahçe" },
                new Team() {TeamId = 3 , TeamName = "Beşiktaş" },
                new Team() {TeamId = 4 , TeamName =  "Ankaragücü" },
            };
        }
        private List<Player> Players()
        {
            return new List<Player>
            {
                new Player() { Id = 1, TeamId = 1 , PlayerName = "Fernando Muslera"},
                new Player() { Id = 2, TeamId = 1 , PlayerName = "Radamel Falcao"},
                new Player() { Id = 3, TeamId = 1 , PlayerName = "Ryan Donk"},
                new Player() { Id = 4, TeamId = 2 , PlayerName = "Miha Zajc"},
                new Player() { Id = 5, TeamId = 2 , PlayerName = "Tolgay Arslan"},
                new Player() { Id = 6, TeamId = 2 , PlayerName = "Enner Valencia"},
                new Player() { Id = 7, TeamId = 3 , PlayerName = "Ersin Destanoğlu"},
                new Player() { Id = 8, TeamId = 3 , PlayerName = "Domagoj Vida"},
                new Player() { Id = 9, TeamId = 3 , PlayerName = "Josef de Souza"},
                new Player() { Id = 10, TeamId = 4 , PlayerName = "Alper Potuk"},
                new Player() { Id = 11, TeamId = 4 , PlayerName = "Orkan Çınar"},
                new Player() { Id = 12, TeamId = 4 , PlayerName = "Atakan Çankaya"}

            };
        }
        private List<Match> Matches()
        {
            return new List<Match>
            {
                new Match() { Id=1 , MatchTime = new DateTime(2020,11,10, 20,55,00) , Team1Id = 1 , Team2Id = 2, Score1 = 0 , Score2 = 0 , Result = 0 },
                new Match() { Id=2 , MatchTime = new DateTime(2020,11,10, 21,45,00 ) , Team1Id = 2 , Team2Id = 3, Score1 = 1 , Score2 = 1 , Result = 0 },
                new Match() { Id=3 , MatchTime = new DateTime(2020,11,10, 20,35,00) , Team1Id = 3 , Team2Id = 4, Score1 = 2 , Score2 = 2 , Result = 0 },
                new Match() { Id=4 , MatchTime = new DateTime(2020,11,10, 20,50,00) , Team1Id = 2 , Team2Id = 1, Score1 = 3 , Score2 = 3 , Result = 0 },

            };
        }
    }
}
