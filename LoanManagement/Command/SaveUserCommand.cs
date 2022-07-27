using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanManagement.Models.DB;
using MediatR;

namespace LoanManagement.Command
{
    public class SaveUserCommand : IRequest<UserInfoes>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
