using System;
using System.Collections.Generic;

namespace LoanManagement.Models.DB
{
    public partial class Expenditure
    {
        public int Id { get; set; }
        public double? Amount { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? IsClosed { get; set; }
        public string Reason { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UserId { get; set; }

        public virtual UserInfo User { get; set; }
    }
}
