#nullable disable
using System;
using System.Collections.Generic;

namespace Targetry.Domain.Entities
{
    public partial class Location
    {
        public Location()
        {
            Sessions = new HashSet<Session>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double? MaxDistance { get; set; }

        public virtual ICollection<Session> Sessions { get; set; }
    }
}