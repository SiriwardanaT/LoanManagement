using System;
using System.Collections.Generic;

namespace LoanManagement.Models.DB
{
    public partial class UserInfo
    {
        public UserInfo()
        {
            Expenditure = new HashSet<Expenditure>();
            Income = new HashSet<Income>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Expenditure> Expenditure { get; set; }
        public virtual ICollection<Income> Income { get; set; }
    }
}
