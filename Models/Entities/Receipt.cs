﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class Receipt
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<ExpertReceipt> ExpertsHavingWorkedOnRepairTask { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
