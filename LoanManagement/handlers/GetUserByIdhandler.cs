using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using LoanManagement.DataAcesses;
using LoanManagement.Models.DB;
using LoanManagement.Query;
using MediatR;

namespace LoanManagement.handlers
{
    public class GetUserByIdhandler : IRequestHandler<GetUserById, UserInfoes>
    {
        private readonly IDataAccessRepository _dataAcess;
        public GetUserByIdhandler(IDataAccessRepository dataAcess) {
            _dataAcess = dataAcess;
        }
        public Task<UserInfoes> Handle(GetUserById request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAcess.getUserById(request._id));
        }
    }
}
