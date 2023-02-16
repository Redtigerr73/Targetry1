
#nullable disable
using System;
using System.Collections.Generic;

namespace Targetry.Domain.Entities
{
    public partial class Requirement
    {
        public Requirement()
        {
            Modules = new HashSet<Module>();
        }

        public int Id { get; set; }
        public int RequiredModule1Id { get; set; }
        public int? RequiredModule2Id { get; set; }

        public virtual ICollection<Module> Modules { get; set; }
    }
}