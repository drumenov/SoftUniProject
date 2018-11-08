using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<Part> OrderedParts { get; set; }
    }
}
