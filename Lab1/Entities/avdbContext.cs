using System.Data.Entity;

namespace Lab1.Entities
{
    public class avdbContext : DbContext
    {
        public avdbContext()
            : base("name=avdb")
        { }

        public virtual DbSet<Client> Clients { get; set; }

        public virtual DbSet<City> Cities { get; set; }

        public virtual DbSet<Disability> Disabilities { get; set; }

        public virtual DbSet<Nationality> Nationalities { get; set; }

        public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; }

        public virtual DbSet<Gender> Genders { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>()
                .HasMany(e => e.Clients)
                .WithRequired(e => e.LocationCity)
                .HasForeignKey(e => e.LocationCityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<City>()
                .HasMany(e => e.Clients)
                .WithRequired(e => e.RegistrationCity)
                .HasForeignKey(e => e.RegistrationCityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Clients)
                .WithRequired(e => e.Gender)
                .HasForeignKey(e => e.GenderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Nationality>()
                .HasMany(e => e.Clients)
                .WithRequired(e => e.Nationality)
                .HasForeignKey(e => e.NationalityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Disability>()
                .HasMany(e => e.Clients)
                .WithRequired(e => e.Disability)
                .HasForeignKey(e => e.DisabilityId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MaritalStatus>()
                .HasMany(e => e.Clients)
                .WithRequired(e => e.MaritalStatus)
                .HasForeignKey(e => e.MaritalStatusId)
                .WillCascadeOnDelete(false);
        }
    }
}