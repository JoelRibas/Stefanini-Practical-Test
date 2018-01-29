using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using Stefanini.Types;
using Stefanini.Domain.Entities;
using Stefanini.Domain.Views;

namespace Stefanini.Data
{
    public class StefaniniContext : DbContext
    {

        #region Constants

        private string schema = "dbo";

        #endregion

        #region Constructors

        public StefaniniContext(string connectionString, string schema) : base(connectionString)
        {
            this.Configuration.LazyLoadingEnabled = true;
            Database.SetInitializer<StefaniniContext>(null);
            this.schema = schema;
        }

        #endregion

        #region DbSets

        #region Tables

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Classification> Classification { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<UserSys> UserSys { get; set; }

        #endregion

        #region Views

        public virtual DbSet<View_Customer> View_Customer { get; set; }

        #endregion

        #endregion

        #region ModelCreating

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<IdKeyDiscoveryConvention>();
            modelBuilder.HasDefaultSchema(this.schema);

            #region Tables

            modelBuilder.Entity<City>().ToTable("City", this.schema).HasKey(entity => entity.Id);
            modelBuilder.Entity<Classification>().ToTable("Classification", this.schema).HasKey(entity => entity.Id);
            modelBuilder.Entity<Customer>().ToTable("Customer", this.schema).HasKey(entity => entity.Id);
            modelBuilder.Entity<Gender>().ToTable("Gender", this.schema).HasKey(entity => entity.Id);
            modelBuilder.Entity<Region>().ToTable("Region", this.schema).HasKey(entity => entity.Id);
            modelBuilder.Entity<UserRole>().ToTable("UserRole", this.schema).HasKey(entity => entity.Id);
            modelBuilder.Entity<UserSys>().ToTable("UserSys", this.schema).HasKey(entity => entity.Id);

            #endregion

            #region Views

            modelBuilder.Entity<View_Customer>().ToTable("View_Customer", this.schema).HasKey(entity => entity.CustomerId);

            #endregion

        }

        #endregion

        #region Factory

        public static StefaniniContext Create(DatabaseConnectionSettings settings)
        {
            string connectionString = null;
            System.Data.SqlClient.SqlConnectionStringBuilder sqlBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            sqlBuilder.DataSource = settings.Server;
            sqlBuilder.InitialCatalog = settings.Database;
            sqlBuilder.IntegratedSecurity = settings.IntegratedSecurity;
            if (!settings.IntegratedSecurity)
            {
                sqlBuilder.UserID = settings.User;
                sqlBuilder.Password = settings.Password;
            }
            connectionString = sqlBuilder.ConnectionString;
            return new StefaniniContext(connectionString, settings.Schema);
        }

        #endregion

    }
}

