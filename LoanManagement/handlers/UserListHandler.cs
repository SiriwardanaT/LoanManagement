using System;
using MediatR;
using System.Linq;
using System.Threading;
using LoanManagement.Query;
using System.Threading.Tasks;
using LoanManagement.Models.DB;
using LoanManagement.DataAcesses;
using System.Collections.Generic;

namespace LoanManagement.handlers
{
    public class UserListHandler : IRequestHandler<UserListQuery, List<UserInfoes>>
    {
        private readonly IDataAccessRepository _dataAcess;
        public  UserListHandler(IDataAccessRepository dataAcess) {
            _dataAcess = dataAcess;
        }
        public Task<List<UserInfoes>> Handle(UserListQuery request, CancellationToken cancellationToken)
        {
           return Task.FromResult(_dataAcess.getAllUsers());
        }
    }
}
