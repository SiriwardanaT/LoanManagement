using System;
using System.Collections.Generic;

namespace LoanManagement.Models.DB
{
    public partial class Income
    {
        public int Id { get; set; }
        public double? Amount { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public int? UserId { get; set; }

        public virtual UserInfo User { get; set; }
    }
}
