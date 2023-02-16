#nullable disable
using Microsoft.EntityFrameworkCore;
using Targetry.Application.Common.Interfaces;
using Targetry.Domain.Entities;

namespace Targetry.Infrastructure.Persistence
{
    public partial class TargetryContext : DbContext, ITargetryDbContext //We create an intermediate interface to access and bypass the reference to the domain
    {
        public TargetryContext()
        {
        }

        public TargetryContext(DbContextOptions<TargetryContext> options)
            : base(options)
        {
        }

        //public virtual DbSet<Certificate> Certificates { get; set; }
        //public virtual DbSet<Location> Locations { get; set; }
        //public virtual DbSet<Module> Modules { get; set; }
        //public virtual DbSet<PersInfo> PersInfos { get; set; }
        //public virtual DbSet<Qualification> Qualifications { get; set; }
        //public virtual DbSet<Requirement> Requirements { get; set; }
        //public virtual DbSet<Role> Roles { get; set; }
        //public virtual DbSet<Session> Sessions { get; set; }
        //public virtual DbSet<SessionGiver> SessionGivers { get; set; }
        //public virtual DbSet<SessionMember> SessionMembers { get; set; }
        //public virtual DbSet<SessionMembersQualification> SessionMembersQualifications { get; set; }
        //public virtual DbSet<ShootingType> ShootingTypes { get; set; }
        //public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<User> Users { get; set; }
        //public virtual DbSet<Weapon> Weapons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("Latin1_General_100_CI_AI");

            //modelBuilder.Entity<Certificate>(entity =>
            //{
            //    entity.ToTable("Certificate");

            //    entity.Property(e => e.Description)
            //        .IsRequired()
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(50);

            //    entity.HasOne(d => d.Qualification)
            //        .WithMany(p => p.Certificates)
            //        .HasForeignKey(d => d.QualificationId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_Certificate_Qualification1");

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.Certificates)
            //        .HasForeignKey(d => d.UserId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_Certificate_User");
            //});

            //modelBuilder.Entity<Location>(entity =>
            //{
            //    entity.ToTable("Location");

            //    entity.Property(e => e.Description)
            //        .IsRequired()
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<Module>(entity =>
            //{
            //    entity.ToTable("Module");

            //    entity.Property(e => e.Description)
            //        .IsRequired()
            //        .HasMaxLength(50);

            //    entity.HasOne(d => d.Requirement)
            //        .WithMany(p => p.Modules)
            //        .HasForeignKey(d => d.RequirementId)
            //        .HasConstraintName("FK_Module_Requirement");

            //    entity.HasOne(d => d.ShootingType)
            //        .WithMany(p => p.Modules)
            //        .HasForeignKey(d => d.ShootingTypeId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_Module_ShootingType");

            //    entity.HasOne(d => d.Weapon)
            //        .WithMany(p => p.Modules)
            //        .HasForeignKey(d => d.WeaponId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_Module_Weapon");
            //});

            //modelBuilder.Entity<PersInfo>(entity =>
            //{
            //    entity.ToTable("PersInfo");

            //    entity.Property(e => e.UnitEndDate).HasColumnType("datetime");

            //    entity.Property(e => e.UnitStartDate).HasColumnType("datetime");

            //    entity.HasOne(d => d.Unit)
            //        .WithMany(p => p.PersInfos)
            //        .HasForeignKey(d => d.UnitId)
            //        .HasConstraintName("FK_PersInfo_Unit");

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.PersInfos)
            //        .HasForeignKey(d => d.UserId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_PersInfo_User");
            //});

            //modelBuilder.Entity<Qualification>(entity =>
            //{
            //    entity.ToTable("Qualification");

            //    entity.Property(e => e.Description)
            //        .IsRequired()
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(50);

            //    entity.HasOne(d => d.Module)
            //        .WithMany(p => p.Qualifications)
            //        .HasForeignKey(d => d.ModuleId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_Qualification_Module");
            //});

            //modelBuilder.Entity<Requirement>(entity =>
            //{
            //    entity.ToTable("Requirement");
            //});

            //modelBuilder.Entity<Role>(entity =>
            //{
            //    entity.ToTable("Role");

            //    entity.Property(e => e.Description)
            //        .IsRequired()
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<Session>(entity =>
            //{
            //    entity.ToTable("Session");

            //    entity.Property(e => e.Description)
            //        .IsRequired()
            //        .HasMaxLength(50);

            //    entity.Property(e => e.End).HasColumnType("datetime");

            //    entity.Property(e => e.Start).HasColumnType("datetime");

            //    entity.HasOne(d => d.Location)
            //        .WithMany(p => p.Sessions)
            //        .HasForeignKey(d => d.LocationId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_Session_Location");

            //    entity.HasOne(d => d.Module)
            //        .WithMany(p => p.Sessions)
            //        .HasForeignKey(d => d.ModuleId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_Session_Module");
            //});

            //modelBuilder.Entity<SessionGiver>(entity =>
            //{
            //    entity.ToTable("SessionGiver");

            //    entity.HasOne(d => d.Session)
            //        .WithMany(p => p.SessionGivers)
            //        .HasForeignKey(d => d.SessionId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_SessionGiver_Session");

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.SessionGivers)
            //        .HasForeignKey(d => d.UserId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_SessionGiver_User");
            //});

            //modelBuilder.Entity<SessionMember>(entity =>
            //{
            //    entity.HasOne(d => d.Session)
            //        .WithMany(p => p.SessionMembers)
            //        .HasForeignKey(d => d.SessionId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_SessionMembers_Session");

            //    entity.HasOne(d => d.User)
            //        .WithMany(p => p.SessionMembers)
            //        .HasForeignKey(d => d.UserId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_SessionMembers_User");
            //});

            //modelBuilder.Entity<SessionMembersQualification>(entity =>
            //{
            //    entity.ToTable("SessionMembersQualification");

            //    entity.Property(e => e.Id).ValueGeneratedOnAdd();

            //    entity.HasOne(d => d.IdNavigation)
            //        .WithOne(p => p.SessionMembersQualification)
            //        .HasForeignKey<SessionMembersQualification>(d => d.Id)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_SessionMembersQualification_SessionMembers");

            //    entity.HasOne(d => d.Qualification)
            //        .WithMany(p => p.SessionMembersQualifications)
            //        .HasForeignKey(d => d.QualificationId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_SessionMembersQualification_Qualification");
            //});

            //modelBuilder.Entity<ShootingType>(entity =>
            //{
            //    entity.ToTable("ShootingType");

            //    entity.Property(e => e.Description)
            //        .IsRequired()
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<Unit>(entity =>
            //{
            //    entity.ToTable("Unit");

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(50);
            //});

            //modelBuilder.Entity<User>(entity =>
            //{
            //    entity.ToTable("User");

            //    entity.Property(e => e.Email)
            //        .IsRequired()
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Matricule)
            //        .IsRequired()
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(50);

            //    entity.HasOne(d => d.Role)
            //        .WithMany(p => p.Users)
            //        .HasForeignKey(d => d.RoleId)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK_User_Role");
            //});

            //modelBuilder.Entity<Weapon>(entity =>
            //{
            //    entity.ToTable("Weapon");

            //    entity.Property(e => e.Description)
            //        .IsRequired()
            //        .HasMaxLength(50);

            //    entity.Property(e => e.Name)
            //        .IsRequired()
            //        .HasMaxLength(50);
            //});

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken) 
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}