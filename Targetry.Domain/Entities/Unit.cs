
#nullable disable
using System;
using System.Collections.Generic;

namespace Targetry.Domain.Entities
{
    public partial class Unit
    {
        public Unit()
        {
            PersInfos = new HashSet<PersInfo>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PersInfo> PersInfos { get; set; }
    }
}