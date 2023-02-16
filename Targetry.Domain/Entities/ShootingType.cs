#nullable disable
using System;
using System.Collections.Generic;

namespace Targetry.Domain.Entities
{
    public partial class ShootingType
    {
        public ShootingType()
        {
            Modules = new HashSet<Module>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Module> Modules { get; set; }
    }
}