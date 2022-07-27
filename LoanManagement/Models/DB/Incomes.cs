using System;
using System.Collections.Generic;

namespace LoanManagement.Models.DB
{
    public partial class Incomes
    {
        public Guid Id { get; set; }
        public double? Amount { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public Guid? UserId { get; set; }

        public virtual UserInfoes User { get; set; }
    }
}
