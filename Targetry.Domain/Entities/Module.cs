
#nullable disable
using System;
using System.Collections.Generic;

namespace Targetry.Domain.Entities
{
    public partial class Module
    {
        public Module()
        {
            Qualifications = new HashSet<Qualification>();
            Sessions = new HashSet<Session>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int ShootingTypeId { get; set; }
        public int WeaponId { get; set; }
        public int? RequirementId { get; set; }

        public virtual Requirement Requirement { get; set; }
        public virtual ShootingType ShootingType { get; set; }
        public virtual Weapon Weapon { get; set; }
        public virtual ICollection<Qualification> Qualifications { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
    }
}