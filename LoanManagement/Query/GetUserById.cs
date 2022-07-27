using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanManagement.Models.DB;
using MediatR;

namespace LoanManagement.Query
{
    public class GetUserById : IRequest<UserInfoes>
    {
        public Guid _id { get; set; }

        public GetUserById(Guid id) {
            _id = id;
        }

    }
}
