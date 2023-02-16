
#nullable disable
using System;
using System.Collections.Generic;

namespace Targetry.Domain.Entities
{
    public partial class Qualification
    {
        public Qualification()
        {
            Certificates = new HashSet<Certificate>();
            SessionMembersQualifications = new HashSet<SessionMembersQualification>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ModuleId { get; set; }

        public virtual Module Module { get; set; }
        public virtual ICollection<Certificate> Certificates { get; set; }
        public virtual ICollection<SessionMembersQualification> SessionMembersQualifications { get; set; }
    }
}