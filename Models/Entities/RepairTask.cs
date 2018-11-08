using Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class RepairTask
    {
        public int Id { get; set; }

        public virtual ICollection<UserRepairTask> Experts { get; set; }

        public Status Status { get; set; }
    }
}
