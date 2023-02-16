#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Targetry.Domain.Entities
{
    public partial class User
    {
        public User()
        {
            Certificates = new HashSet<Certificate>();
            PersInfos = new HashSet<PersInfo>();
            SessionGivers = new HashSet<SessionGiver>();
            SessionMembers = new HashSet<SessionMember>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Matricule { get; set; }
        public int RoleId { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<Certificate> Certificates { get; set; }
        public virtual ICollection<PersInfo> PersInfos { get; set; }
        public virtual ICollection<SessionGiver> SessionGivers { get; set; }
        public virtual ICollection<SessionMember> SessionMembers { get; set; }
    }
}