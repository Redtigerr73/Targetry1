using Microsoft.EntityFrameworkCore;
using Targetry.Domain.Entities;

namespace Targetry.Application.Common.Interfaces
{
    public interface ITargetryDbContext
    {
        //DbSet<Module> Modules { get; set; }
        //DbSet<Location> Locations { get; set; }
        //DbSet<Certificate> Certificates { get; set; }
        //DbSet<PersInfo> PersInfos { get; set; }
        //DbSet<Qualification> Qualifications { get; set; }
        //DbSet<Requirement> Requirements { get; set; }
        //DbSet<Role> Roles { get; set; }
        //DbSet<Session> Sessions { get; set; }
        //DbSet<SessionGiver> SessionGivers { get; set; }
        //DbSet<SessionMember> SessionMembers { get; set; }
        //DbSet<SessionMembersQualification> SessionMembersQualifications { get; set; }
        //DbSet<ShootingType> ShootingTypes { get; set; }
        //DbSet<Unit> Units { get; set; }
        DbSet<User> Users { get; set; }
        //DbSet<Weapon> Weapons { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken); //Used to control the commit CRUD to be pushed in the DB - Like Github
    }
}
