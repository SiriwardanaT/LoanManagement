using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LoanManagement.DataAcesses;
using LoanManagement.Models.DB;
using MediatR;
namespace LoanManagement.Query
{

   
    public class UserListQuery: IRequest<List<UserInfoes>> {
        
        public UserListQuery()
        {
        }

    }

}
