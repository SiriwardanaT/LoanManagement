using System;
using System.Collections.Generic;

namespace LoanManagement.Models.DB
{
    public partial class UserInfoes
    {
        public UserInfoes()
        {
            Expenditures = new HashSet<Expenditures>();
            Incomes = new HashSet<Incomes>();
            UserSalary = new HashSet<UserSalary>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Expenditures> Expenditures { get; set; }
        public virtual ICollection<Incomes> Incomes { get; set; }
        public virtual ICollection<UserSalary> UserSalary { get; set; }
    }
}
