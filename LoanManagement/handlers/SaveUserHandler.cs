using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LoanManagement.Command;
using LoanManagement.Models.DB;
using MediatR;

namespace LoanManagement.handlers
{
    public class SaveUserHandler : IRequestHandler<SaveUserCommand, UserInfoes>
    {
        public Task<UserInfoes> Handle(SaveUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
