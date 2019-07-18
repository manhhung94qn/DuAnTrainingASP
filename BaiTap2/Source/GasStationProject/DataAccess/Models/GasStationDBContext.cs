namespace DataAccess.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GasStationDBContext : DbContext
    {
        public GasStationDBContext()
            : base("name=GasStationDBContext")
        {
        }

        public virtual DbSet<GasStation> GasStation { get; set; }
        public virtual DbSet<GasStationFeedback> GasStationFeedback { get; set; }
        public virtual DbSet<GasStationGasType> GasStationGasType { get; set; }
        public virtual DbSet<M_District> M_District { get; set; }
        public virtual DbSet<M_Type> M_Type { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GasStation>()
                .Property(e => e.Rating)
                .IsUnicode(false);

            modelBuilder.Entity<GasStation>()
                .HasMany(e => e.GasStationFeedback)
                .WithRequired(e => e.GasStation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GasStationGasType>()
                .Property(e => e.GasType)
                .IsUnicode(false);

            modelBuilder.Entity<M_Type>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UserType)
                .IsUnicode(false);
        }

    }
}
