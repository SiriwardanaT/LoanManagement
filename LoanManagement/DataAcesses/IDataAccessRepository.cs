using LoanManagement.Models.DB;
using System;
using System.Collections.Generic;

namespace LoanManagement.DataAcesses
{
    public interface IDataAccessRepository
    {
        List<UserInfoes> getAllUsers();
        UserInfoes getUserById(Guid id);
    }
}