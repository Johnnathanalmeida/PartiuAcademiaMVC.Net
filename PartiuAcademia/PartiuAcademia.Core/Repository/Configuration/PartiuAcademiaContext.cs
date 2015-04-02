using PartiuAcademia.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartiuAcademia.Core.Repository.Configuration
{
    public class PartiuAcademiaContext : DbContext
    {
        public PartiuAcademiaContext() : base("PartiuAcademiaConnectionString") { }

      //  public DbSet<Address> Address { get; set; }

        public DbSet<Category> Category { get; set; }

        public DbSet<City> City { get; set; }

        public DbSet<District> District { get; set; }

        public DbSet<Exercise> Exercise { get; set; }

        public DbSet<Frequency> Frequency { get; set; }

        public DbSet<Gym> Gym { get; set; }

        public DbSet<GymUserModality> GymUserModality { get; set; }

        public DbSet<Horary> Horary { get; set; }

        public DbSet<Modality> Modality { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<State> State { get; set; }

        public DbSet<Team> Team { get; set; }

        public DbSet<Training> Training { get; set; }

        public DbSet<TrainingRecord> TrainingRecord { get; set; }

        public DbSet<User> User { get; set; }
               

    }
}
