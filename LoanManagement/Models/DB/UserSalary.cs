using System;
using System.Collections.Generic;

namespace LoanManagement.Models.DB
{
    public partial class UserSalary
    {
        public Guid Id { get; set; }
        public double? Amount { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public int? IsClosed { get; set; }
        public Guid? UserId { get; set; }
        public int? Day { get; set; }

        public virtual UserInfoes User { get; set; }
    }
}
