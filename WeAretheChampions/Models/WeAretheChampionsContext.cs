﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAretheChampions.Models
{
    public class WeAretheChampionsContext : DbContext
    {
        public WeAretheChampionsContext() : base("name=constr")
        {

        }
        //https://stackoverflow.com/questions/5559043/entity-framework-code-first-two-foreign-keys-from-same-table
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Match>()
                        .HasRequired(m => m.Team1)
                        .WithMany(t => t.Team1Matches)
                        .HasForeignKey(m => m.Team1Id)
                        .WillCascadeOnDelete(false);

            modelBuilder.Entity<Match>()
                        .HasRequired(m => m.Team2)
                        .WithMany(t => t.Team2Matches)
                        .HasForeignKey(m => m.Team2Id)
                        .WillCascadeOnDelete(false);
        }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Match> Matches { get; set; }

        public DbSet<Color> Colors { get; set; }
       

    }
}
