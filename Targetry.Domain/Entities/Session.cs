#nullable disable
using System;
using System.Collections.Generic;

namespace Targetry.Domain.Entities
{
    public partial class Session
    {
        public Session()
        {
            SessionGivers = new HashSet<SessionGiver>();
            SessionMembers = new HashSet<SessionMember>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int ModuleId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int LocationId { get; set; }

        public virtual Location Location { get; set; }
        public virtual Module Module { get; set; }
        public virtual ICollection<SessionGiver> SessionGivers { get; set; }
        public virtual ICollection<SessionMember> SessionMembers { get; set; }
    }
}