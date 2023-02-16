#nullable disable
using System;
using System.Collections.Generic;

namespace Targetry.Domain.Entities
{
    public partial class Certificate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int QualificationId { get; set; }
        public int UserId { get; set; }

        public virtual Qualification Qualification { get; set; }
        public virtual User User { get; set; }
    }
}