
#nullable disable
using System;
using System.Collections.Generic;

namespace Targetry.Domain.Entities
{
    public partial class PersInfo
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int? UnitId { get; set; }
        public DateTime? UnitStartDate { get; set; }
        public DateTime? UnitEndDate { get; set; }

        public virtual Unit Unit { get; set; }
        public virtual User User { get; set; }
    }
}