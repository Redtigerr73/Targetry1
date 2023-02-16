
#nullable disable
using System;
using System.Collections.Generic;

namespace Targetry.Domain.Entities
{
    public partial class SessionMembersQualification
    {
        public int Id { get; set; }
        public int QualificationId { get; set; }
        public int ValidatorUserId { get; set; }
        public bool Passed { get; set; }
        public int? Grade { get; set; }

        //public virtual SessionMember IdNavigation { get; set; }
        //public virtual Qualification Qualification { get; set; }
    }
}