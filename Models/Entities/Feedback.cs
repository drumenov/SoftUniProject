using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class Feedback
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }
        public virtual User Customer { get; set; }
    }
}
